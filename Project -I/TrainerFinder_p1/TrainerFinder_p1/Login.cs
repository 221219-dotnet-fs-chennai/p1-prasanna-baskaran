using System;
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
        static string connstrr = "Server=tcp:prasanna-db1.database.windows.net,1433;Initial Catalog=TrainerFinder;User ID=prasannaadmin;Password=Amma@621218;";
        IRepo repo = new SqlRepo(connstrr);
        public void Display()
        {
            Log.Logger.Information("Login.cs at line 17 ");
            System.Console.WriteLine("Welcome to Login menu");
            System.Console.WriteLine("[0] Back");
            System.Console.WriteLine("[1] Login Existing user");
        }

        public string UserChoice()
        {
            Log.Logger.Information("Login.cs at line 25 ");
            System.Console.Write("Enter your choice: ");
            string userChoice = System.Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    System.Console.Write("Enter your Email: ");
                    string Email = System.Console.ReadLine();
                    Log.Logger.Information("Login.cs at line 36 ");
                    bool ans = repo.login(Email);
                    if (ans)
                    {
                        SIgnUp TrainerLogin = new SIgnUp(repo.GetAllUser(Email));
                        string value = System.Console.ReadLine();
                        System.Console.WriteLine("proceed...");
                        System.Console.ReadLine();
                        return "Interaction";
                    }
                    else
                    {
                        Log.Logger.Information("Login.cs at line 48 ");
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
