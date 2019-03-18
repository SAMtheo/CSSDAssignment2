using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    /// <summary>
    /// Singleton object that processes votes, and updates the "database" with the results
    /// </summary>
    static public class VoteStorage
    {
        /// <summary>
        /// Vote method that takes the name of the candidateName as a parameter, and increments the candidateName's vote count in the database by 1.
        /// This ensures that all votes are anonymous.
        /// </summary>
        /// <param name="candidateName">String representation of candidate name.</param>
        static public void Vote(string candidateName){            
            string elecFile = "election.votes";
            Dictionary<string, int> votes = new Dictionary<string, int>();
            FileStream F = new FileStream(elecFile, FileMode.OpenOrCreate, FileAccess.Read);
            F.Close();

            using (StreamReader sr = new StreamReader(elecFile))
            {
                Task<string> fileContents = sr.ReadToEndAsync();

                string f = fileContents.Result;

                //create a list of candidateName:votes pairs
                string[] elections = f.Split(',');

                
                string[] elecPair = new string[2];
                //read in all existing values
                foreach (string s in elections)
                {
                    //should always return a pair, but .Split returns a []
                    elecPair = s.Split(':');

                    if (elecPair.Length != 2)
                    {
                        throw new Exception();
                    }
                    //covert string val to number
                    int votesNum = Convert.ToInt32(elecPair[1]);

                    //and add them to our dictionary
                    votes.Add(elecPair[0], votesNum);

                }

                //increment the votes for the passed candidateName
                votes[candidateName]++;
            }
                //..and write it all back out 
                try
                {
                    using (StreamWriter s = new StreamWriter(elecFile, false))
                    {
                    bool isFirst = true;
                        foreach (KeyValuePair<string, int> k in votes)
                        {
                        string newRes = "";
                        if (isFirst)
                        {
                            newRes = k.Key + ":" + k.Value;
                            isFirst = false;
                        } else
                        {
                            newRes = "," + k.Key + ":" + k.Value;
                        }
                            s.Write(newRes);
                        }
                    }
                } catch (Exception e) {
                    throw e;
                }
        }     
    }
}