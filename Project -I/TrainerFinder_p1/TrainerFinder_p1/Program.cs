global using Serilog;
using System;
using System.Data.SqlClient;
using TrainerFinder_p1;

namespace Console1
{
    internal class Program : SIgnUp
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"..\..\..\Logs\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Logger.Information("-------Program starts-------");

            bool value = true;
            bool value2;

            IMenu menu = new Menu();

            while (value)
            {
                System.Console.Clear();
                menu.Display();

                string reply = menu.UserChoice();

                switch (reply)
                {
                    case "GetAvailableTrainers":
                        menu = new Listall();
                        break;
                    case "Menu": 
                        menu = new Menu();
                        break;
                    case "Signup":
                        menu = new SIgnUp();
                        break;
                    case "AddTrainer":
                        Log.Logger.Information("User select trainer Add trainer");
                        menu = new AddNewUser();
                        break;

                    case "Login":

                        Log.Logger.Information("User select trainer");
                        menu = new Login();
                        value2 = true;

                        while (value2)
                        {
                            System.Console.Clear();
                            menu.Display();
                            string Choice = menu.UserChoice();

                            switch (Choice)
                            {
                                case "UpdateTrainer":
                                    Log.Logger.Information("user select update trainer");
                                    menu = new UserUpdate();
                                    break;
                                case "MainMenu":
                                    Log.Logger.Information("User select Main menu");
                                    menu = new Menu();
                                    value2 = false;
                                    break;
                                case "Exit":
                                    Log.Logger.Information("To exit");
                                    menu = new AddNewUser();
                                    break;
                                default:
                                    System.Console.WriteLine("Try again...");
                                    System.Console.WriteLine("Enter to Continue...");
                                    System.Console.ReadLine();
                                    break;
                            }
                        }
                        break;

                    case "Exit":
                        System.Console.WriteLine("Thank you for visiting");
                        Log.Logger.Information("-------Program ends-------");
                        Log.CloseAndFlush();
                        value = false;
                        break;

                    default:
                        System.Console.WriteLine("DataBase is not present");
                        System.Console.WriteLine("continue...");
                        System.Console.ReadLine();
                        break;
                }
            }
        }
    }
}