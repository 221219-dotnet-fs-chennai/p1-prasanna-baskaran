using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public interface ISkillLogic
    {
        Models.Skill AddSkills(string Email, Models.Skill skills);
        IEnumerable<Models.Skill> GetSkills();
        IEnumerable<Models.Skill> Get(string email);
        Models.Skill RemoveSkills(string r);
        Models.Skill UpdateSkills(string Email, Models.Skill r);

    }
}
