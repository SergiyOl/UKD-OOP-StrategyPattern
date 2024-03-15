using System;
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
            myHouse.AddRoom(new RectangleForm(), new BathroomType(), 20, 30);
            Console.WriteLine(myHouse.allRooms.First());
            Console.WriteLine(myHouse.allRooms.First().CalculateArea());
            Console.WriteLine(myHouse.allRooms.First().CalculateWaterUsage());
            Console.WriteLine(myHouse.allRooms.First().CalculateGasUsage());
            myHouse.AddRoom(new CircleForm(), new BedroomType(), 20, 20);
            myHouse.AddRoom(new TriangleForm(), new KitchenType(), 20, 30);

            Console.WriteLine();
            Console.WriteLine(myHouse.CalculateHouseArea());
            Console.WriteLine();

            Console.WriteLine(myHouse.CalculateAllBedroomArea());
            Console.WriteLine();

            myHouse.ShowAllRooms();
            Console.WriteLine();

            myHouse.ShowRoomsByType<BathroomType>();
            Console.WriteLine();

            myHouse.ShowRoomsByForm<CircleForm>();
            Console.WriteLine();

            Console.WriteLine(myHouse.CalculateAllWaterUsage());
            Console.WriteLine();

            Console.WriteLine(myHouse.CalculateAllGasUsage());
            Console.WriteLine();
        }
    }
}
