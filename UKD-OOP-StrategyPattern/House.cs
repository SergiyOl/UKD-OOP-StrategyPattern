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

        public int CalculateHouseArea()
        {
            int area = 0;
            foreach(var item in allRooms)
            {
                area += item.CalculateArea(); 
            }
            return area;
        }

        public int CalculateAllBedroomArea()
        {
            int area = 0;
            foreach (var item in allRooms)
            {
                if(item.roomType is BedroomType)
                {
                    area += item.CalculateArea();
                }
            }
            return area;
        }

        public void ShowAllRooms()
        {
            foreach (var item in allRooms)
            {
                Console.WriteLine($"Тип кімнати: {item.roomType.GetType()}");
                Console.WriteLine($"Форма кімнати: {item.roomForm.GetType()}");
                Console.WriteLine($"Площа кімтани ({item.lenght}, {item.wight}): {item.CalculateArea()}");
                Console.WriteLine($"Використання води: {item.CalculateWaterUsage()}");
                Console.WriteLine($"Використання газу: {item.CalculateGasUsage()}");
            }
        }

        public void ShowRoomsByForm<T>()
        {
            foreach (var item in allRooms)
            {
                if (item.roomForm is T)
                {
                    Console.WriteLine($"Тип кімнати: {item.roomType.GetType()}");
                    Console.WriteLine($"Форма кімнати: {item.roomForm.GetType()}");
                    Console.WriteLine($"Площа кімтани ({item.lenght}, {item.wight}): {item.CalculateArea()}");
                    Console.WriteLine($"Використання води: {item.CalculateWaterUsage()}");
                    Console.WriteLine($"Використання газу: {item.CalculateGasUsage()}");
                }
            }
        }

        public void ShowRoomsByType<T>()
        {
            foreach (var item in allRooms)
            {
                if (item.roomType is T)
                {
                    Console.WriteLine($"Тип кімнати: {item.roomType.GetType()}");
                    Console.WriteLine($"Форма кімнати: {item.roomForm.GetType()}");
                    Console.WriteLine($"Площа кімтани ({item.lenght}, {item.wight}): {item.CalculateArea()}");
                    Console.WriteLine($"Використання води: {item.CalculateWaterUsage()}");
                    Console.WriteLine($"Використання газу: {item.CalculateGasUsage()}");
                }
            }
        }

        public int CalculateAllWaterUsage()
        {
            int waterUsage = 0;
            foreach (var item in allRooms)
            {
                waterUsage += item.CalculateWaterUsage();
            }
            return waterUsage;
        }

        public int CalculateAllGasUsage()
        {
            int gasUsage = 0;
            foreach (var item in allRooms)
            {
                gasUsage += item.CalculateGasUsage();
            }
            return gasUsage;
        }
    }
}
