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
        private void ButtonSundP_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(textBoxA.Text, out int a))
            {
                Class.SundP(a, out int s, out int p);
                textBoxResult.Text = $"S= {s}, P= {p}";
            }
        }

        private void ButtonSwitchNumber_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int number))
            {
                //int number2 = number % 10;
                textBoxResult2.Text = Class.SwitchNumber(number).ToString();
                //textBoxResult2.Text = Convert.ToString(number%10) + Convert.ToString(number / 10);
            }
        }
    }
}