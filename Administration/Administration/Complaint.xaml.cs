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

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void print_Click(object sender, RoutedEventArgs e)
        {

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


    }
}
