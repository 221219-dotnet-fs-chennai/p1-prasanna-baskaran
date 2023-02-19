using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public interface ISkillRepo<S>
    {
        S Add(S t);
        List<S> GetSkills();
        S RemoveSkills(int t);
        S UpdateSkills(S t);
        IEnumerable<S> Get(int t);
    }
}
