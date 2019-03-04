using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    public sealed class AccountRegistry
    {
        public List<User> users;
        private static readonly AccountRegistry INSTANCE = new AccountRegistry(new List<User>());

        private AccountRegistry(List<User> users)
        {
            this.users = users;
        }

        public static AccountRegistry Instance
        {
            get
            {
                return INSTANCE;
            }
        }

        public void AddUser(User newUser) 
        {
            INSTANCE.users.Add(newUser);
        }


    }
}
