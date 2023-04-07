using System.Drawing;
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
            b2.Background = new SolidColorBrush(Colors.White);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Letter();
            b1.Background = new SolidColorBrush(Colors.White);
            b2.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Complaint();
            b2.Background = new SolidColorBrush(Colors.White);
            b1.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
