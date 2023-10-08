using System;
using System.Collections.Generic;
namespace MazeGame
{
    public class Room : IMapSite
    {
        public int RoomNumber { get; private set; }
        public bool HasBomb { get; private set; }
        public Room(int roomNo, bool hasBomb = false)
        {
            RoomNumber = roomNo;
            HasBomb = hasBomb;
        }
        public void Enter()
        {
            Console.WriteLine("Вы вошли в комнату " + RoomNumber);
            if (HasBomb)
            {
                Console.WriteLine("В комнате есть бомба!");
            }
        }
    }
}