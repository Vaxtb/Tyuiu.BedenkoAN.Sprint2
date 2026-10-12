using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BedenkoAN.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int dneyVmesyce;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dneyVmesyce = 31;
                    break;
                case 4: case 6 : case 9: case 11:
                    dneyVmesyce = 30;
                    break;
                case 2:
                    dneyVmesyce = 28;
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m} не подходит");


            }
            int SledDay, SledMonth, SledYear;
            if (n<dneyVmesyce)
            {
                SledDay = n + 1;
                SledMonth = m;
                SledYear = g;

            }
            else
            {
                SledDay = 1;
                if (m<12)
                {
                    SledMonth = m + 1;
                    SledYear = g;

                }
                else
                {
                    SledMonth = 1;
                    SledYear = g + 1;

                }
            }
            string data1 = (SledDay + "." + SledMonth + "." + SledYear);
            string data2 = (SledDay + ".0" + SledMonth + "." + SledYear);
            string data3 = ("0" + SledDay + ".0" + SledMonth + "." + SledYear);
            string data4 = ("0" + SledDay + "." + SledMonth + "." + SledYear);

            if (SledMonth < 10)
            {
                if (SledDay < 10)
                {
                    return data3;

                }
                else
                {
                    return data2;
                }
            }
            else if (SledDay < 10) 
            {
                return data4;


            }
            else
            {
                return data1;
            }
            
            
        }
    }
}
