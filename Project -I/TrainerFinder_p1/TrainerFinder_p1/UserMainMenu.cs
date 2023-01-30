using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BuisnessLogic;
using Models;
using DataRepo;


namespace TrainerFinder_p1
{
    internal class Interaction : IMenu
    {
        UserDetails user1 = new UserDetails();
        static string conStr = "Server=tcp:prasanna-db1.database.windows.net,1433;Initial Catalog=TrainerFinder;User ID=prasannaadmin;Password=Amma@621218;";

        IRepo repo = new SqlRepo(conStr);
        IMenu menu = new Menu();
        public Interaction(UserDetails trainer)
        {
            Log.Logger.Information("Interaction.cs Line no : 19");
            user1 = trainer;
            Console.WriteLine(user1.GetDetails());
        }
        public void Display()
        {
            Log.Logger.Information("Interaction.cs Line no : 25");
            Console.WriteLine($"Welcome ****************{user1.Username}************ :)");
            Console.WriteLine("[0] Back");
            Console.WriteLine("[1] View trainer/User Profile");
            Console.WriteLine("[2] Update User Profile");
            Console.WriteLine("[3] Delete User Profile");
        }

        public string UserChoice()
        {
            Log.Logger.Information("Interaction.cs Line no : 35");
            Console.Write("\nEnter your choice: ");
            string userChoice = System.Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "Login";
                case "1":
                    Dis_profile();
                   
                   Console.WriteLine("Press Enter to continue...");
                   Console.ReadLine();
                    return "UserInteraction";

                case "3":
                    Log.Logger.Information("Delete user");
                    menu = new DeleteUser(user1);
                    Console.WriteLine("User deleted success");
                    Console.ReadLine();
                    return "UserInteraction";
                case "2":
                    user1.GetDetails();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    return "UserUpdate";
                default:
                    Console.WriteLine("try again......");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return "UserInteraction";
            }
        }

       

        public void Dis_profile()
        {
            Log.Logger.Information("Interaction.cs Line no : 73");
            Console.Clear();
            Console.WriteLine("Full_name            : " + user1.Username);
            Console.WriteLine("Gender               : " + user1.Gender);
            Console.WriteLine("Email                : " + user1.Email);
            Console.WriteLine("Password             : " + user1.Password);
            Console.WriteLine("Location             : " + user1.Location);
            Console.WriteLine("Aboutme              : " + user1.Aboutme);
            Console.WriteLine("Skills               : " + user1.Skills);
            Console.WriteLine("Certification        : " + user1.Certifications);
            Console.WriteLine("SSLC                 : " + user1.Sslc);
            Console.WriteLine("SSC                  : " + user1.Ssc);
            Console.WriteLine("UG                   : " + user1.Ug);
            Console.WriteLine("PG                   : " + user1.Pg);
            Console.WriteLine("Company              : " + user1.Company);
            Console.WriteLine("Job_role             : " + user1.Job_role);
            Console.WriteLine("Experience           : " + user1.Experience);
            
        }
    }
}
