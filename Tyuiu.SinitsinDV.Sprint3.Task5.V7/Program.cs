using Tyuiu.SinitsinDV.Sprint3.Task5.V7.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #3                                         *");
            Console.WriteLine("* Тема: Вложенные циклы                             *");
            Console.WriteLine("* Задание #5                                        *");
            Console.WriteLine("* Вариант #7                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            int x = 5;
            int startValue = 1;
            int stopValue = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Старт шага первой суммы ряда: " + startValue);
            Console.WriteLine("Конец шага первой суммы ряда: " + stopValue);
            Console.WriteLine("Старт шага второй суммы ряда: " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда: " + stopValue2);



            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Значение функции: " + Math.Round(ds.GetSumSumSeries(x, startValue, stopValue, startValue2, stopValue2), 3));



        }
    }
}
