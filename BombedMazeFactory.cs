using System;
using System.Collections.Generic;
using MazeGameSolution;
namespace MazeGame
{
    public class BombedMazeFactory : MazeFactory
    {
        private Random random = new Random();
        public override Maze MakeMaze()
        {
            return new Maze();
        }
        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int roomNumber)
        {
            bool hasBomb = random.Next(0, 2) == 0;
            return new RoomWithBomb(roomNumber, hasBomb);
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2, true);
        }
    }
}