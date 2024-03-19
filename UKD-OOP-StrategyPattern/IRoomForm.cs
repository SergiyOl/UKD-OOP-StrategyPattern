﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_StrategyPattern
{
    interface IRoomForm
    {
        int CalculateArea();
        int GetLenght();
        int GetWight();
    }

    public class RectangleForm : IRoomForm
    {
        public int lenght;
        public int wight;

        public RectangleForm(int _lenght, int _wight)
        {
            lenght = _lenght;
            wight = _wight;
        }

        public int CalculateArea()
        {
            int area = lenght * wight;
            return area;
        }

        public int GetLenght()
        {
            return lenght;
        }

        public int GetWight()
        {
            return wight;
        }
    }

    public class TriangleForm : IRoomForm
    {
        public int lenght;
        public int wight;

        public TriangleForm(int _lenght, int _wight)
        {
            lenght = _lenght;
            wight = _wight;
        }

        public int CalculateArea()
        {
            int area = lenght * (wight / 2);
            return area;
        }

        public int GetLenght()
        {
            return lenght;
        }

        public int GetWight()
        {
            return wight;
        }
    }

    public class CircleForm : IRoomForm
    {
        public int lenght;

        public CircleForm(int _lenght)
        {
            lenght = _lenght;
        }

        public int CalculateArea()
        {
            int area = Convert.ToInt32(Math.PI * Math.Pow(Decimal.ToDouble(lenght / 2), 2));
            return area;
        }

        public int GetLenght()
        {
            return lenght;
        }

        public int GetWight()
        {
            return 0;
        }
    }
}
