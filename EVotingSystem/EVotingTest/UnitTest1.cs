using EVotingSystem;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EVotingSystem.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        string elecFile = "electionTest.votes";
        Dictionary<string, int> votes = new Dictionary<string, int>();

        private void Init()
        {
            //new file
            //new election
            
            FileStream F = new FileStream(elecFile, FileMode.OpenOrCreate, FileAccess.Read);
            F.Close();
            

            try
            {
                using (StreamWriter s = new StreamWriter(elecFile, false))
                {
                    bool isFirst = true;
                    
                    votes.Add("Test", 0);
                    votes.Add("Test2", 2);

                    foreach (KeyValuePair<string, int> k in votes)
                    {
                        string newRes = "";
                        if (isFirst)
                        {
                            newRes = k.Key + ":" + k.Value;
                            isFirst = false;
                        }
                        else
                        {
                            newRes = "," + k.Key + ":" + k.Value;
                        }
                        s.Write(newRes);
                    }
                }
            }
            catch (Exception e)
            {
                Assert.Fail();
            }



        }


        [TestMethod()]
        public void VoteWriteTest()
        {
            Init();
            votes = new Dictionary<string, int>();
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
                votes["Test"]++;
            }

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
                        }
                        else
                        {
                            newRes = "," + k.Key + ":" + k.Value;
                        }
                        s.Write(newRes);
                    }
                }
            }
            catch (Exception e)
            {
                Assert.Fail();
            }


            using (StreamReader sr = new StreamReader(elecFile))
            {
                votes = new Dictionary<string, int>();
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
                Assert.AreEqual(votes["Test"], 1);
                Assert.AreEqual(votes["Test2"], 2);
            }
        }
    }
}
