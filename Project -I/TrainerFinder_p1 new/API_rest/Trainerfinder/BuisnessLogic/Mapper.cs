using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class Mapper
    {
        public static Models.Users Map(Trainerfinder.Entities.User U)
        {
            Log.Logger.Information("Mapper.cs--line->15");
            return new Models.Users()
            {

                UserId = U.UserId,
                Username = U.Username,
                Gender = U.Gender,
                Email = U.Email,
                Pasword = U.Pasword,
                Location = U.Location,
                Aboutme = U.Aboutme,
                Phoneno = U.Phoneno,
                Website = U.Website
            };
            

        }
        public static Trainerfinder.Entities.User Map(Models.Users U)
        {
            Log.Logger.Information("Mapper.cs--line->31");
            return new Trainerfinder.Entities.User()
            {
                UserId = U.UserId,
                Username = U.Username,
                Gender = U.Gender,
                Email = U.Email,
                Pasword = U.Pasword,
                Location = U.Location,
                Aboutme = U.Aboutme,
                Phoneno = U.Phoneno,
                Website = U.Website
            };
        }

        public static IEnumerable<Models.Users> Map(IEnumerable<Trainerfinder.Entities.User> Users)
        {
            Log.Logger.Information("Mapper.cs--line->48");
            return Users.Select(Map);
        }
        public static Models.Education Map(Trainerfinder.Entities.Education ed)
        {
            Log.Logger.Information("Mapper.cs--line->53");
            return new Models.Education()
            {
                Educationid = ed.Educationid,
                UserId = ed.UserId,
                Sslc = ed.Sslc,
                Ssc = ed.Ssc,
                Ug= ed.Ug,
                Pg= ed.Pg,
            };
        }
        public static Trainerfinder.Entities.Education Map(Models.Education ed)
        {
            Log.Logger.Information("Mapper.cs--line->66");
            return new Trainerfinder.Entities.Education()
            {
               Educationid= ed.Educationid,
               UserId = ed.UserId,
               Sslc = ed.Sslc,
               Ssc = ed.Ssc,
               Ug= ed.Ug,
               Pg= ed.Pg,
            };
        }
        public static IEnumerable<Models.Education> Map(IEnumerable<Trainerfinder.Entities.Education> education)
        {
            Log.Logger.Information("Mapper.cs--line->79");
            return education.Select(Map);
        }
        public static Models.Experience Map(Trainerfinder.Entities.Experience com)
        {
            Log.Logger.Information("Mapper.cs--line->84");
            return new Models.Experience()
            {
               UserId = com.UserId,
               Companyid = com.Companyid,
               Company=com.Company,
               JobRole=com.JobRole,
               Experience1 = com.Experience1,
            };
        }
        public static Trainerfinder.Entities.Experience Map(Models.Experience com)
        {
            Log.Logger.Information("Mapper.cs--line->96");
            return new Trainerfinder.Entities.Experience()
            {
                UserId= com.UserId,
                Companyid= com.Companyid,
                Company=com.Company,
                JobRole=com.JobRole,
                Experience1 = com.Experience1,

            };
        }
        public static IEnumerable<Models.Experience> Map(IEnumerable<Trainerfinder.Entities.Experience> company)
        {
            Log.Logger.Information("Mapper.cs--line->109");
            return company.Select(Map);
        }
        public static Trainerfinder.Entities.Skill Map(Models.Skill sk)
        {
            Log.Logger.Information("Mapper.cs--line->115");
            return new Trainerfinder.Entities.Skill()
            {
                Skillid= sk.Skillid,
                Skills= sk.Skills,
                UserId= sk.UserId,
                Certification= sk.Certification,
            };
        }
        public static Models.Skill Map(Trainerfinder.Entities.Skill sk)
        {
            Log.Logger.Information("Mapper.cs--line->125");
            return new Models.Skill()
            {
                Skillid= sk.Skillid,
                Skills= sk.Skills,
                UserId= sk.UserId,
                Certification= sk.Certification,

            };
        }
        public static IEnumerable<Models.Skill> Map(IEnumerable<Trainerfinder.Entities.Skill> skills)
        {
            Log.Logger.Information("Mapper.cs--line->137");
            return skills.Select(Map);
        }
    }
}
