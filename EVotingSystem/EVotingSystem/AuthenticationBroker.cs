using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{

    public class Session
    {
        public User currentUser;
        private string logInMessage;

        public Session (User user)
        {
            currentUser = user;
        }

        public Session(User user, string message)
        {
            currentUser = user;
            this.logInMessage = message;
        }
        
        public string getLogInMessage()
        {
            return logInMessage;
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
            string message = "";
            accountRegistryInstance = AccountRegistry.Instance;
            User user = findUser(accountRegistryInstance, username);

            if (user != null)
            {
                if (user.validatePassword(password, ref message))
                {
                    return new Session(user);
                }
            }
            if(message == "")
                message = "Username or password incorrect";

            return new Session(null, message);
        }
        
        // return user with username from accountRegistry
        public User findUser(AccountRegistry accountRegistry,string username)
        {
            return accountRegistryInstance.users.Find(x => x.getUsername().CompareTo(username) == 0);
        }

    }
}
