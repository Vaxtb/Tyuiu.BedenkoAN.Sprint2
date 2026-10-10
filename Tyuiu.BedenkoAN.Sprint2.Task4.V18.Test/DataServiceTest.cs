using Tyuiu.BedenkoAN.Sprint2.Task4.V18.Lib;
namespace Tyuiu.BedenkoAN.Sprint2.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(wait, res);

                
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
