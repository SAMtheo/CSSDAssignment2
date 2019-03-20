using System;
using System.Collections.Generic;
using System.IO;

namespace EVotingSystem
{
    /// <summary>
    /// Singleton object that processes votes, and updates the "database" with the results
    /// </summary>
    static public class VoteStorageV2
    {

        /// <summary>
        /// Vote method that takes the name of the candidateName as a parameter, and increments the candidateName's vote count in the database by 1.
        /// This ensures that all votes are anonymous.
        /// </summary>
        /// <param name="electionName">The name of the current election</param>
        /// <param name="candidates">The candidates of the current election</param>
        /// <param name="selectedCandidateName">Selected candidate of the current election</param>
        static public void Vote (string electionName, List<Candidate> candidates, string selectedCandidateName)
        {
            string elecFile = "elections.votes";
            Vote(elecFile, electionName, candidates, selectedCandidateName);
        }

        /// <summary>
        /// RUN FOR TESTS ONLY - Allows file input for the vote overload above
        /// </summary>
        /// <param name="elecFile">The required file to write to for elections</param>
        /// <param name="electionName">The name of the current election</param>
        /// <param name="candidates">The candidates of the current election</param>
        /// <param name="selectedCandidateName">Selected candidate of the current election</param>
        static public void Vote(string elecFile, string electionName, List<Candidate> candidates , string selectedCandidateName)
        {
            List<String> fileContents = new List<string>();

            if (File.Exists(elecFile)) {
                // see if this election exists on the file
                // get any existing values from the file
                using (StreamReader read = new StreamReader(elecFile))
                {
                    String currentLine = read.ReadLine();
                    bool incomplete = true;

                    while (currentLine != null)
                    {
                        if (currentLine == electionName)
                        {
                            fileContents.Add(currentLine);

                            currentLine = read.ReadLine();
                            string[] electionCandidates = currentLine.Split(',');
                            List<String> newElectionCandidates = new List<string>();
                            foreach (string candidate in electionCandidates)
                            {

                                String[] candidateVotePair = candidate.Split(':');
                                // if this isn't true Something went very wrong,
                                // i.e. someone modified the voting file
                                if (candidateVotePair.Length != 2)
                                {
                                    throw new Exception();
                                }

                                int vote = int.Parse(candidateVotePair[1]);

                                // Add in our new vote
                                if (candidateVotePair[0].Equals(selectedCandidateName))
                                {
                                    vote += 1;
                                }

                                newElectionCandidates.Add(candidateVotePair[0] + ":" + vote);
                            }

                            string newResults = string.Join(",", newElectionCandidates.ToArray());

                            fileContents.Add(newResults);
                            currentLine = read.ReadLine();
                            incomplete = false;
                        }
                        else
                        {
                            fileContents.Add(currentLine);
                            currentLine = read.ReadLine();
                        }
                    }

                    if (incomplete)
                    {
                        fileContents = createNewElectionInFile(fileContents, electionName, candidates, selectedCandidateName);
                    }
                }
            }
            else
            {
                fileContents = createNewElectionInFile(fileContents, electionName, candidates, selectedCandidateName);
            }

            // write back to file
            File.WriteAllLines(elecFile, fileContents.ToArray());
        }

        /// <summary>
        /// Accessable for TESTING only
        /// Creates a new election in the file storage context
        /// </summary>
        /// <param name="fileContents">Contents of the "file"</param>
        /// <param name="electionName">Name of the current election</param>
        /// <param name="candidates">List of candidates from the current election</param>
        /// <param name="selectedCandidateName">Selected candidate of the current election</param>
        /// <returns></returns>
        public static List<string> createNewElectionInFile(List<string> fileContents, 
            string electionName, List<Candidate> candidates, string selectedCandidateName)
        {
            fileContents.Add(electionName);

            List<string> candidateVotes = new List<string>();
            foreach (Candidate candidate in candidates)
            {
                if (candidate.name.Equals(selectedCandidateName))
                {
                    candidateVotes.Add(candidate.name + ":1");
                }
                else
                {
                    candidateVotes.Add(candidate.name + ":0");
                }
            }

            fileContents.Add(string.Join(",", candidateVotes));
            return fileContents;
        }
    }
}