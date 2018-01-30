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

namespace DungeonCrawler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle player = new Rectangle();

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
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.A))
            {
                x -= 7;

                Canvas.SetLeft(player, x);
            }

            if (Keyboard.IsKeyDown(Key.D))
            {
                x += 7;

                Canvas.SetLeft(player, x);
            }

            if (Keyboard.IsKeyDown(Key.W))
            {
                y -= 7;

                Canvas.SetTop(player, y);
            }

            if (Keyboard.IsKeyDown(Key.S))
            {
                y += 7;

                Canvas.SetTop(player, y);
            }
        }
    }
}
