using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGame;
namespace MazeGameSolution
{
    class Program
    {
        static void Main()
        {
            MazeFactory factory = new BombedMazeFactory();
            Maze maze = factory.MakeMaze();
            Room currentRoom = factory.MakeRoom(1);
            currentRoom.Enter();
            IMapSite wall = factory.MakeWall();
            wall.Enter();
            Door door = factory.MakeDoor(factory.MakeRoom(1), factory.MakeRoom(2));
            door.OpenDoor();
            IMapSite nextRoom = door.OtherSideFrom(currentRoom);
            nextRoom.Enter();
            RoomWithBomb roomWithBomb = (RoomWithBomb)factory.MakeRoom(3);
            roomWithBomb.Explode();
            BombedWall bombedWall = (BombedWall)factory.MakeWall();
            bombedWall.Explode();
            Console.ReadLine();
        }
    }
}
