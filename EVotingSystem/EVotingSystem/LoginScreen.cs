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
        public LoginScreen()
        {
            InitializeComponent();
        }

        public struct Candidate
        {
            public String title;
            public Candidate(String title)
            {
                this.title = title;
            }
        }

        private void startupPanels()
        {
            loginPanel.Visible = true;

            explanationPanel.Visible = false;
            votePanel.Visible = false;
            confirmPanel.Visible = false;
            thankYouPanel.Visible = false;
        }

        private void candidateButtons(List<Candidate> Candidates)
        {
            for (int i = 0; i < Candidates.Count; i++)
            {
                Button newButton = new Button();
                newButton.Text = Candidates[i].title;
                newButton.Location = new Point(100, i * 100);
                votePanel.Controls.Add(newButton);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startupPanels();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // get candidates for the current election
            List<Candidate> candidates = new List<Candidate>();
            candidates.Add(new Candidate("Sam"));
            candidates.Add(new Candidate("Mike"));
            candidateButtons(candidates);

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
