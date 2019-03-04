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
        private string electionName { public get; private set; }
        private List<Candidate> candidates { public get; private set; }
        private DateTime startDate { public get; private set; }
        private DateTime endDate { public get; private set; }

        public Election(string electionName,
        {
            this.electionName = electionName;
            this.candidates = candidates;
            this.startDate = startDate;
            this.endDate = endDate;
        }

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
        private string name { public get; private set; }
        private string party { public get; private set; }
        private Bitmap photo { public get; private set; } // Photo of the candidate used on UI

        public Candidate(string name, string party, string photoFilePath)
        {
            this.name = name;
            this.party = party;

            if (System.IO.File.Exists(photoFilePath))
            {
                photo = new Bitmap(photoFilePath);
            }
        }
    }
}
