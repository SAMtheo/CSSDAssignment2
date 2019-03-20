using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EVotingSystem
{
    public partial class AdminGUI : Form
    {
        /// <summary>
        /// Current user that the session belongs to
        /// </summary>
        Admin admin;

        /// <summary>
        /// Needs a session to get the logged in user
        /// </summary>
        /// <param name="sess"></param>
        public AdminGUI(Session sess)
        {
            // We can assume that if this constructor has been called the current user is an admin
            admin = sess.currentUser as Admin;
            InitializeComponent();
            landingPanel.Location = new Point(13, 13);
            resultPanel.Location = new Point(13, 13);
            onSitePanel.Location = new Point(13, 13);

            landingPanel.Visible = true;
            resultPanel.Visible = false;
            onSitePanel.Visible = false;

            initaliseLanding();

        }
        
        /// <summary>
        /// Initalises the landing panel based on the current users permissions
        /// </summary>
        private void initaliseLanding()
        {
            if (admin.permissions.seeResults == true)
            {
                seeResultsBtn.Visible = true;
            }
            if (admin.permissions.seeLocals == true)
            {
                seeOnSiteBtn.Visible = true;
            }
        }

        private void initaliseResults()
        {
            string elecFile = "election.votes";
            Dictionary<string, int> votes = new Dictionary<string, int>();

            //List<Voter> voters = new List<Voter>();

            //listBox1.DataSource = voters;

            //check if file exists, if it doesnt throw a hissy fit
            try
            {
                FileStream F = new FileStream(elecFile, FileMode.Open, FileAccess.Read);
                F.Close();
            }
            catch (Exception e)
            {
                throw e;
            }


            using (StreamReader sr = new StreamReader(elecFile))
            {
                Task<string> fileContents = sr.ReadToEndAsync();
                string f = fileContents.Result;
                //create a list of candidate:votes pairs
                string[] elections = f.Split(',');

                string[] elecPair = new string[2];
                //read in all existing values
                foreach (string s in elections)
                {
                    //should always return a pair, but .Split returns a []
                    elecPair = s.Split(':');

                    if (elecPair.Length != 2)
                    {
                        throw new Exception();
                    }
                    //covert string val to number
                    int votesNum = Convert.ToInt32(elecPair[1]);

                    //and add them to our dictionary
                    votes.Add(elecPair[0], votesNum);

                }


                DataTable dt = new DataTable();
                dt.Columns.Add("Candidate", typeof(string));
                dt.Columns.Add("Votes", typeof(string));
                votes
                    .ToList()
                    .ForEach(kvp => dt.Rows.Add(new object[] { kvp.Key, kvp.Value }));

                //allows you to add uniqueness constraint to the key column :-)
                dt.Constraints.Add("keyconstraint", dt.Columns[0], true);

                dataGridView1.DataSource = dt;

                dataGridView1.ReadOnly = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminTitle_Click(object sender, EventArgs e)
        {

        }
        // Navigation buttons
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            // end session
            this.Close();
        }

        private void resultBack_Click(object sender, EventArgs e)
        {
            landingPanel.Visible = true;
            resultPanel.Visible = false;
        }

        private void onSiteBack_Click(object sender, EventArgs e)
        {
            landingPanel.Visible = true;
            onSitePanel.Visible = false;
        }

        private void seeOnSiteBtn_Click(object sender, EventArgs e)
        {
            landingPanel.Visible = false;
            onSitePanel.Visible = true;

            if(!admin.permissions.setEligabilty)
                setIneligibleBtn.Visible = false;

            if (!admin.permissions.resetAuthAttempts)
                unlockBtn.Visible = false;

            updateVoterView();

        }

        private void seeResultsBtn_Click(object sender, EventArgs e)
        {
            landingPanel.Visible = false;
            resultPanel.Visible = true;
            initaliseResults();
        }

        /// <summary>
        /// Filteres the users in account reg then casts to Voter type
        /// </summary>
        /// <returns></returns>
        public List<Voter> getAllVoters()
        {
            AccountRegistry reg = AccountRegistry.Instance;

            var allVoters = reg.users.Where(u => u is Voter).ToList();

            List<Voter> voters = new List<Voter>();
            foreach (var item in allVoters)
            {
                voters.Add(item as Voter);
            }

            return voters;
        }

        /// <summary>
        /// Sets up voters into a DataTable for easy viewing
        /// </summary>
        private void updateVoterView()
        {
            DataTable dt = new DataTable();
            // Everything an admin is allowed to know
            dt.Columns.Add("Voter", typeof(string));
            dt.Columns.Add("Can Vote", typeof(bool));
            dt.Columns.Add("Locked", typeof(bool));

            var voters = getAllVoters();
            voters.ForEach(v => dt.Rows.Add(new Object[] { v.getUsername(), v.getIsEligible(), v.getAuthAttempts() >= 3 }));

            dt.Constraints.Add("keyconstraint", dt.Columns[0], true);

            voterView.DataSource = dt;
            voterView.ReadOnly = true;

            if (admin.permissions.seeEligabilty == false)
                voterView.Columns[1].Visible = false;
            if (admin.permissions.resetAuthAttempts == false)
                voterView.Columns[2].Visible = false;

        }

        private void unlockBtn_Click(object sender, EventArgs e)
        {
            // can only select rows and only 1 so this is safe
            string selectedVoter = voterView.SelectedRows[0].Cells[0].Value as string;
            getSelectedVoter(AccountRegistry.Instance, selectedVoter).resetAuthAttempts();
            updateVoterView();
        }

        public void setIneligibleBtn_Click(object sender, EventArgs e)
        {
            string selectedVoter = voterView.SelectedRows[0].Cells[0].Value as string;
            getSelectedVoter(AccountRegistry.Instance, selectedVoter).setIsEligible(false);
            updateVoterView();
        }

        /// <summary>
        /// returns the voter based on the username 
        /// </summary>
        /// <returns></returns>
        public Voter getSelectedVoter(AccountRegistry reg, string selectedUsername)
        {
            return reg.users.Find(x => x.getUsername() == selectedUsername) as Voter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = voterView.DataSource;
            bs.Filter = "Voter" + " like '%" + searchBox.Text + "%'";
            voterView.DataSource = bs;
        }
    }
}