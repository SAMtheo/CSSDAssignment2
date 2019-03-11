using EVotingSystem;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EVotingSystem.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void VoteWriteTest()
        {
            //have known file in elections.votes
            VoteStorage.Vote("a");
            //check relevant fields have been updated
        }
    }
}
