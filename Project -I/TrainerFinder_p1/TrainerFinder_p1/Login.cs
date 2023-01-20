﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerFinder_p1
{
    internal class Login : IMenu
    {
        UserDetails trainerProfile = new UserDetails();
        static string connstrr = "Server=tcp:prasanna-db-server.database.windows.net,1433;Initial Catalog=Trainerfind;User ID=prasannaadmin;Password=Amma@621218;";
        IRepo repo = new SqlRepo(connstrr);
        public void Display()
        {
            System.Console.WriteLine("Welcome to Login menu");
            System.Console.WriteLine("[0] Back");
            System.Console.WriteLine("[1] Login Existing user");
        }

        public string UserChoice()
        {
            System.Console.Write("Enter your choice: ");
            string userChoice = System.Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    System.Console.Write("Enter your Email: ");
                    string Email = System.Console.ReadLine();
                    bool ans = repo.login(Email);
                    if (ans)
                    {
                        SIgnUp TrainerLogin = new SIgnUp(repo.GetAllTrainer(Email));
                        string value = System.Console.ReadLine();
                        if (value is "y")
                        {
                            return "UpdateTrainer";
                        }
                        System.Console.WriteLine("proceed...");
                        System.Console.ReadLine();
                        Interaction a = new Interaction(trainerProfile);
                        a.Display();
                        
                        return "MainMenu";
                    }
                    else
                    {
                        System.Console.WriteLine("User invalid");
                        System.Console.ReadLine();
                        return "Login";
                    }

                default:
                    System.Console.WriteLine("try again...");
                    System.Console.WriteLine("Press Enter to continue...");
                    System.Console.ReadLine();
                    return "trainerLogin";
            }
        }
    }
}
