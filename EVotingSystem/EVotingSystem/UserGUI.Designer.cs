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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGUI));
            this.explanationPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.explanationlbl = new System.Windows.Forms.Label();
            this.accessabilityLbl = new System.Windows.Forms.LinkLabel();
            this.continueBtn = new System.Windows.Forms.Button();
            this.explanationTitle = new System.Windows.Forms.Label();
            this.votePanel = new System.Windows.Forms.Panel();
            this.voteAccessibilityLbl = new System.Windows.Forms.LinkLabel();
            this.selectionErrLbl = new System.Windows.Forms.Label();
            this.candidatesGrp = new System.Windows.Forms.GroupBox();
            this.electionTitleLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.confirmPanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.voteConfirmBox = new System.Windows.Forms.GroupBox();
            this.denyBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.confirmTitleLbl = new System.Windows.Forms.Label();
            this.thankYouPanel = new System.Windows.Forms.Panel();
            this.signOutLbl = new System.Windows.Forms.Button();
            this.thankYouLbl = new System.Windows.Forms.Label();
            this.accessibilityPanel = new System.Windows.Forms.Panel();
            this.textSizeExample = new System.Windows.Forms.Label();
            this.colorBlindCheckBox = new System.Windows.Forms.CheckBox();
            this.textSizeTracker = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.accessibilityApplyBtn = new System.Windows.Forms.Button();
            this.accessibilityBackBtn = new System.Windows.Forms.Button();
            this.accessibilityTitleLbl = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.explanationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.votePanel.SuspendLayout();
            this.confirmPanel.SuspendLayout();
            this.thankYouPanel.SuspendLayout();
            this.accessibilityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // explanationPanel
            // 
            this.explanationPanel.Controls.Add(this.pictureBox1);
            this.explanationPanel.Controls.Add(this.explanationlbl);
            this.explanationPanel.Controls.Add(this.accessabilityLbl);
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
            // explanationlbl
            // 
            this.explanationlbl.AutoSize = true;
            this.explanationlbl.Location = new System.Drawing.Point(29, 139);
            this.explanationlbl.MaximumSize = new System.Drawing.Size(400, 0);
            this.explanationlbl.Name = "explanationlbl";
            this.explanationlbl.Size = new System.Drawing.Size(358, 51);
            this.explanationlbl.TabIndex = 3;
            this.explanationlbl.Text = "To Vote:\r\nSelect the check box displaying your desired candidate,\r\nThen select th" +
    "e \'Submit\' button.";
            // 
            // accessabilityLbl
            // 
            this.accessabilityLbl.AutoSize = true;
            this.accessabilityLbl.Location = new System.Drawing.Point(12, 300);
            this.accessabilityLbl.Name = "accessabilityLbl";
            this.accessabilityLbl.Size = new System.Drawing.Size(89, 17);
            this.accessabilityLbl.TabIndex = 2;
            this.accessabilityLbl.TabStop = true;
            this.accessabilityLbl.Text = "Accessability";
            this.accessabilityLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accessabilityLbl_LinkClicked);
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
            this.explanationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.explanationTitle.Location = new System.Drawing.Point(323, 23);
            this.explanationTitle.Name = "explanationTitle";
            this.explanationTitle.Size = new System.Drawing.Size(164, 29);
            this.explanationTitle.TabIndex = 0;
            this.explanationTitle.Text = "How To Vote";
            // 
            // votePanel
            // 
            this.votePanel.Controls.Add(this.voteAccessibilityLbl);
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
            // voteAccessibilityLbl
            // 
            this.voteAccessibilityLbl.AutoSize = true;
            this.voteAccessibilityLbl.Location = new System.Drawing.Point(14, 302);
            this.voteAccessibilityLbl.Name = "voteAccessibilityLbl";
            this.voteAccessibilityLbl.Size = new System.Drawing.Size(89, 17);
            this.voteAccessibilityLbl.TabIndex = 5;
            this.voteAccessibilityLbl.TabStop = true;
            this.voteAccessibilityLbl.Text = "Accessability";
            this.voteAccessibilityLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accessabilityLbl_LinkClicked);
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
            this.electionTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electionTitleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.electionTitleLbl.Location = new System.Drawing.Point(288, 25);
            this.electionTitleLbl.Name = "electionTitleLbl";
            this.electionTitleLbl.Size = new System.Drawing.Size(27, 29);
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
            this.confirmPanel.Controls.Add(this.linkLabel2);
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
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 302);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(89, 17);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Accessability";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accessabilityLbl_LinkClicked);
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
            this.confirmTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTitleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmTitleLbl.Location = new System.Drawing.Point(219, 54);
            this.confirmTitleLbl.Name = "confirmTitleLbl";
            this.confirmTitleLbl.Size = new System.Drawing.Size(398, 29);
            this.confirmTitleLbl.TabIndex = 0;
            this.confirmTitleLbl.Text = "Are you sure you want to vote for:";
            // 
            // thankYouPanel
            // 
            this.thankYouPanel.Controls.Add(this.signOutLbl);
            this.thankYouPanel.Controls.Add(this.thankYouLbl);
            this.thankYouPanel.Location = new System.Drawing.Point(13, 743);
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
            this.thankYouLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thankYouLbl.Location = new System.Drawing.Point(340, 96);
            this.thankYouLbl.Name = "thankYouLbl";
            this.thankYouLbl.Size = new System.Drawing.Size(145, 29);
            this.thankYouLbl.TabIndex = 0;
            this.thankYouLbl.Text = "Thank You!";
            // 
            // accessibilityPanel
            // 
            this.accessibilityPanel.Controls.Add(this.textSizeExample);
            this.accessibilityPanel.Controls.Add(this.colorBlindCheckBox);
            this.accessibilityPanel.Controls.Add(this.textSizeTracker);
            this.accessibilityPanel.Controls.Add(this.label2);
            this.accessibilityPanel.Controls.Add(this.accessibilityApplyBtn);
            this.accessibilityPanel.Controls.Add(this.accessibilityBackBtn);
            this.accessibilityPanel.Controls.Add(this.accessibilityTitleLbl);
            this.accessibilityPanel.Location = new System.Drawing.Point(815, 386);
            this.accessibilityPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accessibilityPanel.Name = "accessibilityPanel";
            this.accessibilityPanel.Size = new System.Drawing.Size(775, 329);
            this.accessibilityPanel.TabIndex = 7;
            // 
            // textSizeExample
            // 
            this.textSizeExample.AutoSize = true;
            this.textSizeExample.Location = new System.Drawing.Point(491, 131);
            this.textSizeExample.Name = "textSizeExample";
            this.textSizeExample.Size = new System.Drawing.Size(61, 17);
            this.textSizeExample.TabIndex = 8;
            this.textSizeExample.Text = "Example";
            // 
            // colorBlindCheckBox
            // 
            this.colorBlindCheckBox.AutoSize = true;
            this.colorBlindCheckBox.Location = new System.Drawing.Point(321, 193);
            this.colorBlindCheckBox.Name = "colorBlindCheckBox";
            this.colorBlindCheckBox.Size = new System.Drawing.Size(145, 21);
            this.colorBlindCheckBox.TabIndex = 7;
            this.colorBlindCheckBox.Text = "Colour Blind Mode";
            this.colorBlindCheckBox.UseVisualStyleBackColor = true;
            // 
            // textSizeTracker
            // 
            this.textSizeTracker.Location = new System.Drawing.Point(337, 120);
            this.textSizeTracker.Name = "textSizeTracker";
            this.textSizeTracker.Size = new System.Drawing.Size(104, 56);
            this.textSizeTracker.TabIndex = 5;
            this.textSizeTracker.Scroll += new System.EventHandler(this.textSizeTracker_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(244, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text Size:";
            // 
            // accessibilityApplyBtn
            // 
            this.accessibilityApplyBtn.Location = new System.Drawing.Point(623, 238);
            this.accessibilityApplyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accessibilityApplyBtn.Name = "accessibilityApplyBtn";
            this.accessibilityApplyBtn.Size = new System.Drawing.Size(93, 44);
            this.accessibilityApplyBtn.TabIndex = 2;
            this.accessibilityApplyBtn.Text = "Apply";
            this.accessibilityApplyBtn.UseVisualStyleBackColor = true;
            this.accessibilityApplyBtn.Click += new System.EventHandler(this.accessibilityApplyBtn_Click);
            // 
            // accessibilityBackBtn
            // 
            this.accessibilityBackBtn.Location = new System.Drawing.Point(59, 238);
            this.accessibilityBackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accessibilityBackBtn.Name = "accessibilityBackBtn";
            this.accessibilityBackBtn.Size = new System.Drawing.Size(93, 44);
            this.accessibilityBackBtn.TabIndex = 1;
            this.accessibilityBackBtn.Text = "Back";
            this.accessibilityBackBtn.UseVisualStyleBackColor = true;
            this.accessibilityBackBtn.Click += new System.EventHandler(this.accessibilityBackBtn_Click);
            // 
            // accessibilityTitleLbl
            // 
            this.accessibilityTitleLbl.AutoSize = true;
            this.accessibilityTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessibilityTitleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accessibilityTitleLbl.Location = new System.Drawing.Point(333, 54);
            this.accessibilityTitleLbl.Name = "accessibilityTitleLbl";
            this.accessibilityTitleLbl.Size = new System.Drawing.Size(158, 29);
            this.accessibilityTitleLbl.TabIndex = 0;
            this.accessibilityTitleLbl.Text = "Assessibility";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.Location = new System.Drawing.Point(1123, 873);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(979, 851);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sam: Green Party";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(908, 851);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 60);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(908, 917);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 60);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(979, 917);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mike: UKIP";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Location = new System.Drawing.Point(1123, 939);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 1055);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.accessibilityPanel);
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
            this.accessibilityPanel.ResumeLayout(false);
            this.accessibilityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel explanationPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label explanationlbl;
        private System.Windows.Forms.LinkLabel accessabilityLbl;
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
        private System.Windows.Forms.Panel accessibilityPanel;
        private System.Windows.Forms.TrackBar textSizeTracker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accessibilityApplyBtn;
        private System.Windows.Forms.Button accessibilityBackBtn;
        private System.Windows.Forms.Label accessibilityTitleLbl;
        private System.Windows.Forms.LinkLabel voteAccessibilityLbl;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label textSizeExample;
        private System.Windows.Forms.CheckBox colorBlindCheckBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}