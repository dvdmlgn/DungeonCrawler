using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DungeonCrawler
{
    public static class Game
    { 
        public static void Loop(Entity player, Canvas canvas)
        {
            GetUserInput(player, canvas);

            // DoGameLogic();

            // UpdateCanvas();
        }

        private static void GetUserInput(Entity player, Canvas canvas)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                Rectangle pointer = new Rectangle
                {
                    Height = 4,
                    Width = 4,
                    Fill = Brushes.Pink
                };

                canvas.Children.Add(pointer);

                Canvas.SetLeft(pointer, Mouse.GetPosition(canvas).X);
                Canvas.SetTop(pointer, Mouse.GetPosition(canvas).Y);
            }

            if (Keyboard.IsKeyDown(Key.A))
            {
                int x = 0 - player.Speed;

                // calculate if collision will occur

                player.Move(x, player.Y);
            }

            if (Keyboard.IsKeyDown(Key.D))
            {
                int x = 0 + player.Speed;

                player.Move(x, player.Y);
            }

            if (Keyboard.IsKeyDown(Key.W))
            {
                int y = 0 - player.Speed;

                player.Move(player.X, y);
            }

            if (Keyboard.IsKeyDown(Key.S))
            {
                int y = 0 + player.Speed;

                player.Move(player.X, y);
            }


            if (Keyboard.IsKeyDown(Key.F) )
            {
                player.X = 5;
                player.Y = 5;

                player.Move(player.X, player.Y);
            }
        }

        private static void MoveEntity()
        {

        }


        private static void DoGameLogic()
        {

        }

        private static void UpdateCanvas()
        {

        }
    }
}
