using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static double GetDouble()
        {
            double a;
            bool flag = false;
            do
            {
                Console.Write("Введите a: ");
                string line = Console.ReadLine();
                if (double.TryParse(line, out a)) flag = true;

                else Console.WriteLine("Ошибка: нужно ввести число.");

            } while (!flag);
            return a;
        }
        static void Calculation(double a)
        {
            double z1 = (Math.Sin(2.0 * a) + Math.Sin(5.0 * a) - Math.Sin(3.0 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2.0 * a), 2));
            Console.WriteLine($"Result is z1 = {z1} ");
            Console.ReadKey();
        }



        static void Main()
        {
            Calculation(GetDouble());
        }

    }
}
