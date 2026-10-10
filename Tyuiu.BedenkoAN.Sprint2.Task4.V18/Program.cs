using Tyuiu.BedenkoAN.Sprint2.Task4.V18.Lib;
namespace Tyuiu.BedenkoAN.Sprint2.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x,y с  *");
            Console.WriteLine("* клавиатуры                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("Условие: x * 3 < y - 2\n" +
                  "Если ВЕРНО: z = (6 + (x - 1) / y^3)^x\n" +
                  "Если НЕВЕРНО: z = x + 10*y - (1 / x)");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            double x, y;

            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.Calculate(x, y);
            Console.WriteLine("значение функции Z:" + res);
            Console.ReadLine();

        }   

    }
}
