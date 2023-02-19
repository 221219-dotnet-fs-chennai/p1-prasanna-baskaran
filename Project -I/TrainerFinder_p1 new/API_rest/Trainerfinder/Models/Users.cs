using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Models
{
    public class Users
    {
        public int UserId { get; set; }

        public string? Username { get; set; } 

        public string?  Gender {
            get
            {
                return Gender;
            }
            set
            {
                if (Regex.IsMatch(value, @"male|MALE|Male|female|Female|FEMALE"))
                {
                    Gender = value;
                }
                else
                {
                    System.Console.WriteLine("Invalid Gender Format");
                    System.Console.ReadLine();
                }
            }
        }

        public string? Email
        {
            get
            {
                return Email;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
                {
                    Email = value;
                }
                else
                {
                    System.Console.WriteLine("Invalid Email Format");
                    System.Console.ReadLine();
                }
            }
        } 

        public string? Pasword
        {
            get
            {
                return Pasword;
            }
            set
            {
                if (Regex.IsMatch(value, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()])[A-Za-z\d!@#$%^&*()]{8,}$"))
                {
                    Pasword = value;
                }
                else
                {
                    System.Console.WriteLine("Weak Passwords not valid");
                    System.Console.ReadLine();
                }
            }
        } 
        

        public string? Location { get; set; } 

        public string? Aboutme { get; set; } 

        public string? Phoneno { get; set; }
      /*  {
            get
            {
                return Phoneno;
            }
            set
            {
                if (Regex.IsMatch(value, @"^(?:\+?91|0)?[ -]?[6789]\d{9}$"))
                {
                    Phoneno = value;
                }
                else
                {
                    System.Console.WriteLine("Phonenumber not valid");
                    System.Console.ReadLine();
                }
            }
        } */
        
        public string? Website {
            get
            {
                return Website;
            }
            set
            {
                if (Regex.IsMatch(value, @"^https?://(?:www\.)?([a-z0-9-]+)\.[a-z]{2,}(?:/[^\s]*)?$"))
                {
                    Website = value;
                }
                else
                {
                    System.Console.WriteLine("Website not valid");
                    System.Console.ReadLine();
                }
            }
        }
      
        public override string ToString()
        {
            Log.Logger.Information("Users.cs--line->122");
            return $"{UserId} {Username} {Gender} {Email} {Pasword} {Location} {Aboutme} {Phoneno} {Website}";
        }
    }
}
