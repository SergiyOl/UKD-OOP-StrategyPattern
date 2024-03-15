using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_StrategyPattern
{
    interface IRoomType
    {
        int CalculateWaterUsage();
        int CalculateGasUsage();
    }

    class BedroomType : IRoomType
    {
        static Random rnd = new Random();
        public int CalculateWaterUsage()
        {
            return 0;
        }
        public int CalculateGasUsage()
        {
            return rnd.Next(2, 5);
        }
    }

    class KitchenType : IRoomType
    {
        static Random rnd = new Random();
        public int CalculateWaterUsage()
        {
            return rnd.Next(5, 15);
        }
        public int CalculateGasUsage()
        {
            return rnd.Next(10, 25);
        }
    }

    class BathroomType : IRoomType
    {
        static Random rnd = new Random();
        public int CalculateWaterUsage()
        {
            return rnd.Next(20, 35);
        }
        public int CalculateGasUsage()
        {
            return rnd.Next(2, 5);
        }
    }
}
