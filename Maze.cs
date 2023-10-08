using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGame;
public class Maze
{
    private List<Room> rooms = new List<Room>();
    public void AddRoom(Room room)
    {
        rooms.Add(room);
    }
}