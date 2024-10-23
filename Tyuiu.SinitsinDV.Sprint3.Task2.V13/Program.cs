using Tyuiu.SinitsinDV.Sprint3.Task2.V13.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #3                                         *");
            Console.WriteLine("* Тема: Оператор цикла do-while                     *");
            Console.WriteLine("* Задание #2                                        *");
            Console.WriteLine("* Вариант #13                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу используя цикл do...while,     *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при t=0,7*");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Переменная X: " + value);
            Console.WriteLine("Начало шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);



            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Сумма ряда: " + Math.Round(ds.GetSumSeries(value, startValue, stopValue), 3));
        }
    }
}
