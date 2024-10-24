using Tyuiu.SinitsnDV.Sprint3.Task3.V4.Lib;
namespace Tyuiu.SinitsnDV.Sprint3.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #3                                         *");
            Console.WriteLine("* Тема: Оператор цикла foreach                      *");
            Console.WriteLine("* Задание #3                                        *");
            Console.WriteLine("* Вариант #4                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все      *");
            Console.WriteLine("* буквы j в строке: plkjjdw cvjkl                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            string str = "plkjjdw cvjkl";
            char ch = 'j';



            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine(ds.DeleteCharInString(str, ch));


        }
    }
}
