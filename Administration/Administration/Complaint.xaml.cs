using System;
using System.CodeDom.Compiler;
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
    /// Логика взаимодействия для Complaint.xaml
    /// </summary>
    public partial class Complaint : Page
    {
        administrationEntities db = new administrationEntities();
        public Complaint()
        {
            InitializeComponent();
            data.ItemsSource = db.Complaints.ToList();

            
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            addComplaint b = new addComplaint();
            Complaints a = new Complaints();
            if (b.ShowDialog()==true)
            {
                
                a.C__doc = b.numdoc.Text;
                a.Date_registrate = (DateTime)datamine.reg;
                a.FIO = b.fio.Text;
                a.Correspondent = b.core.Text;
                a.Date_doc = datamine.doc;
                if (b.indexdoc.Text != "")
                    a.Index_doc = Convert.ToInt32(b.indexdoc.Text);
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

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var up = (Complaints)data.SelectedItem;
                if (up != null)
                {
                    addComplaint b = new addComplaint();
                    b.numdoc.Text = up.C__doc;
                    b.dateReg.SelectedDate = up.Date_registrate;
                    b.fio.Text = up.FIO;
                    b.core.Text = up.Correspondent;
                    b.indexdoc.Text = up.Index_doc.ToString();
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
                    b.add.Content = "Изменить";
                    if (b.ShowDialog() == true)
                    {
                        Complaints a = db.Complaints.Find(up.ID);
                        a.C__doc = b.numdoc.Text;
                        a.Date_registrate = (DateTime)datamine.reg;
                        a.FIO = b.fio.Text;
                        a.Correspondent = b.core.Text;
                        a.Date_doc = datamine.doc;
                        if (b.indexdoc.Text != "")
                            a.Index_doc = Convert.ToInt32(b.indexdoc.Text);
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
                    b.add.Content = "Добавить";
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
                    datamine.dr = pr.Date_registrate.ToString("d.M.yyyy");
                    datamine.ao = pr.Adress;
                    DateTime dateTime = (DateTime)pr.Period;
                    datamine.pe = dateTime.ToString("d.M.yyyy");
                    Print p = new Print();
                    if (p.ShowDialog() == true)
                    {
                        
                    }
                    datamine.nd = null;
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

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Complaints a = data.SelectedItem as Complaints;
            if (a != null)
            {
                adress.Text = a.Adress;
                rezol.Text = a.Resolution;
                cont.Text = a.Result;
            }
        }

        private void data_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            try
            {
                var row = e.Row;
                var date = row.DataContext as Complaints;
                if(data.SelectedItems!=null)
                {
                    if(date == null)
                    {
                        return;
                    }
                    else if(date.Executed==null&&date.Period<DateTime.Now)
                    {
                        row.Background = new SolidColorBrush(Colors.Red);
                        row.Foreground = new SolidColorBrush(Colors.White);
                    }
                    else if(date.Executed>date.Period)
                    {
                        row.Background = new SolidColorBrush(Colors.Blue);
                        row.Foreground = new SolidColorBrush(Colors.White);

                    }
                    else if(date.Executed != null)
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
