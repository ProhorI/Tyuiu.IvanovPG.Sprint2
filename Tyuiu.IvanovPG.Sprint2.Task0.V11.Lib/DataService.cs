

// ЗАДАНИЕ:
// Написатьпрограмму из операций сравнения (==, !=, <, >, <=, >=, последовательноть операций не должна нарушаться)
// и арифметических выражений, которая вернет логическкуюю последовательность (Массив):
// (True, True, True, True, True, True) при х = 8105 и у = 275

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.IvanovPG.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 7830;
            res[1] = x != y + 7830;
            res[2] = x < y + 7831;
            res[3] = x > y + 7831;
            res[4] = x <= y + 7831;
            res[5] = x - 7900 >= y;

            return res;

        }
    }
}