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
        

        static string connStrr = "Server=tcp:prasanna-db1.database.windows.net,1433;Initial Catalog=TrainerFinder;User ID=prasannaadmin;Password=Amma@621218;";
        IRepo repo = new SqlRepo(connStrr);
        public void Display()
        {
            Log.Logger.Information("userupdate.cs at line 18 ");
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
            Console.WriteLine("[9] Skills             : " + details.Website);
            Console.WriteLine("[10] Certifications             : " + details.Website);
            Console.WriteLine("[11] SSLC %              : " + details.Website);
            Console.WriteLine("[12] SSC %             : " + details.Website);
            Console.WriteLine("[13] UG %             : " + details.Website);
            Console.WriteLine("[14] PG %             : " + details.Website);
            Console.WriteLine("[15] Company              : " + details.Website);
            Console.WriteLine("[16] Job Role             : " + details.Website);
            Console.WriteLine("[17] Experience             : " + details.Website);
        }
        public string UserChoice()
        {
            Log.Logger.Information("userupdate.cs at line 41 ");
            System.Console.Write("\nEnter your choice: ");
            string userchoice = Console.ReadLine();
            switch (userchoice)
            {
                case "0":
                    Log.Logger.Information("userupdate.cs at line 47 ");
                    return "Interaction";

                case "3":
                    System.Console.Write("Enter your Email: ");
                    string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

                    string Email = Console.ReadLine();

                    if (Regex.IsMatch(Email, pattern))
                    {
                        details.Email = Email;
                    }
                    else
                    {
                        System.Console.WriteLine(" try again...");
                        System.Console.ReadLine();
                    }
                    return "UserUpdate";
                case "4":
                    System.Console.Write("Enter your Password: ");
                    string pattern1 = @"";

                    string password = System.Console.ReadLine();

                    if (password != "")
                    {
                        details.Password = password;
                    }
                    else
                    {
                        System.Console.WriteLine(" try again...");
                        System.Console.ReadLine();
                    }
                    return "UserUpdate";


                case "1":
                    System.Console.Write("Enter your Username: ");
                    details.Username = Console.ReadLine();
                    return "UserUpdate";


                case "2":
                    System.Console.Write("Enter your Gender: ");
                    details.Gender = Console.ReadLine();
                    return "UserUpdate";

                case "7":
                    System.Console.Write("Enter your Mobile number: ");


                    string phone_number = Console.ReadLine();

                    if (phone_number != "")
                    {
                        details.PhoneNo = phone_number;
                    }
                    else
                    {
                        System.Console.WriteLine("Wrong pattern try again...");
                        System.Console.ReadLine();
                    }
                    return "UserUpdate";


                case "5":
                    System.Console.Write("Location ");
                    details.Location = System.Console.ReadLine();
                    return "UserUpdate";
                case "6":
                    System.Console.Write("About Me ");
                    details.Aboutme = System.Console.ReadLine();
                    return "UserUpdate";
                case "8":
                    System.Console.Write("Enter you Website: ");
                    details.Website = System.Console.ReadLine();
                    return "UserUpdate";
                case "9":
                    System.Console.Write("Enter you Skills: ");
                    details.Skills = System.Console.ReadLine();
                    return "UserUpdate";
                case "10":
                    System.Console.Write("Enter you Certifications: ");
                    details.Certifications = System.Console.ReadLine();
                    return "UserUpdate";
                case "11":
                    System.Console.Write("Enter you SSLC %: ");
                    details.Sslc = System.Console.ReadLine();
                    return "UserUpdate";
                case "12":
                    System.Console.Write("Enter you SSC % : ");
                    details.Ssc = System.Console.ReadLine();
                    return "UserUpdate";
                case "13":
                    System.Console.Write("Enter you UG %: ");
                    details.Ug = System.Console.ReadLine();
                    return "UserUpdate";
                case "14":
                    System.Console.Write("Enter you PG %: ");
                    details.Pg = System.Console.ReadLine();
                    return "UserUpdate";
                case "15":
                    System.Console.Write("Enter you Company: ");
                    details.Company = System.Console.ReadLine();
                    return "UserUpdate";
                case "16":
                    System.Console.Write("Enter you Job role: ");
                    details.Job_role = System.Console.ReadLine();
                    return "UserUpdate";
                case "17":
                    System.Console.Write("Enter you experience in years: ");
                    details.Experience = Convert.ToInt32(System.Console.ReadLine());
                    return "UserUpdate";
                default:
                    System.Console.WriteLine("------------------------------");
                    System.Console.WriteLine("Wrong choice, Try again!");
                    System.Console.WriteLine("Enter to continue");
                    System.Console.ReadLine();
                    return "UserUpdate";
            }
            return "Showuser";

        }
    }
}
