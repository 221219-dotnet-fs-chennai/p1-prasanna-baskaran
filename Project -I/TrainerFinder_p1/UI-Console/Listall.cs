using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLogic;
using DataRepo;

namespace TrainerFinder_p1
{
    internal class Listall : IMenu
    {
        static string constrr = "Server=tcp:associateserver.database.windows.net,1433;Initial Catalog=AssociatesDb;Persist Security Info=False;User ID=associate;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        IRepo repo = new SqlRepo(constrr);
        public void Display()
        {
            Log.Logger.Information("Listall.cs at line 16 ");

            System.Console.WriteLine("[0] Back");
            System.Console.WriteLine("[1] User_Menu");


        }

        public string UserChoice()
        {
            Log.Logger.Information("Listall.cs at line 26 ");
            System.Console.Write("Enter your choice: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "Menu";
                case "1":
                    Console.WriteLine("Username     gender      email       location    aboutme     phoneno     website     skills      certifications      SSLC    SSC     UG      PG       Company       job_role      experience");
                    Log.Information("Getting all trainers");
                    var listOfTrainers = repo.GetAllUser();
                    Log.Information($"Got list of {listOfTrainers.Count} Trainers");
                    Log.Information("Reading Trainers about to start");
                    foreach (var r in listOfTrainers)
                    { Console.WriteLine(r.GetDetails()); }
                    Log.Information(" print trainers List");
                    Console.WriteLine(" Enter to continue");
                    Console.ReadLine();
                    return "GetAvailableTrainers";

                default:
                    Console.WriteLine("Try again...");
                    Console.WriteLine("Enter to Continue...");
                    Console.ReadLine();
                    return "GetAvailableTrainers";

            }
        }
    }
}
