using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVotingSystem
{
    public partial class LoginScreen : Form
    {
        AccountRegistry reg = AccountRegistry.Instance;
        AuthenticationBroker authBroker = new AuthenticationBroker();

        public LoginScreen()
        {
            InitializeComponent();
            Voter v1 = new Voter("Robin", "password", true, "Robin", "Davies", new DateTime(1996, 9, 3));
            reg.AddUser(v1);

        }

        private void startupPanels()
        {
            loginPanel.Visible = true;

            explanationPanel.Visible = false;
            votePanel.Visible = false;
            confirmPanel.Visible = false;
            thankYouPanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startupPanels();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // get candidates for the current election
            string user = textBox1.Text;
            string password = textBox2.Text;
            string hashedP = password;

            Session sess = authBroker.authenticate(user, hashedP);
           

            explanationPanel.Visible = true;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            votePanel.Visible = true;
        }

        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            confirmPanel.Visible = true;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            thankYouPanel.Visible = true;
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            startupPanels();
        }
    }
}
