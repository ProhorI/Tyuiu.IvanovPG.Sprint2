using Tyuiu.IvanovPG.Sprint2.Task4.V21.Lib;

namespace Tyuiu.IvanovPG.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 256;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 0.726;
            Assert.AreEqual(wait, res);
        }
    }
}
//using Tyuiu.IvanovPG.Sprint2.Task4.V0.Lib;

//namespace Tyuiu.IvanovPG.Sprint2.Task4.V0.Test
//{
//    [TestClass]
//    public class DataServiceTest
//    {
//        [TestMethod]
//        public void ValidCondition1()
//        {
//            DataSevice ds = new DataSevice();
//            double x = 10;
//            double y = 5;
//            double res = ds.Calculate(x, y);
//            double wait = 3.5;
//            Assert.AreEqual(wait, res);
//        }
//        [TestMethod]
//        public void ValidCondition2()
//        {
//            DataSevice ds = new DataSevice();
//            double x = 10;
//            double y = 15;
//            double res = ds.Calculate(x, y);
//            double wait = 1.167;
//            Assert.AreEqual(wait, res);
//        }
//    }
//}
