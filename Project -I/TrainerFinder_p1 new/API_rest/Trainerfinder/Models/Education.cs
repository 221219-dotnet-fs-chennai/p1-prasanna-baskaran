using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Education
    {
        public int Educationid { get; set; }

        public int? UserId { get; set; }

        public string? Sslc { get; set; }

        public string? Ssc { get; set; }

        public string? Ug { get; set; }

        public string? Pg { get; set; }

        public override string ToString()
        {
            Log.Logger.Information("Education.cs--line->26");
            return $"{Educationid},{UserId},{Sslc} {Ssc},{Ug},{Pg}";
        }
    }
}
