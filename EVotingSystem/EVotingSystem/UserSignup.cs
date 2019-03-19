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
    public partial class UserSignup : Form
    {
        private bool proceed = true;
        public string hashedPass = "";
        public UserSignup()
        {
            InitializeComponent();
        }

        private void UserSignup_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            proceed = true;
            string user = "";
            string email = "";
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                proceed = false;
                label1.ForeColor = Color.Red;
            }
            else label1.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                proceed = false;
                label3.ForeColor = Color.Red;
            }
            else label3.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                proceed = false;
                label4.ForeColor = Color.Red;
            }
            else label4.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                proceed = false;
                label5.ForeColor = Color.Red;
            }
            else label5.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                proceed = false;
                label2.ForeColor = Color.Red;
            }
            else label2.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                proceed = false;
                label7.ForeColor = Color.Red;
            }
            else label7.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                proceed = false;
                label8.ForeColor = Color.Red;
            }
            else label8.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                proceed = false;
                label9.ForeColor = Color.Red;
            }
            else label9.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                proceed = false;
                label10.ForeColor = Color.Red;
            }
            else label10.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                proceed = false;
                label6.ForeColor = Color.Red;
            }
            else label6.ForeColor = Color.Black;

            user = textBox1.Text + textBox5.Text;
            email = textBox9.Text;

            string st = sendMsg(proceed, user, email);

            if (st != "")
            {
                using (var sha = new SHA256Managed())
                {
                    byte[] textData = Encoding.UTF8.GetBytes(st);
                    byte[] hash = sha.ComputeHash(textData);
                    hashedPass = BitConverter.ToString(hash).Replace("-", string.Empty);
                }

                //create user with user, st
                AccountRegistry.Instance.AddUser(new Voter(user, hashedPass, true, textBox1.Text, textBox5.Text, new DateTime(10101010)));
                this.Visible = false;
                new LoginScreen().Show();


            }
        }


        public string sendMsg(bool p, string st, string em)
        {
            HashAlgorithm algorithm = SHA256.Create();
            if (p)
            {
                //to login to this temp email account, go to https://mail.ionos.co.uk/ and use the below credentials. Please use carefully :)
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Admin", "temp@m1k.me"));
                message.To.Add(new MailboxAddress(st, "temp@m1k.me"));
                //message.To.Add(new MailboxAddress(st, em));
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
                MessageBox.Show("Please check your email for your password", "Form accepted", MessageBoxButtons.OK);
                return password;
            } else
            {
                 MessageBox.Show("Please make sure all boxes are filled","ERROR - Incomplete Form",MessageBoxButtons.OK);
                 return "";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
