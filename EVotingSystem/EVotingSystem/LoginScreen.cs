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
            Voter v2 = new Voter("Sam", "password", true, "Robin", "Davies", new DateTime(1996, 9, 3));
            Voter v3 = new Voter("M1k", "password", false, "Robin", "Davies", new DateTime(1996, 9, 3));
            // super Admin with all the powers
            Admin super = new Admin("Super", "password", Permissions.ADMIN_TYPE["Super"]);
            Admin onSite = new Admin("Site", "password", Permissions.ADMIN_TYPE["OnSite"]);
            Admin auditor = new Admin("Auditor", "password", Permissions.ADMIN_TYPE["Auditor"]);
            //Admin test = new Admin("Test", "password", Permissions.ADMIN_TYPE["Test"]);


            reg.AddUser(v1);
            reg.AddUser(v2);
            reg.AddUser(v3);
            // Creating Admins with various powers for demo 
            reg.AddUser(super);
            reg.AddUser(onSite);
            reg.AddUser(auditor);
            //reg.AddUser(test);

            // locking account for demo purposes
            for (int i = 0; i < 4; i++)
            {
                authBroker.authenticate("Sam", "aWrongPassword");
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
                new UserGUI().Show();
            } else if (sess.currentUser is Admin) { 
                new AdminGUI().Show();
            }
        }
    }
}
