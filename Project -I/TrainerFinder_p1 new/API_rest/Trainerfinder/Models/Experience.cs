using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Experience
    {   public int? UserId { get; set; }

        public int Companyid { get; set; }

        public string? Company { get; set; }

        public string? JobRole { get; set; }

        public string? Experience1 { get; set; }

        public override string ToString()
        {
            Log.Logger.Information("Experience.cs--line->24");
            return $"{UserId},{Companyid} ,{Company},{JobRole},{Experience1}";
        }
    }
}
