using System;
using System.Collections.Generic;
namespace MazeGame
{
    public class Wall : IMapSite
    {
        public void Enter()
        {
            Console.WriteLine("Вы не можете пройти через стену.");
        }
    }
}