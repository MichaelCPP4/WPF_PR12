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
using System.Windows.Threading;
using Lib;

namespace WPF_PR9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DispatcherTimer timer;

        //Событие кнопки "Найти S и P"
        private void ButtonSundP_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(textBoxA.Text, out int a))
            {
                Class.SundP(a, out int s, out int p);
                textBoxResult.Text = $"S= {s}, P= {p}";
            }
            else
            {
                MessageBox.Show("Вы не ввели данные или сделали это неправильно.", "Ошибка!");
            }
        }

        //Событие кнопки "Поменять местами"
        private void ButtonSwitchNumber_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int number) && (number > 99 && number <= 999))
            {
                textBoxResult2.Text = Class.SwitchNumber(number);
            }
            else
            {
                MessageBox.Show("Вы не ввели данные или сделали это неправильно.", "Ошибка!");
            }
        }

        //Событие кнопки "О программе"
        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Реализовать расчет задачи:\r\n• Дана сторона квадрата a. Найти его площадь и периметр.\r\n• Дано трехзначное число. Вывести вначале его последнюю цифру (единицы), а затем — его среднюю цифру (десятки).\r\nВыполнил Иванов Михаил ИСП-31");
        }

        //Событие запуска окна
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0,0,0,1,0);
            timer.IsEnabled= true;

            //number.Text = "Задание №1";
        }

        //Событие таймера
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm");
            data.Text = d.ToString("dd.MM.yyyy");
        }

        //Событие выполняется каждый раз, когда меняется активная вкладка
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                number.Text = "Задание №1";
                textBoxNumber.Clear();
                textBoxResult2.Clear();
                menuItemSwitchNumber.IsEnabled= false;
                menuItemSundP.IsEnabled = true;
            }
            else
            {
                number.Text = "Задание №2";
                textBoxA.Clear();
                textBoxResult.Clear();
                menuItemSwitchNumber.IsEnabled = true;
                menuItemSundP.IsEnabled= false;
            }

        }

        //Очистка результата при вводе новых или изменения старых данных
        private void TextBoxNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBoxResult2.Clear();
        }

        //Очистка результата при вводе новых или изменения старых данных
        private void TextBoxA_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBoxResult.Clear();
        }

        //Очищает поля
        private void MenuItemClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxA.Clear();
            textBoxNumber.Clear();
        }

        //Выход из программы
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}