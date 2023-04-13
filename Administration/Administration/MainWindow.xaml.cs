using System.Linq;
using System.Windows;

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
            try
            {
                using (var db = new administrationEntities())
                {
                    var user = db.Authorization.FirstOrDefault(u => u.Login == login.Text && u.Password == password.Password);
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
            catch
            {
                MessageBox.Show("Ошибка подключения к БД");
            }
        }
    }
}
