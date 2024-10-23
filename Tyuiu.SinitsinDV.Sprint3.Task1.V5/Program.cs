using Tyuiu.SinitsinDV.Sprint3.Task1.V5.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task1.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #3                                         *");
            Console.WriteLine("* Тема: Оператор цикла while                        *");
            Console.WriteLine("* Задание #1                                        *");
            Console.WriteLine("* Вариант #5                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу используя цикл while,          *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле    *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Начало шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);


            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Произведение ряда: " + Math.Round(ds.GetMultiplySeries(startValue, stopValue), 3));
        }
    }
}
