

using  Tyuiu.IvanovPG.Sprint2.Task2.V11.Lib;

namespace Tyuiu.IvanovPG.Sprint2.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidChekDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(true, res);
        }
    }
}
