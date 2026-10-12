using Tyuiu.BedenkoAN.Sprint2.Task5.V11.Lib;
namespace Tyuiu.BedenkoAN.Sprint2.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:*");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                       *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня. Заданный год не является високосным.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int d, m, g;
            Console.WriteLine("Введите день:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год:");
            g = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            
            string res = ds.FindDateOfNextDay(g,m,d);
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (((m>12) || (m<1)) || ((d>31) || (d<1)))
            {
                Console.WriteLine("Не правильный месяц или день!");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Следующая дата:" + res);
                Console.ReadKey();

            }
        }
    }
}
