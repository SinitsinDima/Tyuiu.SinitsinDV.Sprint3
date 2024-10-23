﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SinitsinDV.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1.0;
            while (startValue <= stopValue) 
            {
                p *= Math.Cos(0.1) + Math.Pow(startValue, -2);
                startValue++;
            }
            return Math.Round(p, 3);
        }
    }
}
