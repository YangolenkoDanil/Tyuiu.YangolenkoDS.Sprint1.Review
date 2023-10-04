using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint1.TaskReview.V22.Lib;
namespace Tyuiu.YangolenkoDS.Sprint1.TaskReview.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: SprintReview                                                                *");
            Console.WriteLine("* Задание TaskReview                                                                *");
            Console.WriteLine("* Вариант #22                                                                       *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                    *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                             *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*                 ctg(x)                                                            *");
            Console.WriteLine("* Z = (1 - tan(x))       + cos(x - y)                                               *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            y = Convert.ToDouble(Console.ReadLine());

            var z = Math.Round(ds.Calculate(x, y), 3);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine($"Z = {z}");
            Console.ReadKey();
        }
    }
}
