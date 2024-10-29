using Tyuiu.SinitsinDV.Sprint3.Task7.V18.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #3                                         *");
            Console.WriteLine("* Тема:Добавление к итоговых проектов по спринту    *");
            Console.WriteLine("* Задание #7                                        *");
            Console.WriteLine("* Вариант #18                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая выводит таблицу       *");
            Console.WriteLine("* значений функции:                                 *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага " + startValue);
            Console.WriteLine("Конец шага " + stopValue);


            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    X     |   f(x)    |");
            for (int i = 0; i <= len; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1, 5:f2}     |", startValue, valueArray[i]);
                startValue++;
                string str = "+----------+-----------+";
                Console.WriteLine(str);
            }

            


        }
    }
}
