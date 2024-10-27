using Tyuiu.SinitsinDV.Sprint3.Task6.V19.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task6.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #3                                         *");
            Console.WriteLine("* Тема: Обработка целочисленной информации          *");
            Console.WriteLine("* Задание #6                                        *");
            Console.WriteLine("* Вариант #19                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел*");
            Console.WriteLine("* принадлежащих числовому отрезку[10, 15] количество*");
            Console.WriteLine("* всех делителей меньше 8                           *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int startValue = 10;
            int stopValue = 15;

            Console.WriteLine("Начало отрезка: " + startValue);
            Console.WriteLine("Конец отрезка: " + stopValue);


            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Количество всех делителей меньше 8: " + ds.GetSumTheDivisors(startValue, stopValue));



        }
    }
}
