using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{

    class Session
    {
        User currentUser;
        
        public Session (User user)
        {
            currentUser = user;
        }
    }
    
    class AuthenticationBroker
    {
        AccountRegistry accountRegistryInstance;
        public AuthenticationBroker () { }

        // Takes username and hashed password
        // returns new Session for user
        public Session authenticate(string username, string password)
        {
            accountRegistryInstance = AccountRegistry.Instance;
            User user = findUser(accountRegistryInstance, username);
            if(user != null) { 
                if(user.validatePassword(password)) {
                    return new Session(user);
                }
            }
            return null;
        }
        
        // return user with username from accountRegistry
        public User findUser(AccountRegistry accountRegistry,string username)
        {
            return accountRegistryInstance.users.Find(x => x.getUsername().CompareTo(username) == 0);
        }

    }
}
