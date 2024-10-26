using Tyuiu.SinitsinDV.Sprint3.Task4.V24.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #3                                         *");
            Console.WriteLine("* Тема: Использование операторов continue и break   *");
            Console.WriteLine("* Задание #4                                        *");
            Console.WriteLine("* Вариант #24                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,  *");
            Console.WriteLine("* вычислить значение функции y=(sin(x)/x)+2 .При    *");
            Console.WriteLine("* х = 0 прервать цикл. Полученные значения перемнож *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);


            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Значение функции: " + Math.Round(ds.Calculate(startValue, stopValue), 3));



        }
    }
}
