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
        #region Global Objects
      // ---------------------------------------------------------------------------------------------------------
        public static UserInput UserInput = new UserInput();
        public static Entity Player { get; set; }
        public static List<Entity> Entities { get; set; }

        public static Canvas Canvas;
      // ---------------------------------------------------------------------------------------------------------
        #endregion


        public static void Init(ref Canvas canvas, EntityStats playerStats, List<EntityStats> entityStats)
        {
            Canvas = canvas;

            Player = new Entity(playerStats);

            if (entityStats != null)
            {
                foreach (EntityStats stats in entityStats)
                {
                    Entities.Add( new Entity(stats) );
                }
            }
        }

        #region Game Loop
      // ---------------------------------------------------------------------------------------------------------
        public static void Loop()
        {
            GetUserInput();

            // DoGameLogic();

            // UpdateCanvas();
        }

        private static void GetUserInput()
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                MouseLeftClick();
            }

            if (Keyboard.IsKeyDown(Key.A))
            {
                UserInput.PlayerX = Player.X - Player.Speed;

                // calculate if collision will occur

                //player.Move(x, player.Y);
            }

            if (Keyboard.IsKeyDown(Key.D))
            {
                //int x = 0 + player.Speed;

                UserInput.PlayerX = Player.X + Player.Speed;

               // player.Move(x, player.Y);
            }

            if (Keyboard.IsKeyDown(Key.W))
            {
                //int y = 0 - player.Speed;

                UserInput.PlayerY = Player.Y - Player.Speed;

                //player.Move(player.X, y);
            }

            if (Keyboard.IsKeyDown(Key.S))
            {
                //int y = 0 + player.Speed;

                UserInput.PlayerY = Player.Y + Player.Speed;

                //player.Move(player.X, y);
            }


            // @Debug code for testing the movement 'system'
            if (Keyboard.IsKeyDown(Key.F) )
            {
                Player.X = 5;
                Player.Y = 5;

                Player.Move(Player.X, Player.Y);
            }
        }

        private static void DoGameLogic()
        {
            // Calculate if collision
            // if no collision:
            //      - update Player position to new Co-Ordinates
            // if collision:
            //      - don't change Player position
            //      - maybe play son

        }

        private static void UpdateCanvas()
        {
            Player.Move(UserInput.PlayerX, UserInput.PlayerY);
        }
      // ---------------------------------------------------------------------------------------------------------
        #endregion


        #region UserInput
      // ---------------------------------------------------------------------------------------------------------
        private static void PlayerMovement() // placeholder name
        {

        }

        private static void MouseMovemnet()
        {

        }

      // ---------------------------------------------------------------------------------------------------------
        #endregion


        #region Game Logic
        // ---------------------------------------------------------------------------------------------------------
        private static void MoveEntity()
        {

        }

        private static void MouseLeftClick()
        {
            Rectangle pointer = new Rectangle
            {
                Height = 4,
                Width = 4,
                Fill = Brushes.Pink
            };

            Canvas.Children.Add(pointer);

            Canvas.SetLeft(pointer, Mouse.GetPosition(Canvas).X);
            Canvas.SetTop(pointer, Mouse.GetPosition(Canvas).Y);
        }



        private static void CollisionDetection()
        {

        }
      // ---------------------------------------------------------------------------------------------------------
        #endregion
    }
}
