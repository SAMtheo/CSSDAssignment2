using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    static class VoteStorage
    {

        static public void Vote(string candidate){
            //For this use case, election.vote must be pre-created
            //cand:20,cand2:30,

            string elecFile = "election.votes";
            Dictionary<string, int> votes = new Dictionary<string, int>();
            FileStream F = new FileStream(elecFile, FileMode.OpenOrCreate, FileAccess.Read);
            F.Close();

            //open stream reader to 
            using (StreamReader sr = new StreamReader(elecFile))
            {
                Task<string> fileContents = sr.ReadToEndAsync();

                string f = fileContents.Result;

                //create a list of candidate:votes pairs
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

                //increment the votes for the passed candidate
                votes[candidate]++;
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