using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_StrategyPattern
{
    interface IRoomType
    {
        
    }

    class BedroomType : IRoomType
    {
        public string type;

        public BedroomType()
        {
            type = "Bedroom";
        }
    }

    class KitchenType : IRoomType
    {
        static Random rnd = new Random();
        public string type;
        public int waterUsage;
        public int gasUsage;

        public KitchenType()
        {
            type = "Kitchen";
            waterUsage = rnd.Next(10, 50);
            gasUsage = rnd.Next(15, 60);
        }
    }

    class BathroomType : IRoomType
    {
        static Random rnd = new Random();
        public string type;
        public int waterUsage;

        public BathroomType()
        {
            type = "Bathroom";
            waterUsage = rnd.Next(15, 60);
        }
    }
}
