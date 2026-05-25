using System;
using res_user;

namespace ConsoleApp212
{

    interface IEmployeeActions
    {
        void AddMeal();
        void ViewMeals();
        void OrderMeal();
        void ViewBills();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("1", "1");
            Report rrr = new Report("2", "2");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Restaurant Management System ===");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                User currentUser = null;


                if (username == manager.Username && password == manager.Password)
                {
                    currentUser = manager;
                }
                else if (username == rrr.Username && password == rrr.Password)
                {
                    currentUser = rrr;
                }
                else
                {
                    currentUser = manager.FindEmployee(username, password);
                }


                if (currentUser == null)
                {
                    Console.WriteLine("Invalid credentials. Press any key to try again...");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine($"Welcome, {currentUser.GetRole()}!");
                currentUser.ShowMenu();
            }
        }
    }
}
