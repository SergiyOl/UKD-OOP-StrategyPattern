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

        public Room(IRoomForm _roomForm, IRoomType _roomType)
        {
            roomForm = _roomForm;
            roomType = _roomType;
        }
        public int GetLenght()
        {
            return roomForm.GetLenght();
        }

        public int GetWight()
        {
            return roomForm.GetWight();
        }

        public int CalculateArea()
        {
            return roomForm.CalculateArea();
        }

        public int CalculateWaterUsage()
        {
            return roomType.CalculateWaterUsage();
        }

        public int CalculateGasUsage()
        {
            return roomType.CalculateGasUsage();
        }
    }
}
