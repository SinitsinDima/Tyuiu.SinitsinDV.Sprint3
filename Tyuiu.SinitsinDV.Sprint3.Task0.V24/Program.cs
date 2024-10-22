using Tyuiu.SinitsinDV.Sprint3.Task0.V24.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #3                                         *");
            Console.WriteLine("* Тема: Оператор цикла for                          *");
            Console.WriteLine("* Задание #0                                        *");
            Console.WriteLine("* Вариант #24                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу используя цикл for, которая    *");
            Console.WriteLine("* вычисляет произведение ряда по формуле, при X=5   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 7;


            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("p: " + Math.Round(ds.GetMultiplySeries(value, startValue, stopValue), 3));
        }
    }
}
