using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Task
    {
        public string Name { get; }
        public bool IsDone { get; set; }
        public Task(String Name)
        {
            this.Name = Name;
            IsDone = false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> Tasks = new List<Task>();
            const string End = "END";
            const string New = "NEW";
            const string Show = "SHOW";
            //const string file = "C:\personal\akormilin\WriteLines2.txt";
            string curstring = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Gosotron Task Manager 1.0, worst task manager ever!");
                Console.WriteLine("You can add new task by typing the 'NEW' keyword, show current tasks by typing 'SHOW' or exit the application by typing 'END'");
                curstring = Console.ReadLine();
                switch (curstring)
                {
                    case New:
                        Console.Clear();
                        Console.WriteLine("Enter new task:");
                        Task curtask = new Task(Console.ReadLine());
                        Tasks.Add(curtask);
                        break;

                    case Show:
                        foreach (Task Task in Tasks)
                        {
                            Console.WriteLine(Task.Name);
                            Console.ReadKey();
                        }
                        break;
                }
            } while (curstring != End);
            Environment.Exit(0);
        }
    }
}
