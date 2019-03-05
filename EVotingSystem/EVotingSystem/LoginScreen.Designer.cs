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
            this.errorLbl = new System.Windows.Forms.Label();
            this.loginTitleLbl = new System.Windows.Forms.Label();
            this.fgtPwdLbl = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.capatchaChk = new System.Windows.Forms.CheckBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.errorLbl);
            this.loginPanel.Controls.Add(this.loginTitleLbl);
            this.loginPanel.Controls.Add(this.fgtPwdLbl);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.capatchaChk);
            this.loginPanel.Controls.Add(this.usernameLbl);
            this.loginPanel.Controls.Add(this.passwordLbl);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.usernameBox);
            this.loginPanel.Location = new System.Drawing.Point(9, 10);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(582, 267);
            this.loginPanel.TabIndex = 1;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(222, 140);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(42, 13);
            this.errorLbl.TabIndex = 7;
            this.errorLbl.Text = "errorLbl";
            this.errorLbl.Visible = false;
            // 
            // loginTitleLbl
            // 
            this.loginTitleLbl.AutoSize = true;
            this.loginTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitleLbl.Location = new System.Drawing.Point(238, 10);
            this.loginTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginTitleLbl.Name = "loginTitleLbl";
            this.loginTitleLbl.Size = new System.Drawing.Size(116, 18);
            this.loginTitleLbl.TabIndex = 6;
            this.loginTitleLbl.Text = "E-voting Login";
            // 
            // fgtPwdLbl
            // 
            this.fgtPwdLbl.AutoSize = true;
            this.fgtPwdLbl.Location = new System.Drawing.Point(213, 216);
            this.fgtPwdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fgtPwdLbl.Name = "fgtPwdLbl";
            this.fgtPwdLbl.Size = new System.Drawing.Size(92, 13);
            this.fgtPwdLbl.TabIndex = 5;
            this.fgtPwdLbl.TabStop = true;
            this.fgtPwdLbl.Text = "Forgot Password?";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(309, 206);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(64, 34);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // capatchaChk
            // 
            this.capatchaChk.AutoSize = true;
            this.capatchaChk.Location = new System.Drawing.Point(250, 170);
            this.capatchaChk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.capatchaChk.Name = "capatchaChk";
            this.capatchaChk.Size = new System.Drawing.Size(100, 17);
            this.capatchaChk.TabIndex = 4;
            this.capatchaChk.Text = "I am not a robot";
            this.capatchaChk.UseVisualStyleBackColor = true;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(214, 52);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(214, 103);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(216, 119);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(158, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(216, 68);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(158, 20);
            this.usernameBox.TabIndex = 0;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label errorLbl;
    }
}

