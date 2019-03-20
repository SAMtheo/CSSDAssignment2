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
    public class SecureStorageTests
    {
        /// <summary>
        /// Test the encrypt and decrypt algorithm by working with a single string.
        /// </summary>
        [TestMethod()]
        public void EncryptDecryptTest()
        {
            // Data to use for the test
            String plainTextTest = "Testing string, this string should be encrypted and decrypted back.";
            String passcode      = "TESTINGPASSWORD9991110009991100";

            String encryptedString;
            String decryptedString;

            // Encrypt the string with the passcode
            encryptedString = SecureStorage.Encrypt(plainTextTest, passcode);
            Console.WriteLine(encryptedString);
            decryptedString = SecureStorage.Decrypt(encryptedString, passcode);


            if (!plainTextTest.Equals(decryptedString)) {
                Assert.Fail();
            }
        }
    }
}