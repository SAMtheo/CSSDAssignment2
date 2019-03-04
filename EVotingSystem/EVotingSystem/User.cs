using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    public abstract class User
    {
        private string username { get; }
        private string hashedPassword { get; }
        private int authAttempts { get; set; }

        public User(string username, string password)
        {
            this.username = username;
            this.hashedPassword = password;
            this.authAttempts = 0;
        }
    }

    public class Voter : User
    {
        private bool isEligible { get; set; }
        private string firstName { get; }
        private string lastName { get; }
        private DateTime dob { get;  }
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
    
    
    }
}
