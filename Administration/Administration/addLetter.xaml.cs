using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows;

namespace Administration
{
    /// <summary>
    /// Окно предназначено для добавления писем
    /// </summary>
    public partial class addLetter : Window
    {
        public string file = null;
        public addLetter()
        {
            InitializeComponent();
        }
        //06.04.2023 Калинин Арсений Олегович Описание: метод предназначен для прикрепления файла посредством сохранения пути
        private void attach_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Документы|*.pdf;*.doc;*.docx|Все файлы|*.*";
                if (open.ShowDialog() == true)
                {
                    file = open.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка открытия файла");
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
                datamine.reg = (DateTime)dateReg.SelectedDate;
                datamine.exe = exe.SelectedDate;
                datamine.doc = datedoc.SelectedDate;
                datamine.per = period.SelectedDate;
                this.DialogResult = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //06.04.2023 Калинин Арсений Олегович Описание: открытие прикрепленного файла
        private void open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (file != null)
                {
                    Process.Start(file);
                }
                else
                {
                    MessageBox.Show("Файл отсутствует");
                }
            }
            catch { MessageBox.Show("Файл отсутствует"); }
        }
    }
}
