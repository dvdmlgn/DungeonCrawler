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
        public int X { get; set; }
        public int Y { get; set; }

        public int Speed { get; set; }

        public Rectangle CollisionMask;

        public Entity()
        {
            CollisionMask = new Rectangle();

            
        }

        public Entity(Canvas canvas)
        {

        }

    }
}
