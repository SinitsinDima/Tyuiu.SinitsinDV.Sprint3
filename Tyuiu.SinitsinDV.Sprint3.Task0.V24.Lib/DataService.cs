using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SinitsinDV.Sprint3.Task0.V24.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1.0;
            for (int i = startValue; i <= stopValue; i++) 
            {
                p *= Math.Pow(3 / (i + Math.Pow(value, -i)), 2);

            }
            return Math.Round(p, 3);

        }
    }
}
