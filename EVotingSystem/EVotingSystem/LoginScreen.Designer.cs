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
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginTitleLbl);
            this.loginPanel.Controls.Add(this.fgtPwdLbl);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.capatchaChk);
            this.loginPanel.Controls.Add(this.usernameLbl);
            this.loginPanel.Controls.Add(this.passwordLbl);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.usernameBox);
            this.loginPanel.Location = new System.Drawing.Point(12, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(776, 329);
            this.loginPanel.TabIndex = 1;
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
            this.fgtPwdLbl.Location = new System.Drawing.Point(284, 246);
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
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(288, 147);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(210, 22);
            this.passwordBox.TabIndex = 1;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(288, 84);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(210, 22);
            this.usernameBox.TabIndex = 0;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginScreen";
            this.Text = "Login";
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
    }
}

