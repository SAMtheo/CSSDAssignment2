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
    public partial class UserGUI : Form
    {
        List<RadioButton> candidateRadioBox = new List<RadioButton>();
        List<Candidate> candidates = new List<Candidate>();
        Candidate selected;
        Election currentElection;
        public UserGUI()
        {
            InitializeComponent();
            explanationPanel.Location = new Point(13, 13);
            votePanel.Location = new Point(13, 13);
            confirmPanel.Location = new Point(13, 13);
            thankYouPanel.Location = new Point(13, 13);

            votePanel.Visible = false;
            confirmPanel.Visible = false;
            thankYouPanel.Visible = false;
        }

        private void candidateButtons(List<Candidate> Candidates)
        {
            for (int i = 0; i < Candidates.Count; i++)
            {
                RadioButton newChk = new RadioButton();
                newChk.Text = Candidates[i].name;
                newChk.Location = new Point(20, (i * 50) + 30);
                newChk.Name = Candidates[i].name + "Chk";
                candidatesGrp.Controls.Add(newChk);
                votePanel.Refresh();
                candidateRadioBox.Add(newChk);
            }
        }

        public void updateConfirmed()
        {
            Label candidateDetails = new Label();
            candidateDetails.Name = "candidateDetailsLbl";
            candidateDetails.Text = selected.name + ": " + selected.party + " party.";
            candidateDetails.Location = new Point(50, 50);

            voteConfirmBox.Controls.Add(candidateDetails);
        }

        private void UserGUI_Load(object sender, EventArgs e)
        {
            // Get candidates
            candidates.Add(new Candidate("Sam", "Green", ""));
            candidates.Add(new Candidate("Mike", "UKIP", ""));

            // Get start and end dates
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(2);

            // create the current election
            currentElection = new Election("Sheffield Mayor Election", 9090, candidates, start, end);

            // update buttons based on current election
            candidateButtons(candidates);
            electionTitleLbl.Text = "Election: " + currentElection.electionName;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            explanationPanel.Visible = false;
            votePanel.Visible = true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< candidateRadioBox.Count; i++)
            {
                if (candidateRadioBox[i].Checked)
                {
                    selected = candidates[i];
                }
            }
            updateConfirmed();

            votePanel.Visible = false;
            confirmPanel.Visible = true;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // send result to election
            currentElection.vote(selected);
            confirmPanel.Visible = false;
            thankYouPanel.Visible = true;
        }

        private void signOutLbl_Click(object sender, EventArgs e)
        {
            // end session here
            this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            voteConfirmBox.Controls.RemoveByKey("candidateDetailsLbl");
            confirmPanel.Visible = false;
            votePanel.Visible = true;
        }
    }
}
