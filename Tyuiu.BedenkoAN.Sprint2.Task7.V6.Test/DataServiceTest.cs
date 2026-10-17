using Tyuiu.BedenkoAN.Sprint2.Task7.V6.Lib;
namespace Tyuiu.BedenkoAN.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1.3, y = 1.5;

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);


        }
        public void TestMethod2()
        {
            double x = 1.3, y = 1.8;

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);


        }
    }
}
