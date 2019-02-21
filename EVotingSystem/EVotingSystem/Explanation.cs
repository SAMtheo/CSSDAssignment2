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
    public partial class Explanation : Form
    {
        public Explanation()
        {
            InitializeComponent();
        }

        private void Explanation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new VotingScreen().Show();
            this.Close();
        }
    }
}
