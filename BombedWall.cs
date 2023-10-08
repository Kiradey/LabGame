using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class BombedWall : Wall
    {
        public void Explode()
        {
            Console.WriteLine("Стена взорвана!");
        }
    }
}
