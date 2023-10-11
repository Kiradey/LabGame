using System;
using System.Collections.Generic;
namespace MazeGame
{
    public class RoomWithBomb : Room
    {
        private static Random rand = new Random();
        public RoomWithBomb(int roomNumber) : base(roomNumber) { }

        public void Explode()
        {
            if (rand.Next(2) == 1)
            {
                Console.WriteLine("Комната взорвана!");
                SideInit.OfType<BombedWall>().ToList().ForEach(x => x.Explode());
            }
            base.Enter();
        }
    }

}