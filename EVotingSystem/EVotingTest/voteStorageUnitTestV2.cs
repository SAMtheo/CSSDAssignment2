using EVotingSystem;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EVotingSystem.Tests
{
    [TestClass()]
    public class VoteStorageUnitTestV2
    {
        string elecFile = "electionTest.votes";

        // Main writing to file test
        [TestMethod()]
        public void votingTestNewFile()
        {
            // Prepare
            if (File.Exists(elecFile))
            {
                File.Delete(elecFile);
            }

            string electionNameOne = "Election 1";
            string selectedCandidateNameOne = "Mike";

            List<Candidate> candidatesOne = new List<Candidate>();
            candidatesOne.Add(new Candidate("Sam", "Sample", ""));
            candidatesOne.Add(new Candidate("Mike", "Mikele", ""));

            string electionNameTwo = "Election 2";
            string selectedCandidateNameTwo = "Joe";

            List<Candidate> candidatesTwo = new List<Candidate>();
            candidatesTwo.Add(new Candidate("Joe", "Joele", ""));
            candidatesTwo.Add(new Candidate("Michael", "Michaelle", ""));

            // Test
            VoteStorageV2.Vote(elecFile, electionNameOne, candidatesOne, selectedCandidateNameOne);
            VoteStorageV2.Vote(elecFile, electionNameTwo, candidatesTwo, selectedCandidateNameTwo);

            // Verify
            using (FileStream file = new FileStream(elecFile, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader read = new StreamReader(file))
                {
                    List<string> expectedLines = new List<string>();
                    expectedLines.Add("Election 1");
                    expectedLines.Add("Sam:0,Mike:1");
                    expectedLines.Add("Election 2");
                    expectedLines.Add("Joe:1,Michael:0");

                    for (int i = 0; i < expectedLines.Count; i++)
                    {
                        string line = read.ReadLine();
                        if (!(expectedLines[i].Equals(line)))
                        {
                            Console.Out.WriteLine("Expected: " + expectedLines[i]);
                            Console.Out.WriteLine("Actual: " + line);
                            Assert.Fail();
                        }
                    }
                }
            }
        }


        // Main writing to file test
        [TestMethod()]
        public void votingTestNoNewFile()
        {
            // Prepare
            if (File.Exists(elecFile))
            {
                File.Delete(elecFile);
            }

            using (FileStream file = new FileStream(elecFile, FileMode.CreateNew, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine("Election 1");
                    writer.WriteLine("Sam:0,Mike:0");
                    writer.WriteLine("Election 2");
                    writer.WriteLine("Joe:0,Michael:0");
                }
            }

            string electionNameOne = "Election 1";
            string selectedCandidateNameOne = "Mike";

            List<Candidate> candidatesOne = new List<Candidate>();
            candidatesOne.Add(new Candidate("Sam", "Sample", ""));
            candidatesOne.Add(new Candidate("Mike", "Mikele", ""));

            string electionNameTwo = "Election 2";
            string selectedCandidateNameTwo = "Joe";

            List<Candidate> candidatesTwo = new List<Candidate>();
            candidatesTwo.Add(new Candidate("Joe", "Joele", ""));
            candidatesTwo.Add(new Candidate("Mike", "Michaelle", ""));

            // Test
            VoteStorageV2.Vote(elecFile, electionNameOne, candidatesOne, selectedCandidateNameOne);
            VoteStorageV2.Vote(elecFile, electionNameTwo, candidatesTwo, selectedCandidateNameTwo);

            // Verify
            using (FileStream file = new FileStream(elecFile, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader read = new StreamReader(file))
                {
                    List<string> expectedLines = new List<string>();
                    expectedLines.Add("Election 1");
                    expectedLines.Add("Sam:0,Mike:1");
                    expectedLines.Add("Election 2");
                    expectedLines.Add("Joe:1,Michael:0");

                    for (int i = 0; i < expectedLines.Count; i++)
                    {
                        string line = read.ReadLine();
                        if (!(expectedLines[i].Equals(line)))
                        {
                            Console.Out.WriteLine("Expected: " + expectedLines[i]);
                            Console.Out.WriteLine("Actual: " + line);
                            Assert.Fail();
                        }
                    }
                }
            }
        }

        [TestMethod()]
        public void createNewElectionInFileTest()
        {
            // Prepare
            string electionName = "Elections Test";
            string selectedCandidateName = "Sam";
            
            List<Candidate> candidates = new List<Candidate>();
            candidates.Add(new Candidate("Sam", "Sample", ""));
            candidates.Add(new Candidate("Mike", "Mikele", ""));

            List<string> fileContents = new List<string>();

            // Test
            fileContents = VoteStorageV2.createNewElectionInFile(
                fileContents, electionName, candidates, selectedCandidateName);

            // Verify
            List<string> expectedFileContents = new List<string>();
            expectedFileContents.Add(electionName);

            string candidateLine = candidates[0].name + ":1,";
            candidateLine += candidates[1].name + ":0";

            expectedFileContents.Add(candidateLine);

            if (!(fileContents[0].Equals(expectedFileContents[0])))
            {
                Assert.Fail();
            }
            if (!(fileContents[1].Equals(expectedFileContents[1])))
            {
                Assert.Fail();
            }
        }
    }
}
