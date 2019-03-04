using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EVotingSystem
{
    class Election
    {
        string electionName;
        List<Candidate> candidates;
        DateTime startDate;
        DateTime endDate;

        public bool vote(Candidate chosenVote) {
            // [TODO] Implement user voting for a candidate
            if (validateVoteTime())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validateVoteTime() {
            DateTime now = DateTime.Now;
            if ((now.CompareTo(startDate) >= 0) && (now.CompareTo(endDate) <= 0)) {
                return true;
            } else {
                return false;
            }
        }
    }

    class Candidate
    {
        private string name;
        private string party;

        public Candidate(string name, string party, string photoFilePath)
        {
            this.name = name;
            this.party = party;

            if (System.IO.File.Exists(photoFilePath))
            {
                photo = new Bitmap(photoFilePath);
            }
        }

        public string getName() {
            return name;
        }

        public string getParty()
        {
            return party;
        }

        public Bitmap getPicture()
        {
            return photo;
        }
    }
}
