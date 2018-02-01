using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public struct UserInput
    {
        public float PlayerX { get; set; }
        public float PlayerY { get; set; }

        public float MouseX { get; set; }
        public float MouseY { get; set; }

        public void Reset()
        {
            PlayerX = 0;
            PlayerY = 0;
        }

    }
}
