using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SinitsinDV.Sprint3.Task6.V19.Lib
{
    public class DataService : ISprint3Task6V19
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d <= stopValue; d++)
                {
                    if (d % 2 == 0)
                    {
                        if (d < 8)
                        {
                            sum++;
                        }
                    }

                }


            }
            return sum;
        }
    }
}
