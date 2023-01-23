using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainerFinder_p1
{
    internal class SIgnUp:IMenu
    {

            internal static UserDetails details = new UserDetails();

            public SIgnUp(UserDetails trainer)
            {
                details = trainer;
            }
            public SIgnUp()
            {

            }



        static string connStrr = "Server=tcp:prasanna-db1.database.windows.net,1433;Initial Catalog=TrainerFinder;User ID=prasannaadmin;Password=Amma@621218;";

        IRepo repo = new SqlRepo(connStrr);

            public void Display()
            {
                Console.WriteLine("\n********Greetings to Signup Menu********\n");
                Console.WriteLine("[0] Menu");
                Console.WriteLine("[1] Save");
                Console.WriteLine("[2] Username    : " + details.Username);
                Console.WriteLine("[3] Gender      : " + details.Gender);
                Console.WriteLine("[4] Email       : " + details.Email);
                Console.WriteLine("[5] Password    : " + details.Password);
                Console.WriteLine("[6] Location    : " + details.Location);
                Console.WriteLine("[7] About Me    : " + details.Aboutme);
                Console.WriteLine("[8] Phone number: " + details.PhoneNo);
                Console.WriteLine("[9] Website     : " + details.Website);
                Console.WriteLine("[10] Skills     : " + details.Skills);
                Console.WriteLine("[11] Certifications     : " + details.Certifications);
                Console.WriteLine("[12] Sslc     : " + details.Sslc);
                Console.WriteLine("[13] Ssc     : " + details.Ssc);
                Console.WriteLine("[14] Ug     : " + details.Ug);
                Console.WriteLine("[15] Pg     : " + details.Pg);
                Console.WriteLine("[16] Company     : " + details.Company);
                Console.WriteLine("[17] Job Role      : " + details.Job_role);
                Console.WriteLine("[18] Experience     : " + details.Experience);


        }
            public string UserChoice()
            {
               
                System.Console.Write("\nEnter your choice: ");
                string choice3 = Console.ReadLine();

                switch (choice3)
                {
                    case "0":
                        return "Menu";

                    case "1":
                        try
                        {
                            Log.Logger.Information("Adding trainer details");
                            repo.Add(details);
                            details = new UserDetails();
                            System.Console.WriteLine("Successfully added");
                            Log.Logger.Information("Successfully added trainer");
                        }
                        catch (System.Exception ex)
                        {
                            Log.Logger.Information($"Failed to add details {ex.Message}");
                            Console.WriteLine(ex.Message);
                            System.Console.WriteLine("Press Enter to continue");
                            System.Console.ReadLine();
                        }
                        return "AddTrainer";
                    case "4":
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
                        return "Signup";
                    case "5":
                        System.Console.Write("Enter your Password: ");
                        string pattern1 = @"";

                        string password = System.Console.ReadLine();

                        if (password!="")
                        {
                            details.Password = password;
                        }
                        else
                        {
                            System.Console.WriteLine(" try again...");
                            System.Console.ReadLine();
                        }
                        return "Signup";


                    case "2":
                        System.Console.Write("Enter your Username: ");
                        details.Username = Console.ReadLine();
                    return "Signup";


                    case "3":
                        System.Console.Write("Enter your Gender: ");
                        details.Gender = Console.ReadLine();
                        return "Signup";

                    case "8":
                        System.Console.Write("Enter your Mobile number: ");
                     

                        string phone_number = Console.ReadLine();

                        if (phone_number!="")
                        {
                            details.PhoneNo = phone_number;
                        }
                        else
                        {
                            System.Console.WriteLine("Wrong pattern try again...");
                            System.Console.ReadLine();
                        }
                        return "Signup";

                    
                case "6":
                    System.Console.Write("Location ");
                    details.Location = System.Console.ReadLine();
                    return "Signup";
                case "7":
                    System.Console.Write("About Me ");
                    details.Aboutme = System.Console.ReadLine();
                    return "Signup";
                case "9":
                    System.Console.Write("Enter you Website: ");
                    details.Website = System.Console.ReadLine();
                    return "Signup";
                case "10":
                    System.Console.Write("Enter you Skills: ");
                    details.Skills = System.Console.ReadLine();
                    return "Signup";
                case "11":
                    System.Console.Write("Enter you Certifications: ");
                    details.Certifications = System.Console.ReadLine();
                    return "Signup";
                case "12":
                    System.Console.Write("Enter you SSLC %: ");
                    details.Sslc =  System.Console.ReadLine();
                    return "Signup";
                case "13":
                    System.Console.Write("Enter you SSC % : ");
                    details.Ssc = System.Console.ReadLine();
                    return "Signup";
                case "14":
                    System.Console.Write("Enter you UG %: ");
                    details.Ug = System.Console.ReadLine();
                    return "Signup";
                case "15":
                    System.Console.Write("Enter you PG %: ");
                    details.Pg = System.Console.ReadLine();
                    return "Signup";
                case "16":
                    System.Console.Write("Enter you Company: ");
                    details.Company = System.Console.ReadLine();
                    return "Signup";
                case "17":
                    System.Console.Write("Enter you Job role: ");
                    details.Job_role = System.Console.ReadLine();
                    return "Signup";
                case "18":
                    System.Console.Write("Enter you experience in years: ");
                    details.Experience = Convert.ToInt32(System.Console.ReadLine());
                    return "Signup";
                default:
                        
                        System.Console.WriteLine("Try again!........");
                        System.Console.WriteLine("Enter to continue");
                        System.Console.ReadLine();
                        return "Signup";

                }
            }
        }
    }

