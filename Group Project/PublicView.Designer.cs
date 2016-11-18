namespace Group_Project
{
    partial class FrontPage
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
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColours = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbLeague = new System.Windows.Forms.ToolStripComboBox();
            this.tscbTeam = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.leagueView1 = new Group_Project.PublicViewUserControls.LeagueView();
            this.teamView1 = new Group_Project.UserControls.TeamView();
            this.fixtureView1 = new Group_Project.UserControls.FixtureView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogin,
            this.tsmiColours,
            this.tscbLeague,
            this.tscbTeam});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(63, 25);
            this.tsmiLogin.Text = "Login";
            // 
            // tsmiColours
            // 
            this.tsmiColours.Name = "tsmiColours";
            this.tsmiColours.Size = new System.Drawing.Size(78, 25);
            this.tsmiColours.Text = "Colours";
            // 
            // tscbLeague
            // 
            this.tscbLeague.Name = "tscbLeague";
            this.tscbLeague.Size = new System.Drawing.Size(121, 25);
            this.tscbLeague.SelectedIndexChanged += new System.EventHandler(this.tscbLeague_SelectedIndexChanged);
            // 
            // tscbTeam
            // 
            this.tscbTeam.Name = "tscbTeam";
            this.tscbTeam.Size = new System.Drawing.Size(121, 25);
            this.tscbTeam.SelectedIndexChanged += new System.EventHandler(this.tscbTeam_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 585);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkRed;
            this.tabPage1.Controls.Add(this.leagueView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1111, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "League View";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1111, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Team View";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.teamView1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 555);
            this.panel2.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage3.Controls.Add(this.fixtureView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1111, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fixtures";
            // 
            // leagueView1
            // 
            this.leagueView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leagueView1.Location = new System.Drawing.Point(3, 3);
            this.leagueView1.Margin = new System.Windows.Forms.Padding(4);
            this.leagueView1.Name = "leagueView1";
            this.leagueView1.Size = new System.Drawing.Size(1105, 549);
            this.leagueView1.TabIndex = 0;
            // 
            // teamView1
            // 
            this.teamView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamView1.Location = new System.Drawing.Point(0, 0);
            this.teamView1.Margin = new System.Windows.Forms.Padding(4);
            this.teamView1.Name = "teamView1";
            this.teamView1.Size = new System.Drawing.Size(1112, 555);
            this.teamView1.TabIndex = 0;
            // 
            // fixtureView1
            // 
            this.fixtureView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixtureView1.Location = new System.Drawing.Point(0, 0);
            this.fixtureView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fixtureView1.Name = "fixtureView1";
            this.fixtureView1.Size = new System.Drawing.Size(1111, 555);
            this.fixtureView1.TabIndex = 0;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 614);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrontPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrontPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiColours;
        private System.Windows.Forms.ToolStripComboBox tscbLeague;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripComboBox tscbTeam;
        private PublicViewUserControls.LeagueView leagueView1;
        private UserControls.TeamView teamView1;
        private UserControls.FixtureView fixtureView1;
    }
}

