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

namespace DungeonCrawler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timeer;

        Rectangle player = new Rectangle();

        Rectangle obsticle = new Rectangle();

        public static int x = 0;
        public static int y = 0;

        public MainWindow()
        {
            InitializeComponent();

            player.Height = 20;
            player.Width = 20;

            player.Fill = Brushes.ForestGreen;

            canvas.Children.Add(player);

            Canvas.SetLeft(player, x);
            Canvas.SetTop(player, y);


            obsticle.Height = 20;
            obsticle.Width = 20;

            obsticle.Fill = Brushes.BlueViolet;

            canvas.Children.Add(obsticle);

            Canvas.SetLeft(obsticle, canvas.Width / 2);
            Canvas.SetTop(obsticle, canvas.Height / 2);



            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.A))
            {
                if(IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10))
                {
                   // x += 1;
                    player.Fill = Brushes.OrangeRed;

                }

                else
                {
                    player.Fill = Brushes.ForestGreen;
                }

                x -= 7;

                Canvas.SetLeft(player, x);
            }

            if (Keyboard.IsKeyDown(Key.D))
            {
                if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10))
                {
                    //x -= 1;
                    player.Fill = Brushes.OrangeRed;

                }

                else
                {
                    player.Fill = Brushes.ForestGreen;
                }

                x += 7;

                Canvas.SetLeft(player, x);
            }

            if (Keyboard.IsKeyDown(Key.W))
            {
                if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10))
                {
                    //y += 1;
                    player.Fill = Brushes.OrangeRed;

                }

                else
                {
                    player.Fill = Brushes.ForestGreen;
                }


                y -= 7;

                Canvas.SetTop(player, y);
            }

            if (Keyboard.IsKeyDown(Key.S))
            {
                if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10))
                {
                    //y -= 1;
                    player.Fill = Brushes.OrangeRed;

                }

                else
                {
                    player.Fill = Brushes.ForestGreen;
                }

                y += 7;

                Canvas.SetTop(player, y);
            }
        }

        public static bool IsCollision(int x1, int y1, int x2, int y2, int radius)
        {
            double distance = Math.Sqrt( Math.Pow( (x2 - x1), (x2 - x1) ) + Math.Pow( (y2 - y1), (y2 - y1 )) );

            if( !(distance > radius) ) { return true; }

            return false;
        }
    }
}
