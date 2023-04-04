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
            Letters a = data.SelectedItem as Letters;
            if (a != null)
            {
                result.Text = a.Note;
                rezol.Text = a.Resolution;
                cont.Text = a.Content_doc;
            }
        }
    }
}
