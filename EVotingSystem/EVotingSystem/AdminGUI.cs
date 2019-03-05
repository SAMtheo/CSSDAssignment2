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
        public AdminGUI()
        {
            string elecFile = "election.votes";
            Dictionary<string, int> votes = new Dictionary<string, int>();

            //check if file exists, if it doesnt throw a hissy fit
            try
            {
                FileStream F = new FileStream(elecFile, FileMode.Open, FileAccess.Read);
                F.Close();
            } catch (Exception e)
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
            }


            InitializeComponent();
        }
    }
}
