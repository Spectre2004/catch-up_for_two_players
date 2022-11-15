using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace SnakeLocal
{
    internal class Snake1:MainWindow
    {
        public static int Snake1X = 0;
        public static int Snake1Y = 0;
        public static bool y_minus = false;
        public static bool x_minus = false;
        public static bool y_plus = false;
        public static bool x_plus = true;
        public static int now_count;
        public static int current_count_left;
        public static int current_count_right;
        public static int speed = 130;
        public static bool[] turns = new bool[] { y_minus, x_plus, y_plus, x_minus };
    }
}
