using Tyuiu.SinitsinDV.Sprint3.Task5.V7.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = 34.191;
            Assert.AreEqual(wait, res);



        }
    }
}