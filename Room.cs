using System;
using System.Collections.Generic;
namespace MazeGame
{
    public class Room : IMapSite
    {
        public int RoomNumber { get; private set; }
        protected IMapSite[] SideInit { get; private set; }
        public Room(int RoomNumber)
        {
            if (RoomNumber <= 0)
            {
                throw new ArgumentNullException("Неверный номер комнаты.");
            }
            this.RoomNumber = RoomNumber;
            SideInit = new IMapSite[4];
        }
        public void Enter()
        {
            Console.WriteLine("Вы вошли в комнату " + RoomNumber);
            
        }
        public IMapSite GetSide(Direction direction)
        {
            return SideInit[(int)direction];
        }
        public void SetSide(Direction direction, IMapSite site)
        {
            SideInit[(int)direction] = site;
        }
    }
}