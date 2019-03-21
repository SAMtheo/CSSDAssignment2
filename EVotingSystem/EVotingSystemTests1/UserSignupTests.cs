using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVotingSystem;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Pop3;
using MailKit;
using MimeKit;

namespace EVotingSystem.Tests
{
    [TestClass()]
    public class UserSignupTests : UserSignup
    {
        string user = "test";
        string email = "temp@m1k.me";
        bool proceed = true;

        string pass = "";
        [TestMethod()]
        public void blankBoxes()
        {
            initTextBoxes(false, false);
            checkForm();
            pass = sendMsg(false, user, email); ;
            Assert.AreEqual(pass, "");
            Assert.AreEqual(getConfLblCol(), Color.Red);
        }


        [TestMethod()]
        public void invalidEmail()
        {

            initTextBoxes(true, true);
            checkForm();
            pass = sendMsg(true, user, "notavalidemail");

            Assert.AreEqual(pass, "");
            Assert.AreEqual(getConfLblCol(), Color.Black);
        }

        [TestMethod()]
        public void nonMatchingEmails()
        {
            initTextBoxes(true, false);
            checkForm();
            pass = sendMsg(true, user, "non@matchingemail.net");

            Assert.AreEqual(pass, "");
            Assert.AreEqual(getConfLblCol(), Color.Red);

        }

        [TestMethod()]
        public void testHash()
        {
            string pw = "hello there";

            string hashedPW = hashPW(pw);

            //below is a pre defined sha-256 hash of "hello there"
            string hashed2Pw = "12998C017066EB0D2A70B94E6ED3192985855CE390F321BBDB832022888BD251";

            Assert.AreEqual(hashedPW, hashed2Pw);


        }

        [TestMethod()]
        public void recTest()
        {

            initTextBoxes(true, true);
            checkForm();
            pass = sendMsg(true, user, "temp@m1k.me");



            using (var client = new Pop3Client())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("pop.ionos.com", 995, false);

                client.Authenticate("temp@m1k.me", "password");

                System.Threading.Thread.Sleep(5000);

                for (int i = 0; i < client.Count; i++)
                {
                    var message = client.GetMessage(i);
                    Console.WriteLine("Subject: {0}", message.Subject);


                    Assert.AreEqual("Password is " + pass,message);
                }

                client.Disconnect(true);
            }
        }
    }
}