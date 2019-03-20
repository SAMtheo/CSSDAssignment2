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
    public class AdminGUITests
    {
        AdminGUI gui;
        AccountRegistry reg;


        [TestInitialize()]
        public void setup()
        {
            //Set up gui
            gui = new AdminGUI(new Session(new Admin("u", "p", Permissions.ADMIN_TYPE["Test"])));
            reg = AccountRegistry.Instance;

            //Write some users to the AccountReg some voters some admin
            reg.AddUser(new Voter("1", "", false, "", "", DateTime.MinValue));
            reg.AddUser(new Voter("2", "", false, "", "", DateTime.MinValue));
            reg.AddUser(new Voter("3", "", false, "", "", DateTime.MinValue));
            reg.AddUser(new Voter("4", "", false, "", "", DateTime.MinValue));

            reg.AddUser(new Admin("5", "", null));
            reg.AddUser(new Admin("6", "", null));
            reg.AddUser(new Admin("7", "", null));
        }

        [TestMethod()]
        public void getVotersTest()
        {
            var v = gui.getAllVoters();
            Assert.IsTrue(v.Count == 4);
            foreach (var item in v)
            {
                Assert.IsTrue(item is Voter);
            }

        }

        [TestMethod()]
        public void findUserTest()
        {
            User u = gui.getSelectedVoter(reg, "1");
            Assert.IsNotNull(u);
        }

        [TestMethod()]
        public void findUserFailTest()
        {
            User u = gui.getSelectedVoter(reg, "9Volt");
            Assert.IsNull(u);
        }
    }
}