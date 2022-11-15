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
using System.Threading;


namespace SnakeLocal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Rectangle[] rectangles = new Rectangle[] { };
        public static bool stop = false;
        public MainWindow()
        {
            InitializeComponent();
            StartMoveSnake1();
            StartMoveSnake2();
        }
        public async void StartMoveSnake1()
        {
            while (Snake1.Snake1Y != -1 && Snake1.Snake1Y != 31 && Snake1.Snake1X != -1 && Snake1.Snake1X != 31)
            {
                Contact();
                Eaten();
                //само передвижение на след клетку
                if (Snake1.turns[0] == true)
                {
                    try
                    {
                        Snake1.Snake1Y--;
                        Snake.SetValue(Grid.RowProperty, Snake1.Snake1Y);
                        await Task.Delay(Snake1.speed);
                    }
                    catch (Exception)
                    {
                        Application.Current.Shutdown();
                    }
                }
                if (Snake1.turns[3] == true)
                {
                    try
                    {
                        Snake1.Snake1X--;
                        Snake.SetValue(Grid.ColumnProperty, Snake1.Snake1X);
                        await Task.Delay(Snake1.speed);
                    }
                    catch (Exception)
                    {
                        Application.Current.Shutdown();
                    }
                }
                if (Snake1.turns[2] == true)
                {
                    try
                    {
                        Snake1.Snake1Y++;
                        Snake.SetValue(Grid.RowProperty, Snake1.Snake1Y);
                        await Task.Delay(Snake1.speed);
                    }
                    catch (Exception)
                    {
                        Application.Current.Shutdown();
                    }

                }
                if (Snake1.turns[1] == true)
                {
                    try
                    {
                        Snake1.Snake1X++;
                        Snake.SetValue(Grid.ColumnProperty, Snake1.Snake1X);
                        await Task.Delay(Snake1.speed);
                    }
                    catch (Exception)
                    {
                        Application.Current.Shutdown();
                    }
                }
                if (stop)
                {
                    return;
                }
            }
            Application.Current.Shutdown();
        }
        public async void StartMoveSnake2()
        {
            while (Snake2.Snake2Y != -1 && Snake2.Snake2Y != 31 && Snake2.Snake2X != -1 && Snake2.Snake2X != 31)
            {
                Contact();
                Eaten();
                //само передвижение на след клетку
                if (Snake2.turns[0] == true)
                {
                    try
                    {
                        Snake2.Snake2Y--;
                        SnakeEnemy.SetValue(Grid.RowProperty, Snake2.Snake2Y);
                        await Task.Delay(Snake2.speed);
                    }
                    catch (Exception)
                    {
                        Application.Current.Shutdown();
                    }
                }
                if (Snake2.turns[3] == true)
                {
                    try
                    {
                        Snake2.Snake2X--;
                        SnakeEnemy.SetValue(Grid.ColumnProperty, Snake2.Snake2X);
                        await Task.Delay(Snake2.speed);
                    }
                    catch (Exception)
                    {
                        Application.Current.Shutdown();
                    }
                }
                if (Snake2.turns[2] == true)
                {
                    try
                    {
                        Snake2.Snake2Y++;
                        SnakeEnemy.SetValue(Grid.RowProperty, Snake2.Snake2Y);
                        await Task.Delay(Snake2.speed);
                    }
                    catch (Exception)
                    {
                        Application.Current.Shutdown();
                    }

                }
                if (Snake2.turns[1] == true)
                {
                    try
                    {
                        Snake2.Snake2X++;
                        SnakeEnemy.SetValue(Grid.ColumnProperty, Snake2.Snake2X);
                        await Task.Delay(Snake2.speed);
                    }
                    catch (Exception)
                    {
                        Application.Current.Shutdown();
                    }
                }
                if (stop)
                {
                    return;
                }
            }
            Application.Current.Shutdown();
        }
        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < 4; i++)                
            {
                if (Snake1.turns[i] == true)                           //направление сейчас для snake
                {
                    Snake1.now_count = i;
                    Snake1.current_count_left = Snake1.now_count - 1;
                    Snake1.current_count_right = Snake1.now_count + 1;
                    if (Snake1.current_count_left == -1)
                    {
                        Snake1.current_count_left = 3;
                    }
                    if (Snake1.current_count_right == 4)
                    {
                        Snake1.current_count_right = 0;
                    }
                }
                if (Snake2.turns[i] == true)
                {
                    Snake2.now_count = i;
                    Snake2.current_count_left = Snake2.now_count - 1;
                    Snake2.current_count_right = Snake2.now_count + 1;
                    if (Snake2.current_count_left == -1)
                    {
                        Snake2.current_count_left = 3;
                    }
                    if (Snake2.current_count_right == 4)
                    {
                        Snake2.current_count_right = 0;
                    }
                }
            }
            if (e.Key == Key.A)
            {                                       //Влево A
                for (int i = 0; i < 4; i++)
                {
                    if (i == Snake1.current_count_left)
                    {
                        Snake1.turns[i] = true;
                    }
                    else
                    {
                        Snake1.turns[i] = false;
                    }
                }
            }
            if (e.Key == Key.D)
            {                                       //Вправо D
                for (int i = 0; i < 4; i++)
                {
                    if (i == Snake1.current_count_right)
                    {
                        Snake1.turns[i] = true;
                    }
                    else
                    {
                        Snake1.turns[i] = false;
                    }
                }
            }
            if (e.Key == Key.Right)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == Snake2.current_count_right)
                    {
                        Snake2.turns[i] = true;
                    }
                    else
                    {
                        Snake2.turns[i] = false;
                    }
                }
            }
            if (e.Key == Key.Left)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == Snake2.current_count_left)
                    {
                        Snake2.turns[i] = true;
                    }
                    else
                    {
                        Snake2.turns[i] = false;
                    }
                }
            }

        }
        public void Contact()
        {
            if (Snake1.Snake1X == Snake2.Snake2X && Snake1.Snake1Y == Snake2.Snake2Y && stop == false)
            {
                stop = true;
                MessageBox.Show("Догоняющий выиграл");
                Application.Current.Shutdown();
            }
        }

        public void Eaten()
        {
            if (Snake2.Snake2X == (int)Point.GetValue(Grid.ColumnProperty) && Snake2.Snake2Y == (int)Point.GetValue(Grid.RowProperty) && stop == false)
            {
                stop = true;
                Point.Visibility = Visibility.Collapsed;
                MessageBox.Show("Убегающий выиграл");
                Application.Current.Shutdown();
            }
        }
    }
}
