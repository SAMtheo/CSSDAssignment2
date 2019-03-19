using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EVotingSystem
{

    /// <summary>
    /// UserGUI creates the voting instance for the current user.
    /// elections and candidates are generated here.
    /// </summary>
    public partial class UserGUI : Form
    {
        // Radio boxes created for user interaction
        List<RadioButton> candidateRadioBox = new List<RadioButton>();
        //List of selected candidates to be submitted for their given elections
        List<Candidate> selectedCandidates = new List<Candidate>();

        int currentElection;
        List<Election> elections = new List<Election>();

        Voter currentUser;

        /// <summary>
        /// Creates the UserGUI from a session, 
        /// UserGUI is only created if the user is a voter
        /// </summary>
        /// <param name="sess">EVotingSystem.Session</param>
        public UserGUI(Session sess)
        {
            InitializeComponent();
            // UserGUI is only called if the currentUser is a Voter
            currentUser = sess.currentUser as Voter;
            // sets all locations for panels so they overlap each other
            explanationPanel.Location = new Point(13, 13);
            votePanel.Location = new Point(13, 13);
            confirmPanel.Location = new Point(13, 13);
            thankYouPanel.Location = new Point(13, 13);

            // all other panels .visible prop is set to false
            votePanel.Visible = false;
            confirmPanel.Visible = false;
            thankYouPanel.Visible = false;
        }

        /// <summary>
        /// candidateButtons creates and adds buttons to the voting
        /// panel. The location is set for each button.
        /// </summary>
        /// <param name="Candidates">List of candidates</param>
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

        /// <summary>
        /// updateConfirmed sets the labels for the selected candidate
        /// for review by the user.
        /// </summary>
        public void updateConfirmed()
        {
            Label candidateDetails = new Label();
            candidateDetails.Name = "candidateDetailsLbl-" + currentElection;
            candidateDetails.Text = selectedCandidates[currentElection].name + ": " + selectedCandidates[currentElection].party + " party.";
            candidateDetails.Location = new Point(50, 50);

            voteConfirmBox.Controls.Add(candidateDetails);
        }

        /// <summary>
        /// Loads the user gui, setting the candidates and election in the process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserGUI_Load(object sender, EventArgs e)
        {
            // Get candidates
            List<Candidate> candidates = new List<Candidate>();
            candidates.Add(new Candidate("Sam", "1", ""));
            candidates.Add(new Candidate("Mike", "2", ""));
            // Get start and end dates
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(2);
            // create the current election
            elections.Add(new Election("Election 1", 9090, candidates, start, end));

            // Get candidates
            candidates = new List<Candidate>();
            candidates.Add(new Candidate("Joe", "3", ""));
            candidates.Add(new Candidate("Mike", "4", ""));
            // Get start and end dates
            start = DateTime.Now;
            end = start.AddDays(2);
            // create the current election
            elections.Add(new Election("Election 2", 8080, candidates, start, end));

            // Get candidates
            candidates = new List<Candidate>();
            candidates.Add(new Candidate("Robin", "5", ""));
            candidates.Add(new Candidate("Michael", "6", ""));
            // Get start and end dates
            start = DateTime.Now;
            end = start.AddDays(2);
            // create the current election
            elections.Add(new Election("Election 3", 7070, candidates, start, end));

            currentElection = 0;
            updateVotePanel(); // update buttons based on current election
        }

        /// <summary>
        /// progresses the user from the explanationPanel to the votePanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueBtn_Click(object sender, EventArgs e)
        {
            explanationPanel.Visible = false;
            votePanel.Visible = true;
        }

        /// <summary>
        /// sets the selected candidate depending on which candidate
        /// was selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< candidateRadioBox.Count; i++)
            {
                if (candidateRadioBox[i].Checked)
                {
                    if (selectedCandidates.ElementAtOrDefault(currentElection) == null)
                    {
                        selectedCandidates.Add(elections[currentElection].candidates[i]);
                    } else
                    {
                        selectedCandidates[currentElection] = elections[currentElection].candidates[i];
                    }
                }
            }
            
            // only progress if there is a candidate at the selected element
            if (selectedCandidates.ElementAtOrDefault(currentElection) != null)
            {
                updateConfirmed();
                if (currentElection < elections.Count - 1)
                {
                    currentElection++;
                    updateVotePanel(); //Set everything up for the next voting set

                    selectionErrLbl.Visible = false;
                }
                else
                {
                    votePanel.Visible = false;
                    confirmPanel.Visible = true;
                    selectionErrLbl.Visible = false;
                }
            }
            // if nobody is selected show the error message
            else
            {
                selectionErrLbl.Visible = true;
            }
        }

        /// <summary>
        /// Updates the voting panel to reflect the current election
        /// </summary>
        private void updateVotePanel()
        {
            // load in the new candidates for the next election
            candidateRadioBox.Clear();
            candidatesGrp.Controls.Clear();
            candidateButtons(elections[currentElection].candidates);
            // pull up the new elections title
            electionTitleLbl.Text = "Election: " + elections[currentElection].electionName;

            if (selectedCandidates.ElementAtOrDefault(currentElection) != null)
            {
                for (int i = 0; i < candidateRadioBox.Count; i++)
                {
                    if (candidateRadioBox[i].Text.Equals(selectedCandidates[currentElection].name))
                    {
                        candidateRadioBox[i].Select();
                    }
                }
            }

            votePanel.Refresh();
        }

        /// <summary>
        /// progresses the user from confirmPanel to thankYouPanel
        /// also sends a vote method containing the selected candidate to the
        /// voteStorage class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // to prevent a user being able to vote again after sending the vote
            // we set the current Users eligibility to false
            currentUser.setIsEligible(false);
            // then we send off their choices to elections
            for (int i = 0; i < elections.Count; i++)
            {
                elections[i].vote(selectedCandidates[i]);
            }
            confirmPanel.Visible = false;
            thankYouPanel.Visible = true;
        }

        /// <summary>
        /// Signs out the current user, making them unEligible to vote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signOutLbl_Click(object sender, EventArgs e)
        {
            // ends session
            this.Close();
        }

        /// <summary>
        /// When the user wants to change their vote.
        /// the confirm panel is closed and the vote panel is opened again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void denyBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < elections.Count; i++)
            {
                voteConfirmBox.Controls.RemoveByKey("candidateDetailsLbl-" + i);
            }

            confirmPanel.Visible = false;
            votePanel.Visible = true;

            currentElection = 0;
            updateVotePanel();
        }
    }
}
