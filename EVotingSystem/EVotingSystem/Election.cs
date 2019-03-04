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

        /*
         * voteChance - Chooses a vote to chosen candidate
         * 
         * Params:
         * Candidate chosenVote - The users chosen candidate
         * 
         * returns bool - vote registered
         */
        public bool vote(Candidate chosenVote) {
            // [TODO] Implement user voting for a candidate
                if (validateVoteTime())
                {
                    //Storage.vote(candidate.name)
                    return true;
                }
                else
                {
                    return false;
                }
        }

        /*
         * validateVoteTime - Validates that the current time is still a valid voting time for this election
         * 
         * returns bool - if still valid voting time
         */
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
        private Bitmap photo; // Photo of the candidate used on UI

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
