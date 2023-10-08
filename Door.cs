using System;
using System.Collections.Generic;
namespace MazeGame
{
    public class Door : IMapSite
    {
        private IMapSite room1;
        private IMapSite room2;
        private bool isOpen;
        public Door(IMapSite room1, IMapSite room2, bool isOpen)
        {
            this.room1 = room1;
            this.room2 = room2;
            this.isOpen = true;
        }
        public IMapSite OtherSideFrom(IMapSite site)
        {
            if (site == room1)
            {
                return room2;
            }
            else
            {
                return room1;
            }
        }
        public void OpenDoor()
        {
            isOpen = true;
        }
        public void CloseDoor()
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