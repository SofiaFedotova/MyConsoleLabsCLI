using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    
        class Task2
        {
            public double[] GetR1R2()
            {
                double R1, R2;
                bool flag1 = false;
                bool flag2 = false;
                do
                {
                    Console.WriteLine("Enter R1");
                    string r1 = Console.ReadLine();
                    Console.WriteLine("Enter R2");
                    string r2 = Console.ReadLine();
                    if (double.TryParse(r1, out R1)) flag1 = true;
                    else Console.WriteLine("Ошибка: нужно ввести число.");
                    if (double.TryParse(r1, out R2)) flag2 = true;
                    else Console.WriteLine("Ошибка: нужно ввести число.");
                } while (!flag1 && !flag2);

                double[] mas = { R1, R2 };
                return mas;
            }

            public void Plot(double R1, double R2)
            {
                double[] mas = new double[400];

                for (int j = 0; j < 400; j++)
                {
                    double i = j - 200;
                    if (i <= 2 * R1)
                        mas[j] = -i;
                    if (i >= 2 * R1 && i <= 0)
                        mas[j] = -Math.Pow(Math.Pow(R1, 2) - Math.Pow(i + R2, 2), 0.5);
                    if (i <= 2 * R2 && i >= 0)
                        mas[j] = Math.Pow(Math.Pow(R2, 2) - Math.Pow(i - R2, 2), 0.5);
                    if (i >= 2 * R2 && i <= 2 * R2 + 5)
                        mas[j] = -0.5 * i;
                    if (i >= 2 * R2 + 5)
                        mas[j] = -1 * R2 + 2.5;
                }
                for (int i = 0; i < 400; i++)
                {
                    Console.WriteLine($"x = {i - 200} y = {mas[i]} ");
                }
                Console.ReadKey();
            }

        }
        class Main
        {

        }
    
}
