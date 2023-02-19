using Serilog;
using System.Reflection;

namespace Models
{
    public class Skill
    {
        public int Skillid { get; set; }

        public string? Skills { get; set; }

        public int? UserId { get; set; }

        public string? Certification { get; set; }
        public override string ToString()
        {
            Log.Logger.Information("Skill.cs--line->17");
            return $"{Skillid},{Skills},{UserId} {Certification}";
        }

    }
}