namespace Group_Project
{
    partial class AdminView
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
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColours = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbLeague = new System.Windows.Forms.ToolStripComboBox();
            this.tscbTeam = new System.Windows.Forms.ToolStripComboBox();
            this.tpLeagueDetails = new System.Windows.Forms.TabPage();
            this.leagueDetailsView1 = new Group_Project.UserControls.LeagueDetailsView();
            this.tpPasswords = new System.Windows.Forms.TabPage();
            this.passwordControlView1 = new Group_Project.UserControls.PasswordControlView();
            this.tpFixtures = new System.Windows.Forms.TabPage();
            this.fixtureView1 = new Group_Project.UserControls.FixtureView();
            this.tpPlayers = new System.Windows.Forms.TabPage();
            this.teamView1 = new Group_Project.UserControls.TeamView();
            this.tpLeagueView = new System.Windows.Forms.TabPage();
            this.leagueView1 = new Group_Project.PublicViewUserControls.LeagueView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTeamDetails = new System.Windows.Forms.TabPage();
            this.teamDetailsView1 = new Group_Project.UserControls.TeamDetailsView();
            this.menuStrip1.SuspendLayout();
            this.tpLeagueDetails.SuspendLayout();
            this.tpPasswords.SuspendLayout();
            this.tpFixtures.SuspendLayout();
            this.tpPlayers.SuspendLayout();
            this.tpLeagueView.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTeamDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogout,
            this.tsmiColours,
            this.tscbLeague,
            this.tscbTeam});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(57, 23);
            this.tsmiLogout.Text = "Logout";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // tsmiColours
            // 
            this.tsmiColours.Name = "tsmiColours";
            this.tsmiColours.Size = new System.Drawing.Size(60, 23);
            this.tsmiColours.Text = "Colours";
            this.tsmiColours.Click += new System.EventHandler(this.tsmiColours_Click);
            // 
            // tscbLeague
            // 
            this.tscbLeague.Name = "tscbLeague";
            this.tscbLeague.Size = new System.Drawing.Size(121, 23);
            this.tscbLeague.SelectedIndexChanged += new System.EventHandler(this.tscbLeague_SelectedIndexChanged);
            // 
            // tscbTeam
            // 
            this.tscbTeam.Name = "tscbTeam";
            this.tscbTeam.Size = new System.Drawing.Size(121, 23);
            this.tscbTeam.SelectedIndexChanged += new System.EventHandler(this.tscbTeam_SelectedIndexChanged);
            // 
            // tpLeagueDetails
            // 
            this.tpLeagueDetails.Controls.Add(this.leagueDetailsView1);
            this.tpLeagueDetails.Location = new System.Drawing.Point(4, 22);
            this.tpLeagueDetails.Name = "tpLeagueDetails";
            this.tpLeagueDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpLeagueDetails.Size = new System.Drawing.Size(1130, 644);
            this.tpLeagueDetails.TabIndex = 5;
            this.tpLeagueDetails.Text = "League Details";
            this.tpLeagueDetails.UseVisualStyleBackColor = true;
            // 
            // leagueDetailsView1
            // 
            this.leagueDetailsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leagueDetailsView1.Location = new System.Drawing.Point(3, 3);
            this.leagueDetailsView1.Name = "leagueDetailsView1";
            this.leagueDetailsView1.Size = new System.Drawing.Size(1124, 638);
            this.leagueDetailsView1.TabIndex = 0;
            // 
            // tpPasswords
            // 
            this.tpPasswords.Controls.Add(this.passwordControlView1);
            this.tpPasswords.Location = new System.Drawing.Point(4, 22);
            this.tpPasswords.Name = "tpPasswords";
            this.tpPasswords.Padding = new System.Windows.Forms.Padding(3);
            this.tpPasswords.Size = new System.Drawing.Size(1130, 644);
            this.tpPasswords.TabIndex = 4;
            this.tpPasswords.Text = "PasswordControl";
            this.tpPasswords.UseVisualStyleBackColor = true;
            // 
            // passwordControlView1
            // 
            this.passwordControlView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordControlView1.Location = new System.Drawing.Point(3, 3);
            this.passwordControlView1.Name = "passwordControlView1";
            this.passwordControlView1.Size = new System.Drawing.Size(1124, 638);
            this.passwordControlView1.TabIndex = 0;
            // 
            // tpFixtures
            // 
            this.tpFixtures.Controls.Add(this.fixtureView1);
            this.tpFixtures.Location = new System.Drawing.Point(4, 22);
            this.tpFixtures.Name = "tpFixtures";
            this.tpFixtures.Size = new System.Drawing.Size(1130, 644);
            this.tpFixtures.TabIndex = 2;
            this.tpFixtures.Text = "Fixtures";
            this.tpFixtures.UseVisualStyleBackColor = true;
            // 
            // fixtureView1
            // 
            this.fixtureView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixtureView1.Location = new System.Drawing.Point(0, 0);
            this.fixtureView1.Name = "fixtureView1";
            this.fixtureView1.Size = new System.Drawing.Size(1130, 644);
            this.fixtureView1.TabIndex = 0;
            // 
            // tpPlayers
            // 
            this.tpPlayers.Controls.Add(this.teamView1);
            this.tpPlayers.Location = new System.Drawing.Point(4, 22);
            this.tpPlayers.Name = "tpPlayers";
            this.tpPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayers.Size = new System.Drawing.Size(1130, 644);
            this.tpPlayers.TabIndex = 1;
            this.tpPlayers.Text = "Players";
            this.tpPlayers.UseVisualStyleBackColor = true;
            // 
            // teamView1
            // 
            this.teamView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamView1.Location = new System.Drawing.Point(3, 3);
            this.teamView1.Name = "teamView1";
            this.teamView1.Size = new System.Drawing.Size(1124, 638);
            this.teamView1.TabIndex = 0;
            // 
            // tpLeagueView
            // 
            this.tpLeagueView.Controls.Add(this.leagueView1);
            this.tpLeagueView.Location = new System.Drawing.Point(4, 22);
            this.tpLeagueView.Name = "tpLeagueView";
            this.tpLeagueView.Padding = new System.Windows.Forms.Padding(3);
            this.tpLeagueView.Size = new System.Drawing.Size(1130, 644);
            this.tpLeagueView.TabIndex = 0;
            this.tpLeagueView.Text = "League View";
            this.tpLeagueView.UseVisualStyleBackColor = true;
            // 
            // leagueView1
            // 
            this.leagueView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leagueView1.Location = new System.Drawing.Point(3, 3);
            this.leagueView1.Name = "leagueView1";
            this.leagueView1.Size = new System.Drawing.Size(1124, 638);
            this.leagueView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLeagueView);
            this.tabControl1.Controls.Add(this.tpPlayers);
            this.tabControl1.Controls.Add(this.tpFixtures);
            this.tabControl1.Controls.Add(this.tpPasswords);
            this.tabControl1.Controls.Add(this.tpLeagueDetails);
            this.tabControl1.Controls.Add(this.tpTeamDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 670);
            this.tabControl1.TabIndex = 2;
            // 
            // tpTeamDetails
            // 
            this.tpTeamDetails.Controls.Add(this.teamDetailsView1);
            this.tpTeamDetails.Location = new System.Drawing.Point(4, 22);
            this.tpTeamDetails.Name = "tpTeamDetails";
            this.tpTeamDetails.Size = new System.Drawing.Size(1130, 644);
            this.tpTeamDetails.TabIndex = 6;
            this.tpTeamDetails.Text = "Team Details";
            this.tpTeamDetails.UseVisualStyleBackColor = true;
            // 
            // teamDetailsView1
            // 
            this.teamDetailsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamDetailsView1.Location = new System.Drawing.Point(0, 0);
            this.teamDetailsView1.Name = "teamDetailsView1";
            this.teamDetailsView1.Size = new System.Drawing.Size(1130, 644);
            this.teamDetailsView1.TabIndex = 0;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 697);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminView_FormClosed);
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tpLeagueDetails.ResumeLayout(false);
            this.tpPasswords.ResumeLayout(false);
            this.tpFixtures.ResumeLayout(false);
            this.tpPlayers.ResumeLayout(false);
            this.tpLeagueView.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpTeamDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiColours;
        private System.Windows.Forms.ToolStripComboBox tscbLeague;
        private System.Windows.Forms.ToolStripComboBox tscbTeam;
        private System.Windows.Forms.TabPage tpLeagueDetails;
        private System.Windows.Forms.TabPage tpPasswords;
        private System.Windows.Forms.TabPage tpFixtures;
        private System.Windows.Forms.TabPage tpPlayers;
        private UserControls.TeamView teamView1;
        private System.Windows.Forms.TabPage tpLeagueView;
        private PublicViewUserControls.LeagueView leagueView1;
        private System.Windows.Forms.TabControl tabControl1;
        private UserControls.FixtureView fixtureView1;
        private UserControls.PasswordControlView passwordControlView1;
        private UserControls.LeagueDetailsView leagueDetailsView1;
        private System.Windows.Forms.TabPage tpTeamDetails;
        private UserControls.TeamDetailsView teamDetailsView1;
    }
}