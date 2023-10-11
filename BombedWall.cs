using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class BombedWall : Wall
    {
        private bool isDestroyed = false;
        public void Explode()
        {
            if (!isDestroyed)
            {
                Console.WriteLine("Стена взорвана!");
                isDestroyed = true;
            }
        }
        public override void Enter()
        {
            if (isDestroyed)
            {
                Console.WriteLine("Стена разрушена!");
            }
            else
            {
                base.Enter();
            }
        }
    }
}
