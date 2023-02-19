using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public interface IEducationRepo<E>
    {
        E Add(E t);
        List<E> GetEducationDetails();
        E RemoveEducation(int t);
        E UpdateEducationDetails(E t);
        IEnumerable<E> Get(int t);
    }

}
