using Tyuiu.SinitsinDV.Sprint3.Task4.V24.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 46.75;
            Assert.AreEqual(wait, res);
        }
    }
}