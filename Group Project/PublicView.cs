using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group_Project
{
    public partial class FrontPage : Form
    {
        private List<Classes.League> LeagueList = new List<Classes.League>();
        private List<Classes.Team> TeamList = new List<Classes.Team>();
        private List<Classes.Player> PlayerList = new List<Classes.Player>();
        private List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();
        public FrontPage()
        {
            InitializeComponent();
        }

        #region Initial Setup

        private void FrontPage_Load(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            FillLeagues(Database.DatabaseConnection.DBConnection);
            Database.DatabaseConnection.dbDisconnect();
        }

        private void FillLeagues(OleDbConnection dbconn)
        {
            LeagueList = Database.LeagueList.Fill(dbconn);
            foreach (Classes.League lg in LeagueList)
            {
                tscbLeague.Items.Add(lg.LeagueName);
            }
            tscbLeague.SelectedIndex = 0;
        }

        private void FillTeams(OleDbConnection dbconn ,int League)
        {
            TeamList = Database.TeamList.Fill(dbconn, League);
            foreach (Classes.Team tm in TeamList)
            {
                tscbTeam.Items.Add(tm.TeamName);
            }
            tscbTeam.SelectedIndex = 0;
        }

        private void FillPlayers(OleDbConnection dbconn, int Team)
        {
            PlayerList = Database.TeamPlayers.Fill(dbconn, Team);
        }

        private void FillFixtures(OleDbConnection dbconn,int League, int Team)
        {
            FixtureList = Database.FixtureList.FillLeague(dbconn, League, Team);
        }
        #endregion

        #region Object Events
        private void tscbLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            FillTeams(Database.DatabaseConnection.DBConnection, LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
            Database.DatabaseConnection.dbDisconnect();
            updateLeague();
        }

        private void tscbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            FillPlayers(Database.DatabaseConnection.DBConnection, TeamList.FirstOrDefault(x => x.TeamName == tscbTeam.Text).TeamID);
            FillFixtures(Database.DatabaseConnection.DBConnection, LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId, TeamList.FirstOrDefault(x => x.TeamName == tscbTeam.Text).TeamID);
            Database.DatabaseConnection.dbDisconnect();
            updateTeams();
        }

        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Owner = this;
            login.ShowDialog();
        }
        #endregion

        #region Global Updates
        public void updateLeague()
        {
            leagueView1.update(TeamList);
        }

        public void updateTeams()
        {
            teamView1.update(PlayerList);
            fixtureView1.update(FixtureList);
        }

        #endregion


    }
}
