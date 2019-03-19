using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    /// <summary>
    /// Base class for registered users
    /// </summary>
    public abstract class User
    {
        /// <value>Maximum failed login attempts</value>
        private static readonly int MAX_ATTEMPTS = 3;
        private string username;
        private string hashedPassword;
        private int authAttempts;

        /// <summary>
        /// Each user has a username and password
        /// </summary>
        /// <param name="username">unique username</param>
        /// <param name="password">hashed password</param>
        public User(string username, string password)
        {
            this.username = username;
            this.hashedPassword = password;
            this.authAttempts = 0;
        }

        /// <summary>
        /// Getter for username 
        /// </summary>
        /// <returns></returns>
        public string getUsername()
        {
            return username;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Hahsed password</returns>
        public string getHashedPassword()
        {
            return hashedPassword;
        }

        /// <summary>
        /// Returns number of failed login attempts
        /// </summary>
        /// <returns></returns>
        public int getAuthAttempts()
        {
            return authAttempts;
        }

        /// <summary>
        /// Sets authAttempts to 0 
        /// Letting that user fail to log in
        /// or login after failing too many times
        /// </summary>
        public void resetAuthAttempts()
        {
            authAttempts = 0;
        }

        /// <summary>
        /// Takes a password to compare 
        /// </summary>
        /// <param name="passwordToCheck">password from login field</param>
        /// <param name="message">contextual message to return for failed attempt</param>
        /// <returns>true if password is valid and auth attempts are less than MAX_ATTEMPTS</returns>
        public bool validatePassword(string passwordToCheck, ref string message)
        {
            if (checkAttempts()) {
                if (passwordToCheck.CompareTo(this.hashedPassword) == 0) {
                    resetAuthAttempts();
                    return true;
                } 
            } else {
                message = "Number of login attempts reached account locked: contact site admin";
            }
            authAttempts++;
            return false;
        }

        /// <summary>
        /// Check if the current users login attempts
        /// </summary>
        /// <returns>if the current attempts is less than maximum</returns>
        public bool checkAttempts()
        {
            return (authAttempts < MAX_ATTEMPTS);
        }
    }

    public class Voter : User
    {
        private bool isEligible;
        private string firstName;
        private string lastName;
        private DateTime dob;
        // TODO: Address
        public List<Election> elections = new List<Election>();
        
        /// <summary>
        /// Representation of a voter
        /// </summary>
        /// <param name="username">Unique username</param>
        /// <param name="password">hashed password</param>
        /// <param name="isEligible">If this voter is allowed to vote</param>
        /// <param name="firstName">Real first name</param>
        /// <param name="lastName">Real last name</param>
        /// <param name="dob">Date of birth</param>
        public Voter(string username, string password, bool isEligible, string firstName,
            string lastName, DateTime dob) :base(username, password)
        {
            this.isEligible = isEligible;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
        }

        /// <summary>
        /// Getter for eligibility
        /// </summary>
        /// <returns></returns>
        public bool getIsEligible()
        {
            return isEligible;
        }

        /// <summary>
        /// set a users eligibility 
        /// </summary>
        /// <param name="isEligible">boolean </param>
        public void setIsEligible(bool isEligible)
        {
            this.isEligible = isEligible;
        }

        /// <summary>
        /// Returns voter first name
        /// </summary>
        /// <returns></returns>
        public string getFirstname()
        {
            return firstName;
        }

        /// <summary>
        /// Returns voter last name
        /// </summary>
        /// <returns></returns>
        public string getLastname()
        {
            return lastName;
        }

        /// <summary>
        /// Returns voter date of birth
        /// </summary>
        /// <returns></returns>
        public DateTime getDob()
        {
            return dob;
        }
    }

    /// <summary>
    /// Derived Administrator user 
    /// </summary>
    public class Admin : User
    {
        bool isAdmin = true;
        /// <summary>
        /// Base constructor for the admin
        /// </summary>
        /// <param name="u">Unique username</param>
        /// <param name="p">hashed password</param>
        public Admin(string u, string p) : base(u,p)
        {

        }
    }
}
