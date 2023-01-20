using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrainerFinder_p1
{
    internal class UserUpdate : SIgnUp, IMenu
    {
        static string connStrr = "Server=tcp:prasanna-db-server.database.windows.net,1433;Initial Catalog=Trainerfind;User ID=prasannaadmin;Password=Amma@621218;";
        IRepo repo = new SqlRepo(connStrr);
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("[0] Back");
            Console.WriteLine("[1] User name            : " + details.Username);
            Console.WriteLine("[2] Gender              : " + details.Gender);
            Console.WriteLine("[3] Email            : " + details.Email);
            Console.WriteLine("[4] Password            : " + details.Password);
            Console.WriteLine("[5] Location            : " + details.Location);
            Console.WriteLine("[6] About me            : " + details.Aboutme);
            Console.WriteLine("[7] Phone number        : " + details.PhoneNo);
            Console.WriteLine("[8] Website             : " + details.Website);
        }
        public string UserChoice()
        {
            System.Console.Write("\nEnter your choice: ");
            string userchoice = System.Console.ReadLine();

            switch (userchoice)
            {
                case "0":
                    return "Login";
                case "4":
                    System.Console.Write("Enter your Password to update: ");
                    string pattern1 = @"";

                    string password = Console.ReadLine();

                    if (password!="")
                    {
                        details.Password = password;
                    }
                    else
                    {
                        Console.WriteLine("Wrong pattern try again...");
                        Console.ReadLine();
                    }
                    repo.UpdateTrainer("Trainer_Detailes", "Password", details.Password, details.user_id);
                    return "TrainerUpdate";
                case "1":
                    Console.Write("Enter your Fullname to update: ");
                    details.Username = Console.ReadLine();
                    repo.UpdateTrainer("Trainer_Detailes", "Full_name", details.Username, details.user_id);
                    return "TrainerUpdate";
                case "2":
                    System.Console.Write("Enter your Gender: ");
                    details.Gender = Console.ReadLine();
                    repo.UpdateTrainer("Trainer_Detailes", "Gender", details.Gender, details.user_id);
                    return "TrainerUpdate";

                case "7":
                    System.Console.Write("Enter your Mobile number to update: ");
                    string pattern = @"^(?:(?:\+|00)91|0)[7-9][0-9]{9}$";

                    string phone_number = Console.ReadLine();

                    if (Regex.IsMatch(phone_number, pattern))
                    {
                        details.PhoneNo = phone_number;
                    }
                    else
                    {
                        System.Console.WriteLine("Wrong pattern try again...");
                        System.Console.ReadLine();
                    }
                    repo.UpdateTrainer("Trainer_Detailes", "Mobile_number", details.PhoneNo, details.user_id);
                    return "TrainerUpdate";
                case "3":
                    System.Console.Write("Enter your Email: ");
                    string patternn = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

                    string Email = Console.ReadLine();

                    if (Regex.IsMatch(Email, patternn))
                    {
                        details.Email = Email;
                    }
                    else
                    {
                        System.Console.WriteLine("Wrong pattern try again...");
                        System.Console.ReadLine();
                    }
                    return "Signup";


            }
            return "Hello";

        }
    }
}
