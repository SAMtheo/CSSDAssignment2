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

namespace EVotingSystem
{
    public partial class UserSignup : Form
    {
        private bool proceed = true;
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


            sendMsg(proceed, user, email);
        }


        public void sendMsg(bool p, string st, string em)
        {
            if (p)
            {
                //to login to this temp email account, go to https://mail.ionos.co.uk/ and use the below credentials. Please use carefully :)
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Admin", "temp@m1k.me"));
                message.To.Add(new MailboxAddress(st, "temp@m1k.me"));
                message.Subject = "Voter Registration Credentials for " + st ;

                string randomPass = "password" + st;

                message.Body = new TextPart("plain")
                {
                    Text = "Password is " + randomPass
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
            } else
            {
                 MessageBox.Show("Please make sure all boxes are filled","ERROR - Incomplete Form",MessageBoxButtons.OK);
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
