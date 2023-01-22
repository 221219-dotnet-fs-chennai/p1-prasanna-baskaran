﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerFinder_p1
{
    internal interface IRepo
    {
        UserDetails Add(UserDetails details);
        bool login(string email);
        
        UserDetails GetAllUser(string email);
        List<UserDetails> GetAllUser();

        void UpdateUser(string tableName, string columnName, string newValue, int user_id);

        void DeleteUser(string eMail);
    }
}
