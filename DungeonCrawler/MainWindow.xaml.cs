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
        private DispatcherTimer timeer = new DispatcherTimer();
        private DispatcherTimer Secondstimer = new DispatcherTimer();

        Rectangle player = new Rectangle();

        Rectangle obsticle = new Rectangle();

        String Distance = "";

        public static int x = 0;
        public static int y = 0;
        public static int speed = 7;


        public static int Ticks = 0;
        public static int Seconds = 0;

        public MainWindow()
        {
            InitializeComponent();


        }

        private void OnWindowLoad(object sender, EventArgs e)
        {
            player.Height = 60;
            player.Width = 60;

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


            DistanceLabel.Content = Distance;

            SetTimerInterrupts();

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
        //    if (Keyboard.IsKeyDown(Key.A))
        //    {
        //        if(IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10, out Distance))
        //        {
        //           // x += 1;
        //            player.Fill = Brushes.OrangeRed;

        //        }

                


        //        else
        //        {
        //            player.Fill = Brushes.ForestGreen;
        //        }

        //        x -= 7;

        //        Canvas.SetLeft(player, x);

        //        DistanceLabel.Content = "";
        //        DistanceLabel.Content = Distance;
        //    }

        //    if (Keyboard.IsKeyDown(Key.D))
        //    {
        //        if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10, out Distance))
        //        {
        //            //x -= 1;
        //            player.Fill = Brushes.OrangeRed;

        //        }

        //        else
        //        {
        //            player.Fill = Brushes.ForestGreen;
        //        }

        //        x += 7;

        //        Canvas.SetLeft(player, x);

        //        DistanceLabel.Content = "";
        //        DistanceLabel.Content = Distance;
        //    }

        //    if (Keyboard.IsKeyDown(Key.W))
        //    {
        //        if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10, out Distance))
        //        {
        //            //y += 1;
        //            player.Fill = Brushes.OrangeRed;

        //        }

        //        else
        //        {
        //            player.Fill = Brushes.ForestGreen;
        //        }


        //        y -= 7;

        //        Canvas.SetTop(player, y);

        //        DistanceLabel.Content = "";
        //        DistanceLabel.Content = Distance;
        //    }

        //    if (Keyboard.IsKeyDown(Key.S))
        //    {
        //        if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10, out Distance))
        //        {
        //            //y -= 1;
        //            player.Fill = Brushes.OrangeRed;

        //        }

        //        else
        //        {
        //            player.Fill = Brushes.ForestGreen;
        //        }

        //        y += 7;

        //        Canvas.SetTop(player, y);

        //        DistanceLabel.Content = "";
        //        DistanceLabel.Content = Distance;
        //    }
        }

        public static bool IsCollision(int x1, int y1, int x2, int y2, int radius, out string Distance)
        {
           double distance = Math.Sqrt( ( (x2 - x1)^2 ) + ( (y2 - y1) ^ 2) );

            Distance = distance.ToString();

            if( !(distance > 4) ) { return true; }


            //if (RectA.Left < RectB.Right && RectA.Right > RectB.Left &&
     //RectA.Top > RectB.Bottom && RectA.Bottom < RectB.Top)

                return false;
        }


        private void SetTimerInterrupts()
        {
            timeer.IsEnabled = true;
            timeer.Interval = TimeSpan.FromMilliseconds(16.67);// an approximation for 60fps
            timeer.Tick += OnTimerTick;

            Secondstimer.IsEnabled = true;
            Secondstimer.Interval = TimeSpan.FromSeconds(1);
            Secondstimer.Tick += OnSecondsTimerTick;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            Ticks++;

            TickLabel.Content = "";

            TickLabel.Content = Ticks.ToString();

            if(KeyDownEvent != null)
            {
                KeyLabel.Content = Keyboard.KeyDownEvent.ToString();
            }

            else
            {
                KeyLabel.Content = "";
            }

            MovePlayer();
            
        }

        private void MovePlayer()
        {
            if(Mouse.LeftButton == MouseButtonState.Pressed)
            {
                Rectangle pointer = new Rectangle();

                pointer.Height = 4;
                pointer.Width = 4;
                pointer.Fill = Brushes.Pink;

                canvas.Children.Add(pointer);

                Canvas.SetLeft(pointer, Mouse.GetPosition(canvas).X);
                Canvas.SetTop(pointer, Mouse.GetPosition(canvas).Y);
            }

            if (Keyboard.IsKeyDown(Key.A))
            {
                //if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10, out Distance))
                //{
                //    // x += 1;
                //    player.Fill = Brushes.OrangeRed;

                //}

                //else
                //{
                //    player.Fill = Brushes.ForestGreen;
                //}

                x -= speed;

                Canvas.SetLeft(player, x);

                DistanceLabel.Content = "";
                DistanceLabel.Content = Distance;
            }

            if (Keyboard.IsKeyDown(Key.D))
            {
                //if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10, out Distance))
                //{
                //    //x -= 1;
                //    player.Fill = Brushes.OrangeRed;

                //}

                //else
                //{
                //    player.Fill = Brushes.ForestGreen;
                //}

                x += speed;

                Canvas.SetLeft(player, x);

                DistanceLabel.Content = "";
                DistanceLabel.Content = Distance;
            }

            if (Keyboard.IsKeyDown(Key.W))
            {
                //if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10, out Distance))
                //{
                //    //y += 1;
                //    player.Fill = Brushes.OrangeRed;

                //}

                //else
                //{
                //    player.Fill = Brushes.ForestGreen;
                //}


                y -= speed;

                Canvas.SetTop(player, y);

                DistanceLabel.Content = "";
                DistanceLabel.Content = Distance;
            }

            if (Keyboard.IsKeyDown(Key.S))
            {
                //if (IsCollision(x, y, (int)canvas.Width / 2, (int)canvas.Height / 2, 10, out Distance))
                //{
                //    //y -= 1;
                //    player.Fill = Brushes.OrangeRed;

                //}

                //else
                //{
                //    player.Fill = Brushes.ForestGreen;
                //}

                y += speed;

                Canvas.SetTop(player, y);

                DistanceLabel.Content = "";
                DistanceLabel.Content = Distance;
            }
        }

        private void OnSecondsTimerTick(object sender, EventArgs e)
        {
            Seconds++;

            SecondsLabel.Content = "";

            SecondsLabel.Content = Seconds.ToString();

            if(Seconds == 3)
            {
                string filepath = Environment.CurrentDirectory;
                filepath = filepath.Substring(0, filepath.Length - 9);
                filepath += "kermie.JPG";

                Uri uri = new Uri(filepath, UriKind.RelativeOrAbsolute);
                BitmapImage bitmap = new BitmapImage(uri);

                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = bitmap;

                //obsticle.Fill = imageBrush;
                player.Fill = imageBrush;

                //BitmapSource bitmapSource = new byte[] { };
            }

        }

        public static void GameLoop()
        {
            bool isRun = true;

            while(isRun)
            {
                // GetPlayerInput();

                // GameLogic();
                    // MoveObjects();
                    // DetectCollisions();


                // UpdateCanvas();
            }
        }

        // this method should create a bitmapImage from a byteArray
        // will be useful for procedurally generating our own images or animations
        //public BitmapImage ToImage(byte[] array)
        //{
        //    using (var ms = new System.IO.MemoryStream(array))
        //    {
        //        var image = new BitmapImage();
        //        image.BeginInit();
        //        image.CacheOption = BitmapCacheOption.OnLoad; // here
        //        image.StreamSource = ms;
        //        image.EndInit();
        //        return image;
        //    }
        //}

    }
}
