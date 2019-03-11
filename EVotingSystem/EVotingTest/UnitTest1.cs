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
            VoteStorage.Vote("a");
            Assert.Fail();
        }
    }
}
