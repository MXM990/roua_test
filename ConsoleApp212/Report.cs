using res_user;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    internal class Report : User
    {
        public Report(string username, string password) : base(username, password)
        {
        }

        public override string GetRole()
        {
            return "Report";
        }
        public override void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- report Menu ---");
                Console.WriteLine("1. show report");
                Console.WriteLine("2. Logout");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    read();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Logging out...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
        public void read()
        {
            string[] a = File.ReadAllLines("mxm.txt");
            foreach (var item in a)
            {
                Console.WriteLine(item);
                Console.WriteLine("//////");
            }
        }
    }
}
