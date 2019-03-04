using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    public abstract class User
    {
        private string username;
        private string hashedPassword;
        private int authAttempts;

        public User(string username, string password)
        {
            this.username = username;
            this.hashedPassword = password;
            this.authAttempts = 0;
        }

        public string getUsername()
        {
            return username;
        }

        public string getHashedPassword()
        {
            return hashedPassword;
        }

        public int getAuthAttempts()
        {
            return authAttempts;
        }

        public void resetAuthAttempts()
        {
            authAttempts = 0;
        }

    }

    public class Voter : User
    {
        private bool isEligible;
        private string firstName;
        private string lastName;
        private DateTime dob;
        // TODO: Address
        // TODO: List<Elections>
            
        public Voter(string username, string password, bool isEligible, string firstName,
            string lastName, DateTime dob) :base(username, password)
        {
            this.isEligible = isEligible;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
        }
    
        public bool getIsEligible()
        {
            return isEligible;
        }

        public void setIsEligible(bool isEligible)
        {
            this.isEligible = isEligible;
        }

        public string getFirstname()
        {
            return firstName;
        }

        public string getLastname()
        {
            return lastName;
        }

        public DateTime getDob()
        {
            return dob;
        }
    }
}
