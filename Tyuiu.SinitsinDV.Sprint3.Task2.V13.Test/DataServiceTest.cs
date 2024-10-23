using Newtonsoft.Json.Linq;
using Tyuiu.SinitsinDV.Sprint3.Task2.V13.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 4.063;
            Assert.AreEqual(wait, res);



        }
    }
}