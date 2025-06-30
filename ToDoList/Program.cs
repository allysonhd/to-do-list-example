using System;
using System.Collections.Generic;
using System.Linq;  
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list in C# program.");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "quit")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter 'quit' to exit the program.");
                
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("What would you like to do?");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Your task has been added to the list.");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }
                    Console.WriteLine("Please enter the number for the task you would like to remove.");
                    int taskToRemove = int.Parse(Console.ReadLine());
                    taskList.RemoveAt(taskToRemove);
                } else if (option == "3")
                {
                    Console.WriteLine("List of Tasks:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }
                } else if (option == "quit")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            } 
            Console.WriteLine("Thank you for using this program.");
        } 
    }
}