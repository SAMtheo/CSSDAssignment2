using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Security.Cryptography;

namespace EVotingSystem
{
    /// <summary>
    /// A registration form that would be used by any eligible voter to recieve their voting credentials.
    /// </summary>
    public partial class UserSignup : Form
    {
        private bool proceed = true;
        public string hashedPass = "";
        public UserSignup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check whether all fields in the form have been filled in, turn the labels red if they have not to alert the user
        /// </summary>
        private void checkForm()
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                proceed = false;
                namelbl.ForeColor = Color.Red;
            }
            else namelbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(housenum.Text))
            {
                proceed = false;
                housenumlbl.ForeColor = Color.Red;
            }
            else housenumlbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(street.Text))
            {
                proceed = false;
                streetlbl.ForeColor = Color.Red;
            }
            else streetlbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(state.Text))
            {
                proceed = false;
                statelbl.ForeColor = Color.Red;
            }
            else statelbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(surname.Text))
            {
                proceed = false;
                surnamelbl.ForeColor = Color.Red;
            }
            else surnamelbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(city.Text))
            {
                proceed = false;
                citylbl.ForeColor = Color.Red;
            }
            else citylbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(zip.Text))
            {
                proceed = false;
                ziplbl.ForeColor = Color.Red;
            }
            else ziplbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(id.Text))
            {
                proceed = false;
                idlbl.ForeColor = Color.Red;
            }
            else idlbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(this.email.Text))
            {
                proceed = false;
                emailbl.ForeColor = Color.Red;
            }
            else emailbl.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(conf.Text))
            {
                proceed = false;
                conflbl.ForeColor = Color.Red;
            }
            else conflbl.ForeColor = Color.Black;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //flag that indicate whether input is valid
            proceed = true;
            //
            string user = "";
            string email = "";

            //mark text as red if not filled in / valid
            checkForm();
            //

            //build the user and email string
            user = name.Text + surname.Text;
            email = this.email.Text;

            //

            //email the password if, and only if, the form is complete.
            string st = sendMsg(proceed, user, email);

            //..else, do nothing
            if (st != "")
            {
                //hash the password
                using (var sha = new SHA256Managed())
                {
                    byte[] textData = Encoding.UTF8.GetBytes(st);
                    byte[] hash = sha.ComputeHash(textData);
                    hashedPass = BitConverter.ToString(hash).Replace("-", string.Empty);
                }

                //create user with user, st and add to database
                AccountRegistry.Instance.AddUser(new Voter(user, hashedPass, true, name.Text, surname.Text, new DateTime(10101010)));
                this.Visible = false;
                //close the registration prompt and go to the login screen - for the demo 
                new LoginScreen().Show();


            }
        }

        /// <summary>
        /// check if the form is valid i.e. all fields are filled in / emails are valid, and if so, generate and send the password via email to the user, whilst hashing their password and "storing" the user in the "database"
        /// </summary>
        /// <param name="p">Boolean representing whether the data is valuid</param>
        /// <param name="st">Username string</param>
        /// <param name="em">Email String</param>
        /// <returns></returns>
        public string sendMsg(bool p, string st, string em)
        {
            //use the ctor of MailboxAddres to check if email is valid. Throws a FormatException if it isnt 
            try
            {
                var tmpMail = new MailboxAddress(em);
            } catch (FormatException f)
            {
                MessageBox.Show("Email Invalid", "Error", MessageBoxButtons.OK);
                email.Text = "";
                conf.Text = "";
                return "";
            }

            // if everything is valid, lets send the email andf store the user
            if (p)
            {
                HashAlgorithm algorithm = SHA256.Create();
                //to login to this temp email account, go to https://mail.ionos.co.uk/ and use the below credentials. Please use carefully :)
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Admin", "temp@m1k.me"));
                //message.To.Add(new MailboxAddress(st, "temp@m1k.me")); //debug
                message.To.Add(new MailboxAddress(st, em));
                message.Subject = "Voter Registration Credentials for " + st ;
                string password = Guid.NewGuid().ToString();

                message.Body = new TextPart("plain")
                {
                    Text = "Password is " + password
                };

                using (var client = new SmtpClient())
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    client.ServerCertificateValidationCallback = (s, c, h, e_) => true;

                    client.Connect("smtp.ionos.co.uk", 587, false);

                    
                    client.Authenticate("temp@m1k.me", "password");

                    client.Send(message);
                    client.Disconnect(true);
                }
                MessageBox.Show("Registered! Please check your email for your password", "Form accepted", MessageBoxButtons.OK);
                return password;
            } else if (conf.Text != email.Text)
            {
                MessageBox.Show("Make sure you correctly confirm your email address", "Incorrect Email Confirmation", MessageBoxButtons.OK);
                return "";
            } 
            {
                 MessageBox.Show("Please make sure all boxes are filled","ERROR - Incomplete Form",MessageBoxButtons.OK);
                 return "";
            }
        }

    }
}
