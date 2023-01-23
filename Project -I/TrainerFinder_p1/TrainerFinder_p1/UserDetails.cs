using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerFinder_p1
{
    public class UserDetails
    {
        public UserDetails() { }
        public int user_id { get; set; }
        public String Username { get;set; }
        public String Gender { get;set; }
        public String Email { get;set; } 
        public String Password { get;set; }
        public String Location { get;set; }
        public String Aboutme { get; set; }
        public String PhoneNo { get;set; }
        
        public String Website { get;set; }
        public int Skillid { get; set; }
        public String Skills { get; set; }
        public String Certifications { get; set; }
        public int EducationId { get; set; }
        public String Sslc { get; set; }
        public String Ssc { get; set; }
        public String Ug { get; set; }
        public String Pg { get; set; }

        public int Companyid { get; set; }
        public String Company { get; set; }
        public String Job_role { get; set; }
        public int Experience { get; set; }
        public string GetDetails()
        {
            Log.Logger.Information("UserDetails.cs at line 37 ");
            //Console.WriteLine("Username      grnder      email    location     aboutme     phoneno        website");
            return $@"{Username},--- {Gender},--- {Email},--- {Location},--- {Aboutme},--- {PhoneNo},--- {Website},{Skillid},{Skills},{Certifications},{EducationId},{Sslc},{Ssc},{Ug},{Pg},{Companyid},{Company},{Job_role},{Experience}\n";
        }
    }
}
