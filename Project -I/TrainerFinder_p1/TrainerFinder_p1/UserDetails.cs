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

        public  string ToString()
        {
            return $@"{Username},{Gender},{Email}, {Password},{Location},{Aboutme}, {PhoneNo}, {Website}";
        }
    }
}
