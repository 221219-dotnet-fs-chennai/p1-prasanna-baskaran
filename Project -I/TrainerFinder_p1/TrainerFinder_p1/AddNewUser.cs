﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerFinder_p1
{
    internal class AddNewUser : IMenu
    {
        public void Display()
        {
           Console.WriteLine("[0] Login");
           Console.WriteLine("[1] Signup");
           Console.WriteLine("[2]  Main Menu");
        }

        public string UserChoice()
        {
            Console.Write("Enter your choice: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "Login";
                case "1":
                    return "Signup";
                case "2":
                    return "MainMenu";
                default:
                    Console.WriteLine("Wrong Choice! Try again...");
                    Console.WriteLine("Enter to Continue...");
                    Console.ReadLine();
                    return "AddTrainer";
            }
        }
    }
}
