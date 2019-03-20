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
        // list of candidates created for election
        List<Candidate> candidates = new List<Candidate>();
        // Selected candidate to be used to send selected candidates
        Candidate selected = null;
        // font style to be applied to all text for accessibility
        Font accessibilityFont = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);

        bool duringVote = false;
        bool colorBlindMode = false;

        Election currentElection;
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
            accessibilityPanel.Location = new Point(13, 13);

            // Set all panels visible to false other than explanationPanel
            votePanel.Visible = false;
            confirmPanel.Visible = false;
            thankYouPanel.Visible = false;
            accessibilityPanel.Visible = false;

            // setup the accessibility text size tracker
            textSizeTracker.Minimum = 8;
            textSizeTracker.Maximum = 14;
            textSizeTracker.Value = 8;
            textSizeTracker.SmallChange = 1;
            textSizeTracker.TickFrequency = 6;
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
                PictureBox newPic = new PictureBox();
                newPic.Name = Candidates[i].party + "Pic";
                newPic.Location = new Point(20, (i * 60) + 30);
                newPic.Size = new Size(65, 60);
                newPic.BackgroundImage = Candidates[i].photo;
                newPic.BackgroundImageLayout = ImageLayout.Stretch;

                Button newBtn = new Button();
                newBtn.Name = Candidates[i].name + "Btn";
                newBtn.Location = new Point(91, (i * 60) + 30);
                newBtn.Size = new Size(138, 60);
                newBtn.Text = Candidates[i].name + ": " + Candidates[i].party;
                newBtn.BackColor = Candidates[i].partyColor;
                newBtn.FlatStyle = FlatStyle.Flat;

                RadioButton newChk = new RadioButton();
                newChk.Location = new Point(235, (i * 60) + 50);
                newChk.Size = new Size(17, 16);
                newChk.Name = Candidates[i].name + "Chk";
                if (Candidates[i].lightText)
                {
                    newBtn.ForeColor = Color.White;
                }

                newBtn.Click += delegate (object sender, EventArgs e) { buttonClick(sender, e, newChk); };

                candidatesGrp.Controls.Add(newPic);
                candidatesGrp.Controls.Add(newBtn);
                candidatesGrp.Controls.Add(newChk);

                candidateRadioBox.Add(newChk);

                votePanel.Refresh();
            }
        }

        void buttonClick(object sender, EventArgs e, RadioButton candidateRadio)
        {
            candidateRadio.Checked = true;
        }

        /// <summary>
        /// updateConfirmed sets the labels for the selected candidate
        /// for review by the user.
        /// </summary>
        public void updateConfirmed()
        {
            PictureBox newPic = new PictureBox();
            newPic.Name = selected.party + "PicConfirm";
            newPic.Location = new Point(20, 30);
            newPic.Size = new Size(65, 60);
            newPic.BackgroundImage = selected.photo;
            newPic.BackgroundImageLayout = ImageLayout.Stretch;

            Button newBtn = new Button();
            newBtn.Name = selected.name + "BtnConfirm";
            newBtn.Location = new Point(91, 30);
            newBtn.Size = new Size(138, 60);
            newBtn.Text = selected.name + ": " + selected.party;
            if (colorBlindMode)
            {
                newBtn.BackColor = Color.LightGray;
                newBtn.ForeColor = Color.Black;
            }
            else
            {
                newBtn.BackColor = selected.partyColor;
                if (selected.lightText)
                {
                    newBtn.ForeColor = Color.White;
                }
            }
            newBtn.FlatStyle = FlatStyle.Flat;

            //Label candidateDetails = new Label();
            //candidateDetails.Name = "candidateDetailsLbl";
            //candidateDetails.Text = selected.name + ": " + selected.party;
            //candidateDetails.Location = new Point(50, 50);

            voteConfirmBox.Controls.Add(newPic);
            voteConfirmBox.Controls.Add(newBtn);
        }

        /// <summary>
        /// Loads the user gui, setting the candidates and election in the process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserGUI_Load(object sender, EventArgs e)
        {
            // Get candidates
            candidates.Add(new Candidate("Sam", "Green Party", "../Debug/greenParty.png", Color.FromArgb(0,192,0), false));
            candidates.Add(new Candidate("Mike", "UKIP", "../Debug/UKIP.png", Color.Purple, true));

            // Get start and end dates
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(2);

            // create the current election
            currentElection = new Election("Sheffield Mayor Election", 9090, candidates, start, end);

            // update buttons based on current election
            candidateButtons(candidates);
            electionTitleLbl.Text = "Election: " + currentElection.electionName;
        }

        /// <summary>
        /// progresses the user from the explanationPanel to the votePanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (duringVote)
            {
                explanationPanel.Visible = false;
            } else
            {
                explanationPanel.Visible = false;
                votePanel.Visible = true;
                duringVote = true;
            }
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
                    selected = candidates[i];
                }
            }
            
            // only progress if there is only one candidate selected
            if (selected != null)
            {
                updateConfirmed();

                votePanel.Visible = false;
                confirmPanel.Visible = true;
                selectionErrLbl.Visible = false;
            }
            // if nobody is selected show the error message
            else
            {
                selectionErrLbl.Visible = true;
            }
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
            // send result to election
            currentElection.vote(selected);
            // as the vote is sent, we set the currentUsers eligibility to false
            // so they cannot vote again.
            currentUser.setIsEligible(false);
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
            voteConfirmBox.Controls.RemoveByKey(selected.name + "BtnConfirm");
            voteConfirmBox.Controls.RemoveByKey(selected.party + "PicConfirm");
            confirmPanel.Visible = false;
            votePanel.Visible = true;
        }

        private void accessabilityLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            accessibilityPanel.Visible = true;
            accessibilityPanel.BringToFront();
        }

        private void accessibilityBackBtn_Click(object sender, EventArgs e)
        {
            accessibilityPanel.Visible = false;
        }

        private void textSizeTracker_Scroll(object sender, EventArgs e)
        {
            textSizeExample.Font = new Font("Microsoft Sans Serif", textSizeTracker.Value, FontStyle.Regular);
        }

        private void accessibilityApplyBtn_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Microsoft Sans Serif", textSizeTracker.Value, FontStyle.Regular);
            explanationlbl.Font = newFont;
            if (colorBlindCheckBox.Checked)
            {
                colorBlindMode = true;
                foreach (Control btn in candidatesGrp.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if (btn is Button)
                    {
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Black;
                    }
                }
                foreach (Control btn in voteConfirmBox.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if (btn is Button)
                    {
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                colorBlindMode = false;
                int index = 0;
                foreach (Control btn in candidatesGrp.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if (btn is Button)
                    {
                        btn.BackColor = candidates[index].partyColor;
                        if (candidates[index].lightText)
                        {
                            btn.ForeColor = Color.White;
                        }
                        else
                        {
                            btn.ForeColor = Color.Black;
                        }
                        index++;
                    }
                }
                foreach (Control btn in voteConfirmBox.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if (btn is Button)
                    {
                        btn.BackColor = selected.partyColor;
                        if (selected.lightText)
                        {
                            btn.ForeColor = Color.White;
                        }
                        else
                        {
                            btn.ForeColor = Color.Black;
                        }
                    }
                }
            }
            accessibilityPanel.Visible = false;
        }

        private void helpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            explanationPanel.Visible = true;
            explanationPanel.BringToFront();
        }
    }
}
