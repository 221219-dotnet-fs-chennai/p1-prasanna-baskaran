using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public interface IExperienceRepo<C>
    {
        C Add(C t);
        List<C> GetExperience();
        C RemoveExperience(int t);
        C UpdateExperience(C t);
        IEnumerable<C> Get(int t);
    }
}
