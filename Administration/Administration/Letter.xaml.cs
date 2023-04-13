using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Administration
{
    /// <summary>
    /// Окно предназначено для отображения таблицы базы данных
    /// </summary>
    public partial class Letter : Page
    {
        administrationEntities db = new administrationEntities();
        public Letter()
        {
            InitializeComponent();
            data.ItemsSource = db.Letters.ToList();
        }
        //05.04.2023 Калинин Арсений Олегович Описание: добавление записи жалоб
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                addLetter b = new addLetter(); //05.04.2023 Калинин Арсений Олегович Описание: переменная b обозначает сокращение BaseAddLetter 
                Letters a = new Letters(); //05.04.2023 Калинин Арсений Олегович Описание: переменная а обозначает сокращение ActiveTable
                if (b.ShowDialog() == true)
                {
                    a.C__doc = b.numdoc.Text;
                    a.Date_registrate = (DateTime)datamine.reg;
                    a.Type_doc = b.combo.Text;
                    a.Correspondent = b.core.Text;
                    a.Date_doc = datamine.doc;
                    a.Index_doc = b.indexdoc.Text;
                    a.Note = b.result.Text;
                    a.Resolution = b.rezole.Text;
                    a.Executor = b.execute.Text;
                    a.Period = datamine.per;
                    a.Executed = datamine.exe;
                    a.Content_doc = b.cont.Text;
                    a.C__dela = b.ndela.Text;
                    a.C__toma = b.ntoma.Text;
                    a.C__ctr = b.nstr.Text;
                    a.FIle = b.file;
                    db.Letters.Add(a);
                    db.SaveChanges();
                    data.ItemsSource = db.Letters.ToList();
                }
                datamine.doc = null;
                datamine.reg = null;
                datamine.exe = null;
                datamine.per = null;
            }
            catch
            {

            }

        }
        //05.04.2023 Калинин Арсений Олегович Описание: метод предназначен для редактирования строки в базе данных
        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var up = (Letters)data.SelectedItem;
                if (up != null)
                {
                    addLetter b = new addLetter(); //05.04.2023 Калинин Арсений Олегович Описание: переменная b обозначает сокращение BaseAddLetter 
                    b.numdoc.Text = up.C__doc;
                    b.dateReg.SelectedDate = up.Date_registrate;
                    b.combo.Text = up.Type_doc;
                    b.core.Text = up.Correspondent;
                    b.indexdoc.Text = up.Index_doc;
                    b.datedoc.SelectedDate = up.Date_doc;
                    b.rezole.Text = up.Resolution;
                    b.execute.Text = up.Executor;
                    b.period.SelectedDate = up.Period;
                    b.cont.Text = up.Content_doc;
                    b.exe.SelectedDate = up.Executed;
                    b.result.Text = up.Note;
                    b.ndela.Text = up.C__dela;
                    b.ntoma.Text = up.C__toma;
                    b.nstr.Text = up.C__ctr;
                    b.file = up.FIle;
                    b.open.Visibility = Visibility.Visible;
                    b.add.Content = "Изменить";
                    if (b.ShowDialog() == true)
                    {
                        Letters a = db.Letters.Find(up.ID);//05.04.2023 Калинин Арсений Олегович Описание: переменная а обозначает сокращение ActiveTable
                        a.C__doc = b.numdoc.Text;
                        a.Date_registrate = (DateTime)datamine.reg;
                        a.Type_doc = b.combo.Text;
                        a.Correspondent = b.core.Text;
                        a.Date_doc = datamine.doc;
                        a.Index_doc = b.indexdoc.Text;
                        a.Note = b.result.Text;
                        a.Resolution = b.rezole.Text;
                        a.Executor = b.execute.Text;
                        a.Period = datamine.per;
                        a.Executed = datamine.exe;
                        a.Content_doc = b.cont.Text;
                        a.C__dela = b.ndela.Text;
                        a.C__toma = b.ntoma.Text;
                        a.C__ctr = b.nstr.Text;
                        a.FIle = b.file;
                        db.SaveChanges();
                        data.ItemsSource = db.Letters.ToList();
                    }
                }
            }
            catch
            {

            }
        }
        //05.04.2023 Калинин Арсений Олегович Описание: метод предназначен для удаления строки из базы данных
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var del = (Letters)data.SelectedItem;
                var use = db.Letters.FirstOrDefault(u => u.ID == del.ID);
                db.Letters.Remove(use);
                db.SaveChanges();
                data.ItemsSource = db.Letters.ToList();
                MessageBox.Show("Запись удалена");
            }
            catch
            {

            }
        }
        //05.04.2023 Калинин Арсений Олегович Описание: метод предназначен для предачи переменных печати выбранной строки и вызов диалога печати
        private void print_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var pr = (Letters)data.SelectedItem;
                if (pr != null)
                {
                    datamine.nd = pr.C__doc;
                    //datamine.fi = pr.FIO;
                    datamine.kc = pr.Content_doc;
                    datamine.cor = pr.Correspondent;
                    datamine.ex = pr.Executor;
                    datamine.dr = pr.Date_registrate.ToString("d.M.yyyy");
                    //datamine.ao = pr.Note;
                    DateTime dateTime = (DateTime)pr.Period;
                    datamine.pe = dateTime.ToString("d.M.yyyy");
                    Print p = new Print();
                    if (p.ShowDialog() == true)
                    {

                    }
                    datamine.nd = null;
                    datamine.ex = null;
                    datamine.fi = null;
                    datamine.kc = null;
                    datamine.cor = null;
                    datamine.dr = null;
                    datamine.ao = null;
                    datamine.pe = null;

                }
            }
            catch
            {

            }
        }
        //04.04.2023 Калинин Арсений Олегович Описание: метод предназначен для расшеренного отображения данных в текстовых полях
        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Letters a = data.SelectedItem as Letters;
                if (a != null)
                {
                    result.Text = a.Note;
                    rezol.Text = a.Resolution;
                    cont.Text = a.Content_doc;
                }
            }
            catch
            {

            }
        }
        //04.04.2023 Калинин Арсений Олегович Описание: метод предназначен для визуального отображения даты
        private void data_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            try
            {
                var row = e.Row;
                var date = row.DataContext as Letters;
                if (data.SelectedItems != null)
                {
                    if (date == null)
                    {
                        return;
                    }
                    else if (date.Executed == null && date.Period < DateTime.Now)
                    {
                        row.Background = new SolidColorBrush(Colors.Red);
                        row.Foreground = new SolidColorBrush(Colors.White);
                    }
                    else if (date.Executed > date.Period)
                    {
                        row.Background = new SolidColorBrush(Colors.Blue);
                        row.Foreground = new SolidColorBrush(Colors.White);

                    }
                    else if (date.Executed != null)
                    {
                        row.Background = new SolidColorBrush(Colors.Green);
                        row.Foreground = new SolidColorBrush(Colors.White);
                    }
                    else
                    {
                        row.Background = new SolidColorBrush(Colors.Yellow);
                    }
                }
                return;
            }
            catch
            {

            }
        }
        //06.04.2023 Калинин Арсений Олегович Описание: метод предназначен для поиска значений по ФИО, адресу и результату
        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (search.Text == "")
                {
                    data.ItemsSource = db.Letters.ToList();
                }
                else
                {
                    data.ItemsSource = db.Letters.Where(x => x.Content_doc.Contains(search.Text) || x.Executor.Contains(search.Text) || x.Note.Contains(search.Text)).ToList();
                }
            }
            catch
            {

            }
        }

        //06.04.2023 Калинин Арсений Олегович Описание: метод предназначен для сортировки таблицы по датам
        private void combo_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (combo.SelectedIndex == 0)
                {
                    data.ItemsSource = db.Letters.ToList();
                }
                else if (combo.SelectedIndex == 1)
                {
                    data.ItemsSource = db.Letters.Where(x => (x.Period >= DateTime.Now && x.Executed == null) || x.Period == null).ToList();
                }
                else if (combo.SelectedIndex == 2)
                {
                    data.ItemsSource = db.Letters.Where(x => x.Executed == null && x.Period < DateTime.Now).ToList();
                }
                else if (combo.SelectedIndex == 3)
                {
                    data.ItemsSource = db.Letters.Where(x => x.Executed != null && x.Executed <= x.Period).ToList();
                }
                else if (combo.SelectedIndex == 4)
                {
                    data.ItemsSource = db.Letters.Where(x => x.Executed > x.Period).ToList();
                }
            }
            catch
            {

            }

        }

    }
}
