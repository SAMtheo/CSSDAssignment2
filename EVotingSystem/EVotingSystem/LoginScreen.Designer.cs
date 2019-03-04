namespace EVotingSystem
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.explanationPanel = new System.Windows.Forms.Panel();
            this.votePanel = new System.Windows.Forms.Panel();
            this.candidatesGrp = new System.Windows.Forms.GroupBox();
            this.sumbitBtn = new System.Windows.Forms.Button();
            this.electionTitleLbl = new System.Windows.Forms.Label();
            this.electionLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.votingScreenImg = new System.Windows.Forms.PictureBox();
            this.explanationTitleLbl = new System.Windows.Forms.Label();
            this.assessabilityLbl = new System.Windows.Forms.LinkLabel();
            this.continueBtn = new System.Windows.Forms.Button();
            this.loginTitleLbl = new System.Windows.Forms.Label();
            this.fgtPwdLbl = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.capatchaChk = new System.Windows.Forms.CheckBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirmPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.denyBtn = new System.Windows.Forms.Button();
            this.voteConfirmBox = new System.Windows.Forms.GroupBox();
            this.thankYouPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.explanationPanel.SuspendLayout();
            this.votePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.votingScreenImg)).BeginInit();
            this.confirmPanel.SuspendLayout();
            this.thankYouPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.explanationPanel);
            this.loginPanel.Controls.Add(this.loginTitleLbl);
            this.loginPanel.Controls.Add(this.fgtPwdLbl);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.capatchaChk);
            this.loginPanel.Controls.Add(this.usernameLbl);
            this.loginPanel.Controls.Add(this.passwordLbl);
            this.loginPanel.Controls.Add(this.textBox2);
            this.loginPanel.Controls.Add(this.textBox1);
            this.loginPanel.Location = new System.Drawing.Point(12, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(776, 329);
            this.loginPanel.TabIndex = 1;
            // 
            // explanationPanel
            // 
            this.explanationPanel.Controls.Add(this.votePanel);
            this.explanationPanel.Controls.Add(this.label1);
            this.explanationPanel.Controls.Add(this.votingScreenImg);
            this.explanationPanel.Controls.Add(this.explanationTitleLbl);
            this.explanationPanel.Controls.Add(this.assessabilityLbl);
            this.explanationPanel.Controls.Add(this.continueBtn);
            this.explanationPanel.Location = new System.Drawing.Point(0, 0);
            this.explanationPanel.Name = "explanationPanel";
            this.explanationPanel.Size = new System.Drawing.Size(776, 329);
            this.explanationPanel.TabIndex = 7;
            // 
            // votePanel
            // 
            this.votePanel.Controls.Add(this.candidatesGrp);
            this.votePanel.Controls.Add(this.sumbitBtn);
            this.votePanel.Controls.Add(this.electionTitleLbl);
            this.votePanel.Controls.Add(this.electionLbl);
            this.votePanel.Location = new System.Drawing.Point(0, 0);
            this.votePanel.Name = "votePanel";
            this.votePanel.Size = new System.Drawing.Size(776, 329);
            this.votePanel.TabIndex = 2;
            // 
            // candidatesGrp
            // 
            this.candidatesGrp.Location = new System.Drawing.Point(33, 91);
            this.candidatesGrp.Name = "candidatesGrp";
            this.candidatesGrp.Size = new System.Drawing.Size(307, 205);
            this.candidatesGrp.TabIndex = 3;
            this.candidatesGrp.TabStop = false;
            this.candidatesGrp.Text = "Candidates";
            // 
            // sumbitBtn
            // 
            this.sumbitBtn.Location = new System.Drawing.Point(469, 138);
            this.sumbitBtn.Name = "sumbitBtn";
            this.sumbitBtn.Size = new System.Drawing.Size(217, 89);
            this.sumbitBtn.TabIndex = 2;
            this.sumbitBtn.Text = "button1";
            this.sumbitBtn.UseVisualStyleBackColor = true;
            this.sumbitBtn.Click += new System.EventHandler(this.sumbitBtn_Click);
            // 
            // electionTitleLbl
            // 
            this.electionTitleLbl.AutoSize = true;
            this.electionTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electionTitleLbl.Location = new System.Drawing.Point(412, 25);
            this.electionTitleLbl.Name = "electionTitleLbl";
            this.electionTitleLbl.Size = new System.Drawing.Size(22, 24);
            this.electionTitleLbl.TabIndex = 1;
            this.electionTitleLbl.Text = "n";
            // 
            // electionLbl
            // 
            this.electionLbl.AutoSize = true;
            this.electionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electionLbl.Location = new System.Drawing.Point(314, 25);
            this.electionLbl.Name = "electionLbl";
            this.electionLbl.Size = new System.Drawing.Size(92, 24);
            this.electionLbl.TabIndex = 0;
            this.electionLbl.Text = "Election:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "To vote:\r\nSelect the candidate you wish to vote for,\r\nThen select the \'Cast Vote\'" +
    " button.";
            // 
            // votingScreenImg
            // 
            this.votingScreenImg.Location = new System.Drawing.Point(412, 67);
            this.votingScreenImg.Name = "votingScreenImg";
            this.votingScreenImg.Size = new System.Drawing.Size(326, 195);
            this.votingScreenImg.TabIndex = 7;
            this.votingScreenImg.TabStop = false;
            // 
            // explanationTitleLbl
            // 
            this.explanationTitleLbl.AutoSize = true;
            this.explanationTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationTitleLbl.Location = new System.Drawing.Point(325, 12);
            this.explanationTitleLbl.Name = "explanationTitleLbl";
            this.explanationTitleLbl.Size = new System.Drawing.Size(132, 24);
            this.explanationTitleLbl.TabIndex = 6;
            this.explanationTitleLbl.Text = "How To Vote";
            // 
            // assessabilityLbl
            // 
            this.assessabilityLbl.AutoSize = true;
            this.assessabilityLbl.Location = new System.Drawing.Point(15, 299);
            this.assessabilityLbl.Name = "assessabilityLbl";
            this.assessabilityLbl.Size = new System.Drawing.Size(142, 17);
            this.assessabilityLbl.TabIndex = 5;
            this.assessabilityLbl.TabStop = true;
            this.assessabilityLbl.Text = "Assessability Options";
            // 
            // continueBtn
            // 
            this.continueBtn.Location = new System.Drawing.Point(677, 274);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(86, 42);
            this.continueBtn.TabIndex = 2;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // loginTitleLbl
            // 
            this.loginTitleLbl.AutoSize = true;
            this.loginTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitleLbl.Location = new System.Drawing.Point(318, 12);
            this.loginTitleLbl.Name = "loginTitleLbl";
            this.loginTitleLbl.Size = new System.Drawing.Size(145, 24);
            this.loginTitleLbl.TabIndex = 6;
            this.loginTitleLbl.Text = "E-voting Login";
            // 
            // fgtPwdLbl
            // 
            this.fgtPwdLbl.AutoSize = true;
            this.fgtPwdLbl.Location = new System.Drawing.Point(285, 246);
            this.fgtPwdLbl.Name = "fgtPwdLbl";
            this.fgtPwdLbl.Size = new System.Drawing.Size(122, 17);
            this.fgtPwdLbl.TabIndex = 5;
            this.fgtPwdLbl.TabStop = true;
            this.fgtPwdLbl.Text = "Forgot Password?";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(412, 233);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(86, 42);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // capatchaChk
            // 
            this.capatchaChk.AutoSize = true;
            this.capatchaChk.Location = new System.Drawing.Point(334, 189);
            this.capatchaChk.Name = "capatchaChk";
            this.capatchaChk.Size = new System.Drawing.Size(129, 21);
            this.capatchaChk.TabIndex = 4;
            this.capatchaChk.Text = "I am not a robot";
            this.capatchaChk.UseVisualStyleBackColor = true;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(285, 64);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(73, 17);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(285, 127);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 0;
            // 
            // confirmPanel
            // 
            this.confirmPanel.Controls.Add(this.voteConfirmBox);
            this.confirmPanel.Controls.Add(this.denyBtn);
            this.confirmPanel.Controls.Add(this.confirmBtn);
            this.confirmPanel.Controls.Add(this.label2);
            this.confirmPanel.Location = new System.Drawing.Point(12, 12);
            this.confirmPanel.Name = "confirmPanel";
            this.confirmPanel.Size = new System.Drawing.Size(776, 329);
            this.confirmPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are you sure you want to vote for:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(412, 235);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(110, 39);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Yes";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // denyBtn
            // 
            this.denyBtn.Location = new System.Drawing.Point(230, 235);
            this.denyBtn.Name = "denyBtn";
            this.denyBtn.Size = new System.Drawing.Size(110, 39);
            this.denyBtn.TabIndex = 3;
            this.denyBtn.Text = "No";
            this.denyBtn.UseVisualStyleBackColor = true;
            // 
            // voteConfirmBox
            // 
            this.voteConfirmBox.Location = new System.Drawing.Point(140, 91);
            this.voteConfirmBox.Name = "voteConfirmBox";
            this.voteConfirmBox.Size = new System.Drawing.Size(484, 119);
            this.voteConfirmBox.TabIndex = 4;
            this.voteConfirmBox.TabStop = false;
            this.voteConfirmBox.Text = "Vote Confirmation";
            // 
            // thankYouPanel
            // 
            this.thankYouPanel.Controls.Add(this.signOutBtn);
            this.thankYouPanel.Controls.Add(this.label3);
            this.thankYouPanel.Location = new System.Drawing.Point(12, 12);
            this.thankYouPanel.Name = "thankYouPanel";
            this.thankYouPanel.Size = new System.Drawing.Size(776, 329);
            this.thankYouPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thank You!";
            // 
            // signOutBtn
            // 
            this.signOutBtn.Location = new System.Drawing.Point(318, 175);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(146, 58);
            this.signOutBtn.TabIndex = 3;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thankYouPanel);
            this.Controls.Add(this.confirmPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.explanationPanel.ResumeLayout(false);
            this.explanationPanel.PerformLayout();
            this.votePanel.ResumeLayout(false);
            this.votePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.votingScreenImg)).EndInit();
            this.confirmPanel.ResumeLayout(false);
            this.confirmPanel.PerformLayout();
            this.thankYouPanel.ResumeLayout(false);
            this.thankYouPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label loginTitleLbl;
        private System.Windows.Forms.LinkLabel fgtPwdLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox capatchaChk;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel explanationPanel;
        private System.Windows.Forms.Label explanationTitleLbl;
        private System.Windows.Forms.LinkLabel assessabilityLbl;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox votingScreenImg;
        private System.Windows.Forms.Panel votePanel;
        private System.Windows.Forms.GroupBox candidatesGrp;
        private System.Windows.Forms.Button sumbitBtn;
        private System.Windows.Forms.Label electionTitleLbl;
        private System.Windows.Forms.Label electionLbl;
        private System.Windows.Forms.Panel confirmPanel;
        private System.Windows.Forms.GroupBox voteConfirmBox;
        private System.Windows.Forms.Button denyBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel thankYouPanel;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.Label label3;
    }
}

