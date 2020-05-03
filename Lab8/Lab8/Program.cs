using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Task8
    {
        public void Srch(List<Do> A, string Tg)
        {
            string[] str = new string[22];
            int num = 0;
            foreach (Do i in A)
            {
                foreach (string s in i.Tags1)
                {
                    if (s == Tg)
                    {
                        str[num] = i.Title1;
                        num++;
                    }
                }
            }
            if (num == 0)
                Console.WriteLine("Not Found");
            else
                foreach (string a in str) { Console.WriteLine($"{a}"); }
            Console.WriteLine("Finish");
        }

    }
}
/* main for this task
 * Task8 Eight = new Task8();
 * var f = new List<Do>() { };
            int Run = 0;
            double x = 0;
            while (Run != 1)
            {
                Console.WriteLine("Menu:1-Add 2-Search by Tag 3-Exit");
                x = Convert.ToDouble(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("Title:");
                            string A = Console.ReadLine();
                            Console.WriteLine("Discription:");
                            string B = Console.ReadLine();
                            Console.WriteLine("Deadline Day:");
                            int C = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Deadline Month(Number):");
                            int D = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Deadline Year:");
                            int E = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите Tags через пробел");
                            string[] s = Console.ReadLine().Split(' ');
                            Do it = new Do(A, B, C, D, E, s);
                            f.Add(it);
                            Console.WriteLine("Added");
                            break;
                        }
                    case 2:
                        {
                            string t = Console.ReadLine();
                            Eight.Srch(f, t);
                            break;
                        }
                    case 3:
                        {
                            Run = 1;
                            Console.WriteLine("Finish");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Use another number");
                            break;
                        }
                }
            }*/
}
