using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace DungeonCrawler
{
    public struct EntityStats
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Speed { get; set; }

        public Rectangle CollisionMask { get; set; }
    }
}
