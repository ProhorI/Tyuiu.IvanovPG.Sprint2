// ЗАДАНИЕ:
// Написать программу из операций сравнения (==, !=, <, >, <=, >=)
// последовательность можно чередовать, но использзовать один раз в выражении
//  и логических операций ( |, &, ||, &&, !, ^, последовательность операций не должно нарушаться)
// и арифметических выражений, которая вернет логическкуюю последовательность (Массив):
// (True, True, True, True, True, True) при а = 15 b = 16 c = 14 d = 17 

using tyuiu.cources.programming.interfaces.Sprint2;



namespace Tyuiu.IvanovPG.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c > d); // ТРУ
            res[1] = (a + 716 > b) & (c > d); // ТРУ 
            res[2] = (a > b) || (c < d + 144); // ТРУ 
            res[3] = (a + 716 > b) && (c < d); //ФАЛС
            res[4] = !(!(res[0])); // ТРУ 
            res[5] = (a > b) ^ (c < d); // 15 > 16 - false, 14 < 17 - true; поэтому вернем тру ПО ЗАДАНИЮ ФАЛС

            return res;
        }
    }
}
