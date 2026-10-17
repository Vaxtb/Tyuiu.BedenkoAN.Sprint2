using Tyuiu.BedenkoAN.Sprint2.Task5.V11.Lib;
namespace Tyuiu.BedenkoAN.Sprint2.Task5.V11.Test



{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int d = 1, m = 11, g = 2026;

            int d2 = 28, m2 = 2, g2 = 2024;
            int d3 = 31, m3 = 12, g3 = 2025;
            int de = 1, me = 13, ge = 2026;
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(g, m, d);
            string res2 = ds.FindDateOfNextDay(g2, m2, d2);
            string res3 = ds.FindDateOfNextDay(g3, m3, d3);
            

            Assert.AreEqual("02.11.2026", res);
            Assert.AreEqual("01.03.2024", res2);
            Assert.AreEqual("01.01.2026", res3);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            
            DataService ds = new DataService();

            
            int year = 2026;
            int month = 13; 
            int day = 1;

           
            try
            {
                
                ds.FindDateOfNextDay(year, month, day);

                
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
               

                
                Assert.IsTrue(ex.Message.Contains("Месяц должен быть от 1 до 12"));
            }
            catch (Exception ex)
            {
               
                throw new AssertFailedException($"Ожидалось ArgumentException, но было получено {ex.GetType().Name}: {ex.Message}", ex);
            }
        }

    }
}
