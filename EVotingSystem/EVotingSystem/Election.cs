using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EVotingSystem
{
    public class Election
    {
        public string electionName { get; private set; }
        public long votingArea { get; private set; }
        public List<Candidate> candidates { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }

        public Election(string electionName, long votingArea,
            List<Candidate> candidates, DateTime startDate, DateTime endDate)
        {
            this.electionName = electionName;
            this.votingArea = votingArea;
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
                    VoteStorage.Vote(chosenVote.name);
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

        // -- [TODO?] public bool validateVotingArea() { }
    }

    public class Candidate
    {
        public string name { get; private set; }
        public string party { get; private set; }
        public Bitmap photo { get; private set; } // Photo of the candidate used on UI

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
