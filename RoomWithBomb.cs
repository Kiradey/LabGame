using System;
using System.Collections.Generic;
namespace MazeGame
{
    public class RoomWithBomb : Room
    {
        public RoomWithBomb(int roomNumber, bool hasBomb) : base(roomNumber, hasBomb) { }

        public void Explode()
        {
            Console.WriteLine($"Комната взорвана!");
        }
    }

}