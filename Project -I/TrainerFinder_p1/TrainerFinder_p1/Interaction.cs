using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainerFinder_p1
{
    internal class Interaction : IMenu
    {
        UserDetails trainerProfile = new UserDetails();
        static string conStr = "Server=tcp:prasanna-db-server.database.windows.net,1433;Initial Catalog=Trainerfind;User ID=prasannaadmin;Password=Amma@621218;";
        IRepo repo = new SqlRepo(conStr);
        public Interaction(UserDetails trainer)
        {
            trainerProfile = trainer;
            Console.WriteLine(trainerProfile.ToString());
        }
        public void Display()
        {
            Console.WriteLine($"Welcome ****************{trainerProfile.Username}************ :)");
            Console.WriteLine("[0] Back");
            Console.WriteLine("[1] View trainer/User Profile");
        }

        public string UserChoice()
        {
            Console.Write("\nEnter your choice: ");
            string userChoice = System.Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "Login";
                case "1":
                    Showprofile();
                   
                   Console.WriteLine("Press Enter to continue...");
                   Console.ReadLine();
                    return "UserInteraction";
                default:
                    Console.WriteLine("try again......");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return "UserInteraction";
            }
        }
        public void Showprofile()
        {
            Console.Clear();
            Console.WriteLine("Full_name            : " + trainerProfile.Username);
            Console.WriteLine("Gender               : " + trainerProfile.Gender);
            Console.WriteLine("Email                : " + trainerProfile.Email);
            Console.WriteLine("Password             : " + trainerProfile.Password);
            Console.WriteLine("Phone number         : " + trainerProfile.Location);
            Console.WriteLine("Phone number         : " + trainerProfile.Aboutme);
            Console.WriteLine("Phone number         : " + trainerProfile.PhoneNo);
            Console.WriteLine("Website              : " + trainerProfile.Website);
        }
    }
}
