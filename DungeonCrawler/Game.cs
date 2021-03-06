﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

       // private static Stopwatch time = new Stopwatch(); // used for calculating delta time
        public static float DeltaTime = 0.5f;

        public static int AnimationFrame = 0;
        public static string AnimationDirection = "";
        public static bool IsAnimation = false;


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
           // time.Start();

            GetUserInput();

            // DoGameLogic();

          // /time.Stop();
          // DeltaTime = time.ElapsedMilliseconds ;
            //time.Reset();

            

            UpdateCanvas();
        }

        private static void GetUserInput()
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                MouseLeftClick();
            }

            if (Keyboard.IsKeyDown(Key.A))
            {
                UserInput.PlayerX = 0 - (Player.Speed * DeltaTime);

                // calculate if collision will occur

                //player.Move(x, player.Y);

                AnimationFrame = 0;
                AnimationDirection = "Left";

                MainWindow.AnimationTime.IsEnabled = true;

            }
            // else
            //{
            //    MainWindow.AnimationTime.IsEnabled = false;

            //    AnimationFrame = 0;
            //}


            if (Keyboard.IsKeyDown(Key.D))
            {
                //int x = 0 + player.Speed;

                UserInput.PlayerX = 0 + (Player.Speed * DeltaTime);

                // player.Move(x, player.Y);
                AnimationFrame = 0;
                AnimationDirection = "Right";

                MainWindow.AnimationTime.IsEnabled = true;
            }


            if (Keyboard.IsKeyDown(Key.W))
            {
                //int y = 0 - player.Speed;

                UserInput.PlayerY = 0 - (Player.Speed * DeltaTime);

                //player.Move(player.X, y); 

                AnimationFrame = 0;
                AnimationDirection = "Up";

                MainWindow.AnimationTime.IsEnabled = true;
            }


            if (Keyboard.IsKeyDown(Key.S))
            {
                //int y = 0 + player.Speed;

                UserInput.PlayerY = 0 + (Player.Speed * DeltaTime);

                //player.Move(player.X, y);

                AnimationFrame = 0;
                AnimationDirection = "Down";

                MainWindow.AnimationTime.IsEnabled = true;
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

            UserInput.Reset();
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
