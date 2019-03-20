using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVotingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem.Tests
{
    [TestClass()]
    public class AuthenticationBrokerTests
    {
        AccountRegistry reg;
        AuthenticationBroker broker;

        [TestInitialize]
        public void setup()
        {
            reg = AccountRegistry.Instance;
            broker = new AuthenticationBroker();
            // new voter
            reg.AddUser(new Voter("test", "password", true, "", "", new DateTime()));
            // new admin
            reg.AddUser(new Admin("admin", "password"));
            
        }

        [TestMethod()]
        public void authenticateSuccessTest()
        {
            // Success case
            // so singleton instance persists through tests aswell 
            reg.AddUser(new Voter("LOCAL", "password", true, "", "", new DateTime()));
            Session sess = broker.authenticate("LOCAL", "password");
            Assert.IsNotNull(sess.currentUser);
            Assert.IsTrue(sess.currentUser.getUsername() == "LOCAL");
        }

        [TestMethod()]
        public void authenticateNoFoundUserTest()
        {
            // incorrect user name causing error message
            Session sess = broker.authenticate("9VoltBattery", "password");
            Assert.IsTrue(sess.currentUser == null);
            Assert.IsTrue(sess.getLogInMessage() == "Username or password incorrect");
        }

        [TestMethod()]
        public void authenticateWrongPasswordTest()
        {
            // incorrect password 
            Session sess = broker.authenticate("test", "memes");
            Assert.IsTrue(sess.currentUser == null);
            Assert.IsTrue(sess.getLogInMessage() == "Username or password incorrect");
        }

        [TestMethod()]
        public void authenticateTooManyAttempsTest()
        {
            // fail to login enough and account becomes locked
            // 3 attempts
            Session sess = broker.authenticate("test", "memes");
            Assert.IsTrue(sess.currentUser == null);
            Assert.IsTrue(sess.getLogInMessage() == "Username or password incorrect");

            sess = broker.authenticate("test", "memes");
            Assert.IsTrue(sess.currentUser == null);
            Assert.IsTrue(sess.getLogInMessage() == "Username or password incorrect");

            sess = broker.authenticate("test", "memes");
            Assert.IsTrue(sess.currentUser == null);
            Assert.IsTrue(sess.getLogInMessage()
                == "Number of login attempts reached account locked: contact site admin");
        }

        [TestMethod()]
        public void findUserTest()
        {
            User u = broker.findUser(reg, "test");
            Assert.IsNotNull(u);
        }

        [TestMethod()]
        public void findUserFailTest()
        {
            User u = broker.findUser(reg, "test2");
            Assert.IsNull(u);
        }
    }
}