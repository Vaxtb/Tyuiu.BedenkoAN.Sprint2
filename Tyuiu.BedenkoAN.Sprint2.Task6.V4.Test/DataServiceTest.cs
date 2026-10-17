using Tyuiu.BedenkoAN.Sprint2.Task6.V4.Lib;
namespace Tyuiu.BedenkoAN.Sprint2.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            string res = ds.FindCardSuit(x);
            Assert.AreEqual("пики", res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            int x = 2;
            string res = ds.FindCardSuit(x);
            Assert.AreEqual("трефы", res);

        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            int x = 3;
            string res = ds.FindCardSuit(x);
            Assert.AreEqual("бубны", res);

        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            int x = 4;
            string res = ds.FindCardSuit(x);
            Assert.AreEqual("червы", res);

        }
        [TestMethod]
        public void TestMethod5()
        {
            DataService ds = new DataService();
            int x = 5;
            string res = ds.FindCardSuit(x);
            Assert.AreEqual("Неизвестная масть", res);

        }
    }
}
