using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_StrategyPattern
{
    class House
    {
        public List<Room> allRooms = new();

        public void AddRoom(IRoomForm roomForm, IRoomType roomType, int lenght, int wight)
        {
            allRooms.Add(new Room(roomForm, roomType, lenght, wight));
        }
    }
}
