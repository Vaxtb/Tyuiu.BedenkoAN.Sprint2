using Mono.Cecil.Cil;
using Tyuiu.BedenkoAN.Sprint2.Task2.V22.Lib;

namespace Tyuiu.BedenkoAN.Sprint2.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 4;
            bool[] res = ds.GetCompareOperations(x, y);
            bool wait = true;
            CollectionAssert.AreEqual(new bool[] { wait }, res);
            

        }
    }
}
