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
        public UserSignup()
        {
            InitializeComponent();
        }

        private void UserSignup_Load(object sender, EventArgs e)
        {
            //to login to this temp email account, go to https://mail.ionos.co.uk/ and use the below credentials. Please use carefully :)
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Admin", "temp@m1k.me"));
            message.To.Add(new MailboxAddress("User", "temp@m1k.me"));
            message.Subject = "Voter Registration Credentials for ";// + user ;

            message.Body = new TextPart("plain")
            {
                Text = ""
            };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e_) => true;

                client.Connect("smtp.ionos.co.uk", 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("temp@m1k.me", "password");

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
