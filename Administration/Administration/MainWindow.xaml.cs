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
    /// Стартовое окно авторизации
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //04.04.2023 Калинин Арсений Олегович Описание: метод предназначен для авторизации
        private void sign_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new administrationEntities())
            {
                var user = db.Authorization.FirstOrDefault(u=>u.Login==login.Text&& u.Password==password.Password);
                if (user == null)
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                else
                {
                    Menu a = new Menu();
                    a.Show();
                    this.Close();
                }
            }
        }
    }
}
