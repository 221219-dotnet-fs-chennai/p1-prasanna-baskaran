using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerFinder_p1
{
    internal class Menu : IMenu
    {
        public void Display()
        {
            System.Console.WriteLine("Welcome to Main Menu!");
            System.Console.WriteLine("[3] available trainers list");
            System.Console.WriteLine("[2] Login");
            System.Console.WriteLine("[1] Signup");
            System.Console.WriteLine("[0] Exit");

        }

        public string UserChoice()
        {
            string userInput = System.Console.ReadLine();

            //Switch cases are just useful if you are doing a bunch of comparison
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "3":
                    return "GetAvailableTrainers";
                
                case "2":
                    return "Login";
                case "1":
                    return "Signup";
                default:
                    System.Console.WriteLine("Try again.....");
                    System.Console.WriteLine("press Enter to continue");
                    System.Console.ReadLine();
                    return "Menu";
            }
        }
    }
}
