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

            Log.Logger.Information("-------Program starting-------");

            bool v = true;
            bool v2;

            IMenu menu = new Menu();

            while (v)
            {
                Log.Logger.Information("Program.cs Line no : 25");
                System.Console.Clear();
                menu.Display();
                Log.Logger.Information("Program.cs Line no : 28");
                string reply = menu.UserChoice();

                switch (reply)
                {
                    case "GetAvailableTrainers":
                        Log.Logger.Information("Program.cs Line no : 34");
                        menu = new Listall();
                        break;
                    case "Menu":
                        Log.Logger.Information("Program.cs Line no : 38");
                        menu = new Menu();
                        break;
                    case "Signup":
                        Log.Logger.Information("Program.cs Line no : 42");
                        menu = new SIgnUp();
                        break;
                    case "UserUpdate":
                        Log.Logger.Information("Program.cs Line no : 46");
                        
                        menu = new UserUpdate();
                        break;
                    case "Showuser":
                        Log.Logger.Information("Program.cs Line no : 51");
                        
                        UserDetails details = new UserDetails();
                        Console.WriteLine(details.GetDetails());
                        break;

                    case "Login":
                        Log.Logger.Information("Program.cs Line no : 58");
                        
                        details= new UserDetails(); 
                        menu = new Login();
                        v2 = true;

                        while (v2)
                        {
                            System.Console.Clear();
                            Log.Logger.Information("Program.cs Line no : 67");
                            menu.Display();
                            string Choice = menu.UserChoice();

                            switch (Choice)
                            {
                                case "UserUpdate":
                                    Log.Logger.Information("Program.cs Line no : 74");
                                    Log.Logger.Information("user select update trainer");
                                    menu = new UserUpdate();
                                    break;
                                case "MainMenu":
                                    Log.Logger.Information("Program.cs Line no : 79");
                                    Log.Logger.Information("User select Main menu");
                                    menu = new Menu();
                                    v2 = false;
                                    break;
                                case "Deleteuser":
                                    Log.Logger.Information("Program.cs Line no : 85");
                                    Log.Logger.Information("Delete user");
                                    menu = new DeleteUser(details);
                                    Console.WriteLine("User deleted success");
                                    break;
                                case "Exit":
                                    Log.Logger.Information("Program.cs Line no : 91");
                                    Log.Logger.Information("To exit");
                                    menu = new AddNewUser();
                                    break;
                                case "Interaction":
                                    Log.Logger.Information("Program.cs Line no : 96");
                                    Log.Logger.Information("Trainer's  Main menu");
                                    Console.WriteLine("Welcome to Trainer's Menu");
                                    Console.ReadKey();
                                    menu = new Interaction(details);
                                    break;

                                case "Login":
                                    Log.Logger.Information("Program.cs Line no : 104");
                                    Log.Logger.Information("User select trainer");
                                    details = new UserDetails();
                                    menu = new Login();
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
                        Log.Logger.Information("Program.cs Line no : 120");
                        System.Console.WriteLine("Thank you for visiting");
                        Log.Logger.Information("-------Program ends-------");
                        Log.CloseAndFlush();
                        v = false;
                        break;

                    default:
                        Log.Logger.Information("Program.cs Line no : 128");
                        System.Console.WriteLine("DataBase is not present");
                        System.Console.WriteLine("continue...");
                        System.Console.ReadLine();
                        break;
                }
            }
        }
    }
}