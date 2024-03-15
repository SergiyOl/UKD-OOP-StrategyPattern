﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            House myHouse = new();
            myHouse.AddRoom(new RectangleForm(), new KitchenType(), 40, 50);
            Console.WriteLine(myHouse.allRooms.First());
            Console.WriteLine(myHouse.allRooms.First().CalculateArea());
            //Console.WriteLine(myHouse.allRooms.First().roomType.gasUsage);
        }
    }
}