namespace EVotingSystem
{
    partial class AdminGUI
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
            this.components = new System.ComponentModel.Container();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resultTitle = new System.Windows.Forms.Label();
            this.landingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.seeOnSiteBtn = new System.Windows.Forms.Button();
            this.seeResultsBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.landingTitle = new System.Windows.Forms.Label();
            this.onSitePanel = new System.Windows.Forms.Panel();
            this.voterView = new System.Windows.Forms.DataGridView();
            this.onSiteBack = new System.Windows.Forms.Button();
            this.onSiteTitle = new System.Windows.Forms.Label();
            this.unlockBtn = new System.Windows.Forms.Button();
            this.setIneligibleBtn = new System.Windows.Forms.Button();
            this.accountRegistryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.landingPanel.SuspendLayout();
            this.onSitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRegistryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.resultBack);
            this.resultPanel.Controls.Add(this.dataGridView1);
            this.resultPanel.Controls.Add(this.resultTitle);
            this.resultPanel.Location = new System.Drawing.Point(9, 10);
            this.resultPanel.Margin = new System.Windows.Forms.Padding(2);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(581, 268);
            this.resultPanel.TabIndex = 1;
            // 
            // resultBack
            // 
            this.resultBack.Location = new System.Drawing.Point(487, 228);
            this.resultBack.Name = "resultBack";
            this.resultBack.Size = new System.Drawing.Size(91, 37);
            this.resultBack.TabIndex = 2;
            this.resultBack.Text = "Back";
            this.resultBack.UseVisualStyleBackColor = true;
            this.resultBack.Click += new System.EventHandler(this.resultBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(306, 185);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // resultTitle
            // 
            this.resultTitle.AutoSize = true;
            this.resultTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultTitle.Location = new System.Drawing.Point(242, 18);
            this.resultTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultTitle.Name = "resultTitle";
            this.resultTitle.Size = new System.Drawing.Size(65, 18);
            this.resultTitle.TabIndex = 0;
            this.resultTitle.Text = "Results";
            this.resultTitle.Click += new System.EventHandler(this.adminTitle_Click);
            // 
            // landingPanel
            // 
            this.landingPanel.Controls.Add(this.label1);
            this.landingPanel.Controls.Add(this.seeOnSiteBtn);
            this.landingPanel.Controls.Add(this.seeResultsBtn);
            this.landingPanel.Controls.Add(this.logOutBtn);
            this.landingPanel.Controls.Add(this.landingTitle);
            this.landingPanel.Location = new System.Drawing.Point(611, 10);
            this.landingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.landingPanel.Name = "landingPanel";
            this.landingPanel.Size = new System.Drawing.Size(581, 268);
            this.landingPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Some text \r\nI guess\r\nThere is a whole lot of dead space here with nothing to do i" +
    "n it \r\nOh hi Mark \r\n";
            // 
            // seeOnSiteBtn
            // 
            this.seeOnSiteBtn.Location = new System.Drawing.Point(78, 63);
            this.seeOnSiteBtn.Name = "seeOnSiteBtn";
            this.seeOnSiteBtn.Size = new System.Drawing.Size(139, 69);
            this.seeOnSiteBtn.TabIndex = 3;
            this.seeOnSiteBtn.Text = "Onsite";
            this.seeOnSiteBtn.UseVisualStyleBackColor = true;
            this.seeOnSiteBtn.Visible = false;
            this.seeOnSiteBtn.Click += new System.EventHandler(this.seeOnSiteBtn_Click);
            // 
            // seeResultsBtn
            // 
            this.seeResultsBtn.Location = new System.Drawing.Point(78, 138);
            this.seeResultsBtn.Name = "seeResultsBtn";
            this.seeResultsBtn.Size = new System.Drawing.Size(139, 69);
            this.seeResultsBtn.TabIndex = 2;
            this.seeResultsBtn.Text = "Results";
            this.seeResultsBtn.UseVisualStyleBackColor = true;
            this.seeResultsBtn.Visible = false;
            this.seeResultsBtn.Click += new System.EventHandler(this.seeResultsBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(487, 228);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(91, 37);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // landingTitle
            // 
            this.landingTitle.AutoSize = true;
            this.landingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.landingTitle.Location = new System.Drawing.Point(242, 18);
            this.landingTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.landingTitle.Name = "landingTitle";
            this.landingTitle.Size = new System.Drawing.Size(66, 18);
            this.landingTitle.TabIndex = 0;
            this.landingTitle.Text = "Landing";
            // 
            // onSitePanel
            // 
            this.onSitePanel.Controls.Add(this.setIneligibleBtn);
            this.onSitePanel.Controls.Add(this.unlockBtn);
            this.onSitePanel.Controls.Add(this.voterView);
            this.onSitePanel.Controls.Add(this.onSiteBack);
            this.onSitePanel.Controls.Add(this.onSiteTitle);
            this.onSitePanel.Location = new System.Drawing.Point(9, 295);
            this.onSitePanel.Margin = new System.Windows.Forms.Padding(2);
            this.onSitePanel.Name = "onSitePanel";
            this.onSitePanel.Size = new System.Drawing.Size(581, 268);
            this.onSitePanel.TabIndex = 3;
            // 
            // voterView
            // 
            this.voterView.AllowUserToAddRows = false;
            this.voterView.AllowUserToDeleteRows = false;
            this.voterView.AllowUserToResizeColumns = false;
            this.voterView.AllowUserToResizeRows = false;
            this.voterView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.voterView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.voterView.Location = new System.Drawing.Point(40, 51);
            this.voterView.Name = "voterView";
            this.voterView.ReadOnly = true;
            this.voterView.RowHeadersVisible = false;
            this.voterView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.voterView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.voterView.Size = new System.Drawing.Size(266, 150);
            this.voterView.TabIndex = 4;
            // 
            // onSiteBack
            // 
            this.onSiteBack.Location = new System.Drawing.Point(487, 228);
            this.onSiteBack.Name = "onSiteBack";
            this.onSiteBack.Size = new System.Drawing.Size(91, 37);
            this.onSiteBack.TabIndex = 3;
            this.onSiteBack.Text = "Back";
            this.onSiteBack.UseVisualStyleBackColor = true;
            this.onSiteBack.Click += new System.EventHandler(this.onSiteBack_Click);
            // 
            // onSiteTitle
            // 
            this.onSiteTitle.AutoSize = true;
            this.onSiteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onSiteTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onSiteTitle.Location = new System.Drawing.Point(242, 18);
            this.onSiteTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onSiteTitle.Name = "onSiteTitle";
            this.onSiteTitle.Size = new System.Drawing.Size(64, 18);
            this.onSiteTitle.TabIndex = 0;
            this.onSiteTitle.Text = "OnSite ";
            // 
            // unlockBtn
            // 
            this.unlockBtn.Location = new System.Drawing.Point(364, 51);
            this.unlockBtn.Name = "unlockBtn";
            this.unlockBtn.Size = new System.Drawing.Size(139, 23);
            this.unlockBtn.TabIndex = 5;
            this.unlockBtn.Text = "Reset Auth attempts";
            this.unlockBtn.UseVisualStyleBackColor = true;
            this.unlockBtn.Click += new System.EventHandler(this.unlockBtn_Click);
            // 
            // setIneligibleBtn
            // 
            this.setIneligibleBtn.Location = new System.Drawing.Point(364, 178);
            this.setIneligibleBtn.Name = "setIneligibleBtn";
            this.setIneligibleBtn.Size = new System.Drawing.Size(139, 23);
            this.setIneligibleBtn.TabIndex = 6;
            this.setIneligibleBtn.Text = "Set Ineligible";
            this.setIneligibleBtn.UseVisualStyleBackColor = true;
            this.setIneligibleBtn.Click += new System.EventHandler(this.setIneligibleBtn_Click);
            // 
            // accountRegistryBindingSource
            // 
            this.accountRegistryBindingSource.DataSource = typeof(EVotingSystem.AccountRegistry);
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 295);
            this.Controls.Add(this.onSitePanel);
            this.Controls.Add(this.landingPanel);
            this.Controls.Add(this.resultPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.landingPanel.ResumeLayout(false);
            this.landingPanel.PerformLayout();
            this.onSitePanel.ResumeLayout(false);
            this.onSitePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRegistryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label resultTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel landingPanel;
        private System.Windows.Forms.Label landingTitle;
        private System.Windows.Forms.Panel onSitePanel;
        private System.Windows.Forms.Label onSiteTitle;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button resultBack;
        private System.Windows.Forms.Button onSiteBack;
        private System.Windows.Forms.Button seeOnSiteBtn;
        private System.Windows.Forms.Button seeResultsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource accountRegistryBindingSource;
        private System.Windows.Forms.DataGridView voterView;
        private System.Windows.Forms.Button unlockBtn;
        private System.Windows.Forms.Button setIneligibleBtn;
    }
}