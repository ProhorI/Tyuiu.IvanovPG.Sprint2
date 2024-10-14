using Tyuiu.IvanovPG.Sprint2.Task5.V15.Lib;

namespace Tyuiu.IvanovPG.Sprint2.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Введите номер месяца:");
            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numDay < 1) || (numDay> 7))
            {
                res = "Значение введено неверно!";
            }
            else
            {
                res = "Этот день:" + ds.FindDayName(numDay);
            }

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
