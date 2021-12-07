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
using System.Windows.Shapes;

namespace class_work
{
    /// <summary>
    /// Логика взаимодействия для Task_02.xaml
    /// </summary>
    public partial class Task_02 : Window
    {
        public Task_02()
        {
            InitializeComponent();
        }

        private void set_Click(object sender, RoutedEventArgs e)
        {
            NameBlock.Text.Replace("Username", $"{textBox.Text}");
            GreetingBlock.Text.Replace("Username", $"{textBox.Text}");
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            NameBlock.Text.Replace($"{textBox.Text}", "Username");
            GreetingBlock.Text.Replace($"{textBox.Text}", "Username");
        }
    }
}
