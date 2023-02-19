using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public interface IRepo<T>
    {
        T Add(T t);
        List<T> GetUserDetails();
        T RemoveUserDetails(string Email);
        T UpdateUserDetails(T t);
        T Get(string Email);
        
    }
}
