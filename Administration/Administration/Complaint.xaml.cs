using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MessageBox = System.Windows.MessageBox;

namespace Administration
{
    /// <summary>
    /// Окно предназначено для отображения таблицы базы данных
    /// </summary>
    public partial class Complaint : Page
    {
        administrationEntities db = new administrationEntities();
        public Complaint()
        {
            InitializeComponent();
            data.ItemsSource = db.Complaints.ToList();


        }
        //05.04.2023 Калинин Арсений Олегович Описание: добавление записи жалоб
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                addComplaint b = new addComplaint(); //05.04.2023 Калинин Арсений Олегович Описание: переменная b обозначает сокращение BaseAddComplaint 
                Complaints a = new Complaints(); //05.04.2023 Калинин Арсений Олегович Описание: переменная а обозначает сокращение ActiveTable
                if (b.ShowDialog() == true)
                {

                    a.C__doc = b.numdoc.Text;
                    a.Date_registrate = (DateTime)datamine.reg;
                    a.FIO = b.fio.Text;
                    a.Correspondent = b.core.Text;
                    a.Date_doc = datamine.doc;
                    a.Index_doc = b.indexdoc.Text;
                    a.Adress = b.adress.Text;
                    a.Resolution = b.rezole.Text;
                    a.Executor = b.execute.Text;
                    a.Period = datamine.per;
                    a.Executed = datamine.exe;
                    a.Result = b.result.Text;
                    a.C__dela = b.ndela.Text;
                    a.C__toma = b.ntoma.Text;
                    a.C__ctr = b.nstr.Text;
                    a.FIle = b.file;
                    db.Complaints.Add(a);
                    db.SaveChanges();
                    data.ItemsSource = db.Complaints.ToList();
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
                var up = (Complaints)data.SelectedItem;
                if (up != null)
                {
                    addComplaint b = new addComplaint();//05.04.2023 Калинин Арсений Олегович Описание: переменная b обозначает сокращение BaseAddComplaint 
                    b.numdoc.Text = up.C__doc;
                    b.dateReg.SelectedDate = up.Date_registrate;
                    b.fio.Text = up.FIO;
                    b.core.Text = up.Correspondent;
                    b.indexdoc.Text = up.Index_doc;
                    b.datedoc.SelectedDate = up.Date_doc;
                    b.adress.Text = up.Adress;
                    b.rezole.Text = up.Resolution;
                    b.execute.Text = up.Executor;
                    b.period.SelectedDate = up.Period;
                    b.exe.SelectedDate = up.Executed;
                    b.result.Text = up.Result;
                    b.ndela.Text = up.C__dela;
                    b.ntoma.Text = up.C__toma;
                    b.nstr.Text = up.C__ctr;
                    b.file = up.FIle;
                    b.open.Visibility = Visibility.Visible;
                    b.add.Content = "Изменить";
                    if (b.ShowDialog() == true)
                    {
                        Complaints a = db.Complaints.Find(up.ID); //05.04.2023 Калинин Арсений Олегович Описание: переменная а обозначает сокращение ActiveTable
                        a.C__doc = b.numdoc.Text;
                        a.Date_registrate = (DateTime)datamine.reg;
                        a.FIO = b.fio.Text;
                        a.Correspondent = b.core.Text;
                        a.Date_doc = datamine.doc;
                        a.Index_doc = b.indexdoc.Text;
                        a.Adress = b.adress.Text;
                        a.Resolution = b.rezole.Text;
                        a.Executor = b.execute.Text;
                        a.Period = datamine.per;
                        a.Executed = datamine.exe;
                        a.Result = b.result.Text;
                        a.C__dela = b.ndela.Text;
                        a.C__toma = b.ntoma.Text;
                        a.C__ctr = b.nstr.Text;
                        a.FIle = b.file;
                        db.SaveChanges();
                        data.ItemsSource = db.Complaints.ToList();
                    }
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
        //05.04.2023 Калинин Арсений Олегович Описание: метод предназначен для удаления строки из базы данных
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var del = (Complaints)data.SelectedItem;
                if (del != null)
                {
                    var use = db.Complaints.FirstOrDefault(u => u.ID == del.ID);
                    db.Complaints.Remove(use);
                    db.SaveChanges();
                    data.ItemsSource = db.Complaints.ToList();
                    MessageBox.Show("Запись удалена");
                }
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

                var pr = (Complaints)data.SelectedItem;
                if (pr != null)
                {
                    datamine.nd = pr.C__doc;
                    datamine.fi = pr.FIO;
                    datamine.kc = pr.Result;
                    datamine.cor = pr.Correspondent;
                    datamine.ex = pr.Executor;
                    datamine.dr = pr.Date_registrate.ToString("d.M.yyyy");
                    datamine.ao = pr.Adress;
                    datamine.isComplaint = true;
                    DateTime dateTime = (DateTime)pr.Period;
                    datamine.pe = dateTime.ToString("d.M.yyyy");
                    Print p = new Print();
                    if (p.ShowDialog() == true)
                    {

                    }
                    datamine.isComplaint = false;
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
                Complaints a = data.SelectedItem as Complaints;
                if (a != null)
                {
                    adress.Text = a.Adress;
                    rezol.Text = a.Resolution;
                    cont.Text = a.Result;
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
                var date = row.DataContext as Complaints;
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
                    data.ItemsSource = db.Complaints.ToList();
                }
                else
                {
                    data.ItemsSource = db.Complaints.Where(x => x.FIO.Contains(search.Text) || x.Result.Contains(search.Text) || x.Adress.Contains(search.Text)).ToList();
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
                    data.ItemsSource = db.Complaints.ToList();
                }
                else if (combo.SelectedIndex == 1)
                {
                    data.ItemsSource = db.Complaints.Where(x => (x.Period >= DateTime.Now && x.Executed == null) || x.Period == null).ToList();
                }
                else if (combo.SelectedIndex == 2)
                {
                    data.ItemsSource = db.Complaints.Where(x => x.Executed == null && x.Period < DateTime.Now).ToList();
                }
                else if (combo.SelectedIndex == 3)
                {
                    data.ItemsSource = db.Complaints.Where(x => x.Executed != null && x.Executed <= x.Period).ToList();
                }
                else if (combo.SelectedIndex == 4)
                {
                    data.ItemsSource = db.Complaints.Where(x => x.Executed > x.Period).ToList();
                }
            }
            catch
            {

            }

        }
    }
}
