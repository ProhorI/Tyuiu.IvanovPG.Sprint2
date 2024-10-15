﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvanovPG.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            bool z = (y <= Math.Pow(x, 2)) && (y >= 2 - x);
            bool t = (y >= 0) && y >= Math.Pow(x, 2) && (y <= 2 - x);
            if (z || t)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
