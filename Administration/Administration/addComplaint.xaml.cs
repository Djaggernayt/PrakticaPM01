using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Administration
{
    /// <summary>
    /// Логика взаимодействия для addComplaint.xaml
    /// </summary>
    public partial class addComplaint : Window
    {
        administrationEntities db = new administrationEntities();
        public string file=null;
        public addComplaint()
        {
            InitializeComponent();
        }

        private void attach_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Документы|*.pdf;*.doc;*.docx|Все файлы|*.*";
            if(open.ShowDialog()==true)
            {
                file = open.FileName;
            }
            
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                datamine.reg = (DateTime)dateReg.SelectedDate;
                datamine.exe = exe.SelectedDate;
                datamine.doc = datedoc.SelectedDate;
                datamine.per = period.SelectedDate;
                this.DialogResult = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void indexdoc_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.Key >= Key.D0 && e.Key <= Key.D9) ||
          (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) ||
           e.Key == Key.Back || e.Key == Key.Delete))
            {
                e.Handled = true;
            }
        }
    }
}
