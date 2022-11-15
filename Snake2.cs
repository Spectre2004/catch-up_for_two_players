using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLocal
{
    internal class Snake2:MainWindow
    {
        public static int Snake2X = 30;
        public static int Snake2Y = 30;
        public static bool y_minus = false;
        public static bool x_minus = true;
        public static bool y_plus = false;
        public static bool x_plus = false;
        public static int now_count;
        public static int current_count_left;
        public static int current_count_right;
        public static int speed = 150;
        public static bool[] turns = new bool[] { y_minus, x_plus, y_plus, x_minus };
    }
}
