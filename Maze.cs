using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGame;
public class Maze
{
    private List<Room> roomList = new List<Room>();
    public void AddRoom(Room room)
    {
        roomList.Add(room);
    }
    public Room? NumberCheck(int Number)
    {
        return roomList.SingleOrDefault(room => room.RoomNumber == Number);
    }
}