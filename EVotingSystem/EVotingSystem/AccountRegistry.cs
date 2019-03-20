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

        // Takes a new user object and adds it to the collection unless there is a user with that username already
        // guarantees that usernames are unique
        public void AddUser(User newUser) 
        {
            if (INSTANCE.users.Exists(u => u.getUsername() == newUser.getUsername()) == false)
                INSTANCE.users.Add(newUser);
        }


    }
}
