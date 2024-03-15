using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_StrategyPattern
{
    class Room
    {
        public IRoomForm roomForm;
        public IRoomType roomType;
        public int lenght;
        public int wight;

        public Room(IRoomForm _roomForm, IRoomType _roomType, int _lenght, int _wight)
        {
            roomForm = _roomForm;
            roomType = _roomType;
            lenght = _lenght;
            wight = _wight;
        }

        public int CalculateArea()
        {
            return roomForm.CalculateArea(lenght, wight);
        }
    }
}
