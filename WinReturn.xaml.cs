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

namespace SnakeLocal
{
    /// <summary>
    /// Логика взаимодействия для WinReturn.xaml
    /// </summary>
    public partial class WinReturn : Window
    {
        public WinReturn()
        {
            InitializeComponent();
        }


        private void return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.stop = false;
            Hide();
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
