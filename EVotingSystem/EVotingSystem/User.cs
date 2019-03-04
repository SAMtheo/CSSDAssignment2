﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    public abstract class User
    {
        private static readonly int MAX_ATTEMPTS = 3;
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

        // Takes a password to compare 
        // returns true if password is valid and auth attempts are less than MAX_ATTEMPTS
        public bool validatePassword(string passwordToCheck)
        {
            if(checkAttempts())
                if (passwordToCheck.CompareTo(this.hashedPassword) == 0)
                    return true;
            return false;
        }

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
