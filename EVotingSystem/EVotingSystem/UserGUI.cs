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

        private void UserGUI_Load(object sender, EventArgs e)
        {

        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            explanationPanel.Visible = false;
            votePanel.Visible = true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            votePanel.Visible = false;
            confirmPanel.Visible = true;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            confirmPanel.Visible = false;
            thankYouPanel.Visible = true;
        }

        private void signOutLbl_Click(object sender, EventArgs e)
        {
            // end session here
            this.Close();
        }
    }
}
