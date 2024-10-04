

using Tyuiu.IvanovPG.Sprint2.Task0.V11.Lib;

namespace Tyuiu.IvanovPG.Sprint2.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 8105;
            int y = 275;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Иванов П.Г. | ИСТНБ-24-1";
            // Длина строки 75 символом
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* спринт #2                                                                          *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                   *");
            Console.WriteLine("* задание #2                                                                         *");
            Console.WriteLine("* вариант #11                                                                        *");
            Console.WriteLine("* выполнил: Иванов Прохор Геннадьевич | ИСТНБ-24-1                                   *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                           *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,            *");
            Console.WriteLine("* вычисляет результат по формуле x / (1 - y) и печатает его на экран                 *");
            Console.WriteLine("*                                                                                    *");


            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");


            Console.WriteLine("X  = " + x);
            Console.WriteLine("Y  = " + y);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}

