using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Administration
{
    /// <summary>
    /// Логика взаимодействия для Letter.xaml
    /// </summary>
    public partial class Letter : Page
    {
        administrationEntities db = new administrationEntities();
        public Letter()
        {
            InitializeComponent();
            data.ItemsSource = db.Letters.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            addLetter b = new addLetter();
            Letters a = new Letters();
            if(b.ShowDialog()==true)
            {
                if(b.numdoc.Text!="")
                    a.C__doc = Convert.ToInt32(b.numdoc.Text);
                a.Date_registrate = (DateTime)datamine.reg;
                a.Type_doc = b.combo.Text;
                a.Correspondent = b.core.Text;
                a.Date_doc = datamine.doc;
                if (b.indexdoc.Text != "")
                    a.Index_doc = Convert.ToInt32(b.indexdoc.Text);
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

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var up = (Letters)data.SelectedItem;
                if (up != null)
                {
                    addLetter b = new addLetter();
                    b.numdoc.Text = up.C__doc.ToString();
                    b.dateReg.SelectedDate = up.Date_registrate;
                    b.combo.Text = up.Type_doc;
                    b.core.Text = up.Correspondent;
                    b.indexdoc.Text = up.Index_doc.ToString();
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
                    b.add.Content = "Изменить";
                    if (b.ShowDialog() == true)
                    {
                        Letters a = db.Letters.Find(up.ID);
                        if (b.numdoc.Text != "")
                            a.C__doc = Convert.ToInt32(b.numdoc.Text);
                        a.Date_registrate = (DateTime)datamine.reg;
                        a.Type_doc = b.combo.Text;
                        a.Correspondent = b.core.Text;
                        a.Date_doc = datamine.doc;
                        if (b.indexdoc.Text != "")
                            a.Index_doc = Convert.ToInt32(b.indexdoc.Text);
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
                        data.ItemsSource = db.Complaints.ToList();
                    }
                    b.add.Content = "Добавить";
                }
            }
            catch
            {

            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var del = (Letters)data.SelectedItem;
            var use = db.Letters.FirstOrDefault(u => u.ID == del.ID);
            db.Letters.Remove(use);
            db.SaveChanges();
            data.ItemsSource = db.Letters.ToList();
            MessageBox.Show("Запись удалена");
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {

        }

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Letters a = data.SelectedItem as Letters;
            if (a != null)
            {
                result.Text = a.Note;
                rezol.Text = a.Resolution;
                cont.Text = a.Content_doc;
            }
        }

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
    }
}
