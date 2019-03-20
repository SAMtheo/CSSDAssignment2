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
            this.explanationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.votePanel.SuspendLayout();
            this.confirmPanel.SuspendLayout();
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
            this.explanationPanel.Location = new System.Drawing.Point(13, 14);
            this.explanationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.explanationPanel.Name = "explanationPanel";
            this.explanationPanel.Size = new System.Drawing.Size(775, 329);
            this.explanationPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(437, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 174);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "To Vote:\r\nSelect the check box displaying your desired candidate,\r\nThen select th" +
    "e \'Submit\' button.";
            // 
            // assessabilityLbl
            // 
            this.assessabilityLbl.AutoSize = true;
            this.assessabilityLbl.Location = new System.Drawing.Point(12, 300);
            this.assessabilityLbl.Name = "assessabilityLbl";
            this.assessabilityLbl.Size = new System.Drawing.Size(89, 17);
            this.assessabilityLbl.TabIndex = 2;
            this.assessabilityLbl.TabStop = true;
            this.assessabilityLbl.Text = "Assessability";
            // 
            // continueBtn
            // 
            this.continueBtn.Location = new System.Drawing.Point(651, 272);
            this.continueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(112, 46);
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
            this.explanationTitle.Location = new System.Drawing.Point(323, 23);
            this.explanationTitle.Name = "explanationTitle";
            this.explanationTitle.Size = new System.Drawing.Size(132, 24);
            this.explanationTitle.TabIndex = 0;
            this.explanationTitle.Text = "How To Vote";
            // 
            // votePanel
            // 
            this.votePanel.Controls.Add(this.selectionErrLbl);
            this.votePanel.Controls.Add(this.candidatesGrp);
            this.votePanel.Controls.Add(this.electionTitleLbl);
            this.votePanel.Controls.Add(this.submitBtn);
            this.votePanel.Location = new System.Drawing.Point(815, 12);
            this.votePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.votePanel.Name = "votePanel";
            this.votePanel.Size = new System.Drawing.Size(775, 329);
            this.votePanel.TabIndex = 5;
            // 
            // selectionErrLbl
            // 
            this.selectionErrLbl.AutoSize = true;
            this.selectionErrLbl.ForeColor = System.Drawing.Color.Red;
            this.selectionErrLbl.Location = new System.Drawing.Point(491, 215);
            this.selectionErrLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectionErrLbl.Name = "selectionErrLbl";
            this.selectionErrLbl.Size = new System.Drawing.Size(197, 17);
            this.selectionErrLbl.TabIndex = 4;
            this.selectionErrLbl.Text = "Select at least ONE candidate";
            this.selectionErrLbl.Visible = false;
            // 
            // candidatesGrp
            // 
            this.candidatesGrp.Location = new System.Drawing.Point(59, 82);
            this.candidatesGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.candidatesGrp.Name = "candidatesGrp";
            this.candidatesGrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.candidatesGrp.Size = new System.Drawing.Size(337, 187);
            this.candidatesGrp.TabIndex = 3;
            this.candidatesGrp.TabStop = false;
            this.candidatesGrp.Text = "Candidates";
            // 
            // electionTitleLbl
            // 
            this.electionTitleLbl.AutoSize = true;
            this.electionTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electionTitleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.electionTitleLbl.Location = new System.Drawing.Point(373, 25);
            this.electionTitleLbl.Name = "electionTitleLbl";
            this.electionTitleLbl.Size = new System.Drawing.Size(22, 24);
            this.electionTitleLbl.TabIndex = 2;
            this.electionTitleLbl.Text = "n";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(483, 121);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(220, 86);
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
            this.confirmPanel.Location = new System.Drawing.Point(13, 386);
            this.confirmPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPanel.Name = "confirmPanel";
            this.confirmPanel.Size = new System.Drawing.Size(775, 329);
            this.confirmPanel.TabIndex = 5;
            // 
            // voteConfirmBox
            // 
            this.voteConfirmBox.Location = new System.Drawing.Point(148, 96);
            this.voteConfirmBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voteConfirmBox.Name = "voteConfirmBox";
            this.voteConfirmBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voteConfirmBox.Size = new System.Drawing.Size(468, 118);
            this.voteConfirmBox.TabIndex = 3;
            this.voteConfirmBox.TabStop = false;
            this.voteConfirmBox.Text = "Election Choices";
            // 
            // denyBtn
            // 
            this.denyBtn.Location = new System.Drawing.Point(221, 236);
            this.denyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denyBtn.Name = "denyBtn";
            this.denyBtn.Size = new System.Drawing.Size(112, 46);
            this.denyBtn.TabIndex = 2;
            this.denyBtn.Text = "No";
            this.denyBtn.UseVisualStyleBackColor = true;
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(429, 236);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(112, 46);
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
            this.confirmTitleLbl.Location = new System.Drawing.Point(219, 54);
            this.confirmTitleLbl.Name = "confirmTitleLbl";
            this.confirmTitleLbl.Size = new System.Drawing.Size(323, 24);
            this.confirmTitleLbl.TabIndex = 0;
            this.confirmTitleLbl.Text = "Are you sure you want to vote for:";
            // 
            // thankYouPanel
            // 
            this.thankYouPanel.Controls.Add(this.signOutLbl);
            this.thankYouPanel.Controls.Add(this.thankYouLbl);
            this.thankYouPanel.Location = new System.Drawing.Point(815, 386);
            this.thankYouPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thankYouPanel.Name = "thankYouPanel";
            this.thankYouPanel.Size = new System.Drawing.Size(775, 329);
            this.thankYouPanel.TabIndex = 6;
            // 
            // signOutLbl
            // 
            this.signOutLbl.Location = new System.Drawing.Point(327, 174);
            this.signOutLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signOutLbl.Name = "signOutLbl";
            this.signOutLbl.Size = new System.Drawing.Size(143, 66);
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
            this.thankYouLbl.Location = new System.Drawing.Point(340, 96);
            this.thankYouLbl.Name = "thankYouLbl";
            this.thankYouLbl.Size = new System.Drawing.Size(117, 24);
            this.thankYouLbl.TabIndex = 0;
            this.thankYouLbl.Text = "Thank You!";
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 354);
            this.Controls.Add(this.thankYouPanel);
            this.Controls.Add(this.confirmPanel);
            this.Controls.Add(this.votePanel);
            this.Controls.Add(this.explanationPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}