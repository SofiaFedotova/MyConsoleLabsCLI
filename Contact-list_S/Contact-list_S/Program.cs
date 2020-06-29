using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_list_S.Tasks;
using System.Configuration;

namespace Contact_list_S
{
    class Process
    {
        private static ContactList Using;
        static void Main(string[] args)
        {
            ContactList l = new ContactList("Вася");
            l.InfoPrint();
            Work();
            Console.ReadKey();
        }
        public static bool Working { get; private set; }
        public static void Work()
        {
            Console.WriteLine("HeLLo");
            Working = true;
            Console.Write("Menu \n 'add' - to add contact \n 'change' to change contact \n 'search' \n 'print' - to print info about one contact \n 'printall' - to print all contacts \n 'clear' /n 'exit' \n 'help' to view information \n" +
                " 'open' to open you existing list \n 'save' - to save current list");
            while (Working)
            {
                try
                {
                    Console.Write("'help' to view information \n\n Command<");
                    string[] task = null;
                    while(task == null)
                         task = ReadTask();
                    if (Tasks.ContainsKey(task[0]))
                    {
                        Tasks[task[0]].Do();
                    }
                }
                catch
                {
                    Console.Write("Somtening wrong occured \n");
                    Console.ReadKey();
                }
            }
        }

        public static readonly Dictionary<string, ITask> Tasks = new Dictionary<string, ITask>()
        {
            ["showowner"] = new NameTask(),
            ["add"] = new AddTask(),
            ["change"] = new ChangeTaskcs(),
            ["search"] = new SearchTask(),
            ["printall"] = new PrintAllTasks(),
            ["help"] = new HelpTask(),
            ["clear"] = new ClearTask(),
            ["save"] = new SaveTask(),
            ["open"] = new OpenList(),
            ["exit"] = new ExitTask(),
        };
        
        public static void Exit()
        {
            Working = false;
        }

        public static string[] ReadTask()
        {
            var str = Console.ReadLine().Trim().Split();
            if (str == null || str[0] == " ")
                ColorfulWrite("try another time \n", ConsoleColor.DarkRed);
            else if(Tasks.ContainsKey(str[0]))
                     return str;
            else
                ColorfulWrite("no such command \n", ConsoleColor.DarkRed);
            return null;
        }


        public static void ColorfulWrite(string m, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(m);
            Console.ResetColor();
        }

        public static ContactList uzing
        {
            get
            {
                if(Using == null) Using = new ContactList("Sofia");
                return Using;
            }
            private set
            {
                Using = value;
            }
        }
        public static void CreateList(string S)
        {
            uzing = new ContactList(S);
        }
    }
}
