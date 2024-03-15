using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_StrategyPattern
{
    interface IRoomForm
    {
        int CalculateArea(int lenght, int wight);
    }

    class RectangleForm : IRoomForm
    {
        public int CalculateArea(int lenght, int wight)
        {
            int area = lenght * wight;
            return area;
        }
    }

    class TriangleForm : IRoomForm
    {
        public int CalculateArea(int lenght, int wight)
        {
            int area = lenght * (wight / 2);
            return area;
        }
    }

    class CircleForm : IRoomForm
    {
        public int CalculateArea(int lenght, int wight)
        {
            int area = Convert.ToInt32(Math.PI * Math.Pow(Decimal.ToDouble(lenght), 2));
            return area;
        }
    }
}
