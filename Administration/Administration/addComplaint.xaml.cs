using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Окно предназначено для добавления жалоб
    /// </summary>
    public partial class addComplaint : Window
    {
        administrationEntities db = new administrationEntities();
        public string file=null;
        public addComplaint()
        {
            InitializeComponent();
        }
        //06.04.2023 Калинин Арсений Олегович Описание: метод предназначен для прикрепления файла посредством сохранения пути
        private void attach_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Документы|*.pdf;*.doc;*.docx|Все файлы|*.*";
            if(open.ShowDialog()==true)
            {
                file = open.FileName;
            }
            
        }
        //06.04.2023 Калинин Арсений Олегович Описание: метод для ограничений корректности вводимых данных и завершени диалога
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dateReg.SelectedDate > DateTime.Now)
                {
                    MessageBox.Show("Некорректная дата");
                    return;
                }
                if (datedoc.SelectedDate > DateTime.Now)
                {
                    MessageBox.Show("Некорректная дата");
                    return;
                }
                if (period.SelectedDate < dateReg.SelectedDate)
                {
                    MessageBox.Show("Некорректная дата");
                    return;
                }
                if (exe.SelectedDate < dateReg.SelectedDate)
                {
                    MessageBox.Show("Некорректная дата");
                    return;
                }
                if (dateReg.SelectedDate == null)
                {
                    MessageBox.Show("Заполните необходимые поля");
                    return;
                }
                if (numdoc.Text == "")
                {
                    MessageBox.Show("Заполните необходимые поля");
                    return;
                }
                if(fio.Text=="")
                {
                    MessageBox.Show("Заполните необходимые поля");
                    return;
                }
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

        //06.04.2023 Калинин Арсений Олегович Описание: открытие прикрепленного файла
        private void open_Click(object sender, RoutedEventArgs e)
        {
            if(file!= null)
            {
                Process.Start(file);
            }
        }
    }
}
