using System;
using System.Collections.Generic;
namespace MazeGame
{
    public class Door : IMapSite
    {
        private Room room1;
        private Room room2;
        private bool isOpen;
        public Door(Room room1,Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
            this.isOpen = true;
        }
        public Room OtherSideFrom(Room site)
        {
            if (site.RoomNumber == room1.RoomNumber)
            {
                return room2;
            }
            else if (site.RoomNumber==room2.RoomNumber)
            {
                return room1;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        private void OpenDoor()
        {
            isOpen = true;
        }
        private void CloseDoor()
        {
            isOpen = false;
        }
        public void Enter()
        {
            if (isOpen)
            {
                Console.WriteLine("Вы прошли через дверь.");
            }
            else
            {
                Console.WriteLine("Дверь закрыта, вы не можете пройти.");
            }
        }
    }
}