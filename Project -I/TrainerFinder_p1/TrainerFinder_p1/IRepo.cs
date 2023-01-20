using System;
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
        
        UserDetails GetAllTrainer(string email);
        List<UserDetails> GetAllTrainersDisconnected();

        void UpdateTrainer(string tableName, string columnName, string newValue, int user_id);

        void DeleteTrainer(string eMail);
    }
}
