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
    /// Окно меню реализуемая посредством frame
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            Main.Content = new Complaint();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Letter();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Complaint();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
