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
        String electionName;
        List<Candidate> candidates;
        DateTime startDate;
        DateTime endDate;

        public Boolean voteChoice(Candidate chosenVote) {
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

        public Boolean validateVoteTime() {
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
        private String name;
        private String party;
        private Bitmap photo;

        public Candidate(String name, String party, String photoFilePath)
        {
            this.name = name;
            this.party = party;

            if (System.IO.File.Exists(photoFilePath))
            {
                photo = new Bitmap(photoFilePath);
            }
        }

        public String getName() {
            return name;
        }

        public String getParty()
        {
            return party;
        }

        public Bitmap getPicture()
        {
            return photo;
        }
    }
}
