using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SinitsinDV.Sprint3.Task4.V24.Lib
{
    public class DataService : ISprint3Task4V24
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    y = y * ((Math.Sin(x) / x) + 2);
                }
            }
            return Math.Round(y, 3);
        }
    }
}
