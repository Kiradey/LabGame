using System;
using System.Collections.Generic;
namespace MazeGame
{
    public class Wall : IMapSite
    {
        public virtual void Enter()
        {
            Console.WriteLine("Вы не можете пройти через стену.");
        }
    }
}