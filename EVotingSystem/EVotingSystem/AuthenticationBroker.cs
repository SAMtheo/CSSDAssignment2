using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    /// <summary>
    /// Holds the context for the logged in user
    /// </summary>
    public class Session
    {
        public User currentUser;
        private string logInMessage;

        /// <summary>
        /// Base constructor for the authenticated user
        /// </summary>
        /// <param name="user">Authenticated user</param>
        public Session (User user)
        {
            currentUser = user;
        }

        /// <summary>
        /// Extra constructor with a contextual message
        /// </summary>
        /// <param name="user">Authenticated user</param>
        /// <param name="message">Contextual message to display</param>
        public Session(User user, string message)
        {
            currentUser = user;
            this.logInMessage = message;
        }
        
        /// <summary>
        /// Getter for contextual message
        /// </summary>
        /// <returns></returns>
        public string getLogInMessage()
        {
            return logInMessage;
        }
    }
    
    public class AuthenticationBroker
    {
        public AuthenticationBroker () { }

        /// <summary>
        /// Takes username and hashed password
        /// returns new Session for user
        /// </summary>
        /// <param name="username">username for user to log in</param>
        /// <param name="password">hashed password for user</param>
        /// <returns>User session</returns>
        public Session authenticate(string username, string password)
        {
            string message = "";
            AccountRegistry accountRegistryInstance = AccountRegistry.Instance;
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

        /// <summary>
        /// return user with username from accountRegistry
        /// </summary>
        /// <param name="accountRegistry">Account registry instance</param>
        /// <param name="username">username to search for</param>
        /// <returns>User in account registry with given username</returns>
        public User findUser(AccountRegistry accountRegistry,string username)
        {
            return accountRegistry.users.Find(x => x.getUsername().CompareTo(username) == 0);
        }

    }
}
