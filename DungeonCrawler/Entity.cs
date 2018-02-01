using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace DungeonCrawler
{
    public class Entity
    {
        #region Properties
      // ---------------------------------------------------------------------------------------------------------
        public float X { get; set; }
        public float Y { get; set; }

        public int Speed { get; set; }

        public Rectangle CollisionMask = new Rectangle();
      // ---------------------------------------------------------------------------------------------------------
        #endregion

        #region Constructors
      // ---------------------------------------------------------------------------------------------------------
        public Entity(EntityStats stats)
        {
            SetStats(stats);
        }

        public Entity(EntityStats stats, Canvas canvas)
        {
            SetStats(stats);

            AddToCanvas(canvas);
        }


        private void SetStats(EntityStats stats)
        {
            this.X = stats.X;
            this.Y = stats.Y;

            this.Speed = stats.Speed;

            this.CollisionMask = stats.CollisionMask;
        }

        private void AddToCanvas(Canvas canvas)
        {
            canvas.Children.Add(this.CollisionMask);

            Canvas.SetLeft(this.CollisionMask, this.X);
            Canvas.SetTop(this.CollisionMask, this.Y);
        }
      // ---------------------------------------------------------------------------------------------------------
        #endregion

        #region Methods
      // ---------------------------------------------------------------------------------------------------------
        public void Move(float x, float y)
        {
          // update Entites Co-Ordinates with new positions
            this.X += x;
            this.Y += y;

          // apply Entites new position to the Canvas
            Canvas.SetLeft(this.CollisionMask, this.X);
            Canvas.SetTop(this.CollisionMask, this.Y);
        }


        public static bool IsCollision(Entity entity1, Entity entity2)
        {
            // Logic to calculate collision detectsion

            

            return false;
        }
      // ---------------------------------------------------------------------------------------------------------
        #endregion

    }
}
