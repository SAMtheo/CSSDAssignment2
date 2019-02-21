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
    public partial class ThankYou : Form
    {
        public ThankYou()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // go back to login promting for new user.
            this.Close();
        }
    }
}
