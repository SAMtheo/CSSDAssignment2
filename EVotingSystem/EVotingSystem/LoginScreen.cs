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
            Voter v2 = new Voter("Sam", "sample", true, "Sam", "Theobald", new DateTime(1995, 10, 11));
            Admin a1 = new Admin("Admin", "admin1");
            reg.AddUser(v1);
            reg.AddUser(v2);
            reg.AddUser(a1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			passwordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
		}

		private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				// Enter key pressed
				loginBtn.PerformClick();
			}
		}

		/// <summary>
		/// Reads username and password from the login screen
		/// authenticates the username and password getting a session with the desired user
		/// then serves the next GUI depending on the type of user 
		/// Failed login results in a contextual error message being shown
		/// </summary>
		private void loginBtn_Click(object sender, EventArgs e)
        {
            // get candidates for the current election
            string user = usernameBox.Text;
            string password = passwordBox.Text;
            string hashedP = password;
            // if error set errorLbl.Visible to true

            if(!capatchaChk.Checked)
            {
                errorLbl.Visible = true;
                errorLbl.Text = "Go away evil robot";
                return;
            }

            Session sess = authBroker.authenticate(user, hashedP);
            usernameBox.Text = "";
            passwordBox.Text = "";

            if (sess.currentUser == null)
            {
                errorLbl.Visible = true;
                Console.WriteLine(sess.getLogInMessage());
                errorLbl.Text = sess.getLogInMessage();
                return;
            }

            errorLbl.Visible = false;

            if (sess.currentUser is Voter) {

                var voter = sess.currentUser as Voter;
                if (voter.getIsEligible())
                    new UserGUI(sess).Show();
                else {
                    errorLbl.Visible = true;
                    errorLbl.Text = "This account is not eligible to vote";
                } 

            } else if (sess.currentUser is Admin) { 
                new AdminGUI().Show();
            }
        }
    }
}
