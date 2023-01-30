global using Serilog;
using System;
using System.Data.SqlClient;
using TrainerFinder_p1;
using BuisnessLogic;
using Models;
using Microsoft.VisualBasic;

namespace TrainerFinder_p1
{
    class Program : SIgnUp
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"..\..\..\Logs\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Logger.Information("-------Program starting-------");

            bool v = true;
            bool v2;
            Log.Logger.Information("Program.cs at line 20 ");
            IMenu menu = new Menu();

            while (v)
            {
                System.Console.Clear();
                Log.Logger.Information("Program.cs at line 20 ");
                menu.Display();

                string reply = menu.UserChoice();

                switch (reply)
                {
                    case "GetAvailableTrainers":
                        Log.Logger.Information("Program.cs at line 20 ");
                        menu = new Listall();
                        break;
                    case "Menu":
                        Log.Logger.Information("Program.cs at line 20 ");
                        menu = new Menu();
                        break;
                    case "Signup":
                        Log.Logger.Information("Program.cs at line 20 ");
                        menu = new SIgnUp();
                        break;
                    case "UserUpdate":

                        Log.Logger.Information("update User");
                        menu = new UserUpdate();
                        break;
                    case "Showuser":
                        Log.Logger.Information(" Adding new User");
                        UserDetails details = new UserDetails();
                        Console.WriteLine(details.GetDetails());
                        break;

                    case "Login":

                        Log.Logger.Information("Program.cs at line 58 ");
                        details = new UserDetails();
                        menu = new Login();
                        v2 = true;

                        while (v2)
                        {
                            Log.Logger.Information("Program.cs at line 65 ");
                            System.Console.Clear();
                            menu.Display();
                            string Choice = menu.UserChoice();

                            switch (Choice)
                            {
                                case "UserUpdate":
                                    Log.Logger.Information("Program.cs at line 73 ");
                                    menu = new UserUpdate();
                                    break;
                                case "MainMenu":
                                    Log.Logger.Information("Program.cs at line 77 ");
                                    menu = new Menu();
                                    v2 = false;
                                    break;
                                case "Deleteuser":
                                    Log.Logger.Information("Program.cs at line 82 ");
                                    menu = new DeleteUser(details);
                                    Console.WriteLine("User deleted success");
                                    break;
                                case "Exit":
                                    Log.Logger.Information("Program.cs at line 87 ");
                                    menu = new AddNewUser();
                                    break;
                                case "Interaction":
                                    Log.Logger.Information("Program.cs at line 91 ");
                                    Console.WriteLine("Welcome to Trainer's Menu");
                                    Console.ReadKey();
                                    menu = new Interaction(details);
                                    break;
                                case "Login":
                                    Log.Logger.Information("Program.cs at line 98 ");
                                    details = new UserDetails();
                                    menu = new Login();
                                    v2 = true;
                                    break;
                                default:
                                    Log.Logger.Information("Program.cs at line 97 ");
                                    System.Console.WriteLine("Try again...");
                                    System.Console.WriteLine("Enter to Continue...");
                                    System.Console.ReadLine();
                                    break;
                            }
                        }
                        break;

                    case "Exit":
                        Log.Logger.Information("Program.cs at line 107 ");
                        System.Console.WriteLine("Thank you for visiting");
                        Log.Logger.Information("-------Program ends-------");
                        Log.CloseAndFlush();
                        v = false;
                        break;

                    default:
                        Log.Logger.Information("Program.cs at line 114 ");
                        System.Console.WriteLine("DataBase is not present");
                        System.Console.WriteLine("continue...");
                        System.Console.ReadLine();
                        break;
                }
            }
        }
    }
}