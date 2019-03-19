namespace EVotingSystem
{
    partial class UserGUI
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
            this.explanationPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assessabilityLbl = new System.Windows.Forms.LinkLabel();
            this.continueBtn = new System.Windows.Forms.Button();
            this.explanationTitle = new System.Windows.Forms.Label();
            this.votePanel = new System.Windows.Forms.Panel();
            this.selectionErrLbl = new System.Windows.Forms.Label();
            this.candidatesGrp = new System.Windows.Forms.GroupBox();
            this.electionTitleLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.confirmPanel = new System.Windows.Forms.Panel();
            this.voteConfirmBox = new System.Windows.Forms.GroupBox();
            this.denyBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.confirmTitleLbl = new System.Windows.Forms.Label();
            this.thankYouPanel = new System.Windows.Forms.Panel();
            this.signOutLbl = new System.Windows.Forms.Button();
            this.thankYouLbl = new System.Windows.Forms.Label();
            this.electionChoices = new System.Windows.Forms.ListBox();
            this.explanationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.votePanel.SuspendLayout();
            this.confirmPanel.SuspendLayout();
            this.voteConfirmBox.SuspendLayout();
            this.thankYouPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // explanationPanel
            // 
            this.explanationPanel.Controls.Add(this.pictureBox1);
            this.explanationPanel.Controls.Add(this.label1);
            this.explanationPanel.Controls.Add(this.assessabilityLbl);
            this.explanationPanel.Controls.Add(this.continueBtn);
            this.explanationPanel.Controls.Add(this.explanationTitle);
            this.explanationPanel.Location = new System.Drawing.Point(10, 11);
            this.explanationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.explanationPanel.Name = "explanationPanel";
            this.explanationPanel.Size = new System.Drawing.Size(581, 267);
            this.explanationPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(328, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 141);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "To Vote:\r\nSelect the check box displaying your desired candidate,\r\nThen select th" +
    "e \'Submit\' button.";
            // 
            // assessabilityLbl
            // 
            this.assessabilityLbl.AutoSize = true;
            this.assessabilityLbl.Location = new System.Drawing.Point(9, 244);
            this.assessabilityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assessabilityLbl.Name = "assessabilityLbl";
            this.assessabilityLbl.Size = new System.Drawing.Size(66, 13);
            this.assessabilityLbl.TabIndex = 2;
            this.assessabilityLbl.TabStop = true;
            this.assessabilityLbl.Text = "Assessability";
            // 
            // continueBtn
            // 
            this.continueBtn.Location = new System.Drawing.Point(488, 221);
            this.continueBtn.Margin = new System.Windows.Forms.Padding(2);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(84, 37);
            this.continueBtn.TabIndex = 1;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // explanationTitle
            // 
            this.explanationTitle.AutoSize = true;
            this.explanationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.explanationTitle.Location = new System.Drawing.Point(242, 19);
            this.explanationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.explanationTitle.Name = "explanationTitle";
            this.explanationTitle.Size = new System.Drawing.Size(106, 18);
            this.explanationTitle.TabIndex = 0;
            this.explanationTitle.Text = "How To Vote";
            // 
            // votePanel
            // 
            this.votePanel.Controls.Add(this.selectionErrLbl);
            this.votePanel.Controls.Add(this.candidatesGrp);
            this.votePanel.Controls.Add(this.electionTitleLbl);
            this.votePanel.Controls.Add(this.submitBtn);
            this.votePanel.Location = new System.Drawing.Point(611, 10);
            this.votePanel.Margin = new System.Windows.Forms.Padding(2);
            this.votePanel.Name = "votePanel";
            this.votePanel.Size = new System.Drawing.Size(581, 267);
            this.votePanel.TabIndex = 5;
            // 
            // selectionErrLbl
            // 
            this.selectionErrLbl.AutoSize = true;
            this.selectionErrLbl.ForeColor = System.Drawing.Color.Red;
            this.selectionErrLbl.Location = new System.Drawing.Point(368, 175);
            this.selectionErrLbl.Name = "selectionErrLbl";
            this.selectionErrLbl.Size = new System.Drawing.Size(150, 13);
            this.selectionErrLbl.TabIndex = 4;
            this.selectionErrLbl.Text = "Select at least ONE candidate";
            this.selectionErrLbl.Visible = false;
            // 
            // candidatesGrp
            // 
            this.candidatesGrp.Location = new System.Drawing.Point(44, 67);
            this.candidatesGrp.Margin = new System.Windows.Forms.Padding(2);
            this.candidatesGrp.Name = "candidatesGrp";
            this.candidatesGrp.Padding = new System.Windows.Forms.Padding(2);
            this.candidatesGrp.Size = new System.Drawing.Size(253, 152);
            this.candidatesGrp.TabIndex = 3;
            this.candidatesGrp.TabStop = false;
            this.candidatesGrp.Text = "Candidates";
            // 
            // electionTitleLbl
            // 
            this.electionTitleLbl.AutoSize = true;
            this.electionTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electionTitleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.electionTitleLbl.Location = new System.Drawing.Point(280, 20);
            this.electionTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.electionTitleLbl.Name = "electionTitleLbl";
            this.electionTitleLbl.Size = new System.Drawing.Size(17, 18);
            this.electionTitleLbl.TabIndex = 2;
            this.electionTitleLbl.Text = "n";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(362, 98);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(165, 70);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // confirmPanel
            // 
            this.confirmPanel.Controls.Add(this.voteConfirmBox);
            this.confirmPanel.Controls.Add(this.denyBtn);
            this.confirmPanel.Controls.Add(this.confirmBtn);
            this.confirmPanel.Controls.Add(this.confirmTitleLbl);
            this.confirmPanel.Location = new System.Drawing.Point(10, 314);
            this.confirmPanel.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPanel.Name = "confirmPanel";
            this.confirmPanel.Size = new System.Drawing.Size(581, 267);
            this.confirmPanel.TabIndex = 5;
            // 
            // voteConfirmBox
            // 
            this.voteConfirmBox.Controls.Add(this.electionChoices);
            this.voteConfirmBox.Location = new System.Drawing.Point(111, 78);
            this.voteConfirmBox.Margin = new System.Windows.Forms.Padding(2);
            this.voteConfirmBox.Name = "voteConfirmBox";
            this.voteConfirmBox.Padding = new System.Windows.Forms.Padding(2);
            this.voteConfirmBox.Size = new System.Drawing.Size(351, 96);
            this.voteConfirmBox.TabIndex = 3;
            this.voteConfirmBox.TabStop = false;
            this.voteConfirmBox.Text = "Election Choices";
            // 
            // denyBtn
            // 
            this.denyBtn.Location = new System.Drawing.Point(166, 192);
            this.denyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.denyBtn.Name = "denyBtn";
            this.denyBtn.Size = new System.Drawing.Size(84, 37);
            this.denyBtn.TabIndex = 2;
            this.denyBtn.Text = "No";
            this.denyBtn.UseVisualStyleBackColor = true;
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(322, 192);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(84, 37);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "Yes";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // confirmTitleLbl
            // 
            this.confirmTitleLbl.AutoSize = true;
            this.confirmTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTitleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmTitleLbl.Location = new System.Drawing.Point(164, 44);
            this.confirmTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmTitleLbl.Name = "confirmTitleLbl";
            this.confirmTitleLbl.Size = new System.Drawing.Size(263, 18);
            this.confirmTitleLbl.TabIndex = 0;
            this.confirmTitleLbl.Text = "Are you sure you want to vote for:";
            // 
            // thankYouPanel
            // 
            this.thankYouPanel.Controls.Add(this.signOutLbl);
            this.thankYouPanel.Controls.Add(this.thankYouLbl);
            this.thankYouPanel.Location = new System.Drawing.Point(611, 314);
            this.thankYouPanel.Margin = new System.Windows.Forms.Padding(2);
            this.thankYouPanel.Name = "thankYouPanel";
            this.thankYouPanel.Size = new System.Drawing.Size(581, 267);
            this.thankYouPanel.TabIndex = 6;
            // 
            // signOutLbl
            // 
            this.signOutLbl.Location = new System.Drawing.Point(245, 141);
            this.signOutLbl.Margin = new System.Windows.Forms.Padding(2);
            this.signOutLbl.Name = "signOutLbl";
            this.signOutLbl.Size = new System.Drawing.Size(107, 54);
            this.signOutLbl.TabIndex = 1;
            this.signOutLbl.Text = "End Session";
            this.signOutLbl.UseVisualStyleBackColor = true;
            this.signOutLbl.Click += new System.EventHandler(this.signOutLbl_Click);
            // 
            // thankYouLbl
            // 
            this.thankYouLbl.AutoSize = true;
            this.thankYouLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thankYouLbl.Location = new System.Drawing.Point(255, 78);
            this.thankYouLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thankYouLbl.Name = "thankYouLbl";
            this.thankYouLbl.Size = new System.Drawing.Size(92, 18);
            this.thankYouLbl.TabIndex = 0;
            this.thankYouLbl.Text = "Thank You!";
            // 
            // electionChoices
            // 
            this.electionChoices.BackColor = System.Drawing.SystemColors.Control;
            this.electionChoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.electionChoices.FormattingEnabled = true;
            this.electionChoices.Location = new System.Drawing.Point(13, 17);
            this.electionChoices.Name = "electionChoices";
            this.electionChoices.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.electionChoices.Size = new System.Drawing.Size(333, 65);
            this.electionChoices.TabIndex = 0;
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 286);
            this.Controls.Add(this.thankYouPanel);
            this.Controls.Add(this.confirmPanel);
            this.Controls.Add(this.votePanel);
            this.Controls.Add(this.explanationPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserGUI_Load);
            this.explanationPanel.ResumeLayout(false);
            this.explanationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.votePanel.ResumeLayout(false);
            this.votePanel.PerformLayout();
            this.confirmPanel.ResumeLayout(false);
            this.confirmPanel.PerformLayout();
            this.voteConfirmBox.ResumeLayout(false);
            this.thankYouPanel.ResumeLayout(false);
            this.thankYouPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel explanationPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel assessabilityLbl;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label explanationTitle;
        private System.Windows.Forms.Panel votePanel;
        private System.Windows.Forms.GroupBox candidatesGrp;
        private System.Windows.Forms.Label electionTitleLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel confirmPanel;
        private System.Windows.Forms.GroupBox voteConfirmBox;
        private System.Windows.Forms.Button denyBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label confirmTitleLbl;
        private System.Windows.Forms.Panel thankYouPanel;
        private System.Windows.Forms.Button signOutLbl;
        private System.Windows.Forms.Label thankYouLbl;
        private System.Windows.Forms.Label selectionErrLbl;
        private System.Windows.Forms.ListBox electionChoices;
    }
}