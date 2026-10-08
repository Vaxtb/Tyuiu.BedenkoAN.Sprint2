using Tyuiu.BedenkoAN.Sprint2.Task3.V5.Lib;
namespace Tyuiu.BedenkoAN.Sprint2.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая вычисляет требуемое значение функции Y*");
            Console.WriteLine("* с использованием вложенных операторов if-else, где пользователь вводит  *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение       *");
            Console.WriteLine("* до трех знаков после запятой.                                           *");
            Console.WriteLine("========================================================");
            Console.WriteLine("                 ВЫЧИСЛЕНИЕ ФУНКЦИИ Y");
            Console.WriteLine("========================================================");
            Console.WriteLine("Функция задана следующим образом:");
            Console.WriteLine();
            Console.WriteLine("  x - ((x + 1) / (x - 1))^x,    если x > 1");
            Console.WriteLine("  (x^2 - cos(x^2)) / (x^2 - sin(x^2) + 12),    если x = 0");
            Console.WriteLine("  (6 + 4 / x^2)^x,              если -9 < x < 0");
            Console.WriteLine("  x^3 + 10x - x^2 / x^4,        если x < -9");
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x;
            DataService ds = new DataService();

            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.Calculate(x);
            Console.WriteLine("значение Y:" + res);
            Console.ReadLine();

        }
    }
}
