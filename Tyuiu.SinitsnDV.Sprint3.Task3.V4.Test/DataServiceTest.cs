using Tyuiu.SinitsinDV.Sprint3.Task3.V4.Lib;
namespace Tyuiu.SinitsinDV.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string value = "plkjjdw cvjkl";
            char item = 'j';
            string res = ds.DeleteCharInString(value, item);
            string wait = "plkdw cvkl";
            Assert.AreEqual(wait, res);



        }
    }
}