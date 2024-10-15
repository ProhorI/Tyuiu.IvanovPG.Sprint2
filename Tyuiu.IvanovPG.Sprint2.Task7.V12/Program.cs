using Tyuiu.IvanovPG.Sprint2.Task7.V12.Lib;

namespace Tyuiu.IvanovPG.Sprint2.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите значение переменной х:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y:");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится внутри закрашенной области");
            }
            else
            {
                Console.WriteLine("Точка не находится внутри закрашенной области");

                Console.ReadKey();
            }
        }
    }
}
