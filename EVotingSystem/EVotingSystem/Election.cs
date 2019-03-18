using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EVotingSystem
{
    /// <summary>
    /// The class for representing the elections within our voting system
    /// </summary>
    public class Election
    {
        // This is the name of the this election.
        // immutable following post-construction
        public string electionName { get; private set; }
        // The voting area that this election is running in
        public long votingArea { get; private set; }
        // List of candidates running in the election
        public List<Candidate> candidates { get; private set; }
        // The start date of the election
        public DateTime startDate { get; private set; }
        // The end date of the election
        public DateTime endDate { get; private set; }

        /// <summary>
        /// An election is the process of voting between, at least two, candidates,
        /// occuring in a given location,
        /// between two dates/times.
        /// </summary>
        /// <param name="electionName">The name of the election</param>
        /// <param name="votingArea">The area code for an election</param>
        /// <param name="candidates">The list of candidates for an election</param>
        /// <param name="startDate">The start date of the election</param>
        /// <param name="endDate">The end date of the election</param>
        public Election(string electionName, long votingArea,
            List<Candidate> candidates, DateTime startDate, DateTime endDate)
        {
            this.electionName = electionName;
            this.votingArea = votingArea;
            this.candidates = candidates;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        /// <summary>
        /// Saves the vote for a chosen candidate,
        /// provided that the vote is being done within the valid voting period
        /// </summary>
        /// <param name="chosenVote">The candidate chosen by the voter in this election</param>
        /// <returns>The success of the vote being sent</returns>
        public bool vote(Candidate chosenVote) {
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

        /// <summary>
        /// Validates that the current time is within the valid voting period of this election
        /// </summary>
        /// <returns>Whether or not the current time is within the voting period</returns>
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

    /// <summary>
    /// Represents candidates in our elections
    /// </summary>
    public class Candidate
    {
        // The name of the candidate
        public string name { get; private set; }
        // The party the candidate belongs to
        public string party { get; private set; }
        // Photo of the candidate used on UI (Currently unused)
        public Bitmap photo { get; private set; }

        /// <summary>
        /// A candidate is represented by their name, party
        /// and (unused) photo within the voting system
        /// </summary>
        /// <param name="name">The name of the candidate</param>
        /// <param name="party">The party the candidate represents</param>
        /// <param name="photoFilePath">
        /// The filepath for the candidates photo,
        /// converted to an actual photo in the constructor
        /// </param>
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
