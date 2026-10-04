using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BedenkoAN.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res= new bool[6];
            res[0] = y + 750 == x;
            res[1] = y + 750 != x;
            res[2] = x > y;
            res[3] = x < y;
            res[4] = x >= y;
            res[5] = x <= y;
            return res;

            

        }
    }
}
