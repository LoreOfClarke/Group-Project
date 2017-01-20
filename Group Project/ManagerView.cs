using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group_Project
{
    public partial class ManagerView : Form
    {
        
        public int TeamID;
        private List<Classes.League> LeagueList = new List<Classes.League>();
        private List<Classes.Team> TeamList = new List<Classes.Team>();
        private List<Classes.Player> PlayerList = new List<Classes.Player>();
        private List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();



        #region Initial Setup
        public ManagerView()
        {
            InitializeComponent();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            teamView1.UpdateView += new EventHandler(UpdateView);
            teamView1.TeamID = TeamID;
            GetData();
            updateLeague();
        }


        private void FillTeamLeagues(OleDbConnection dbconn)
        {
            LeagueList = Database.LeagueList.FillFromTeam(dbconn,TeamID);
            foreach (Classes.League lg in LeagueList)
            {
                tscbLeague.Items.Add(lg.LeagueName);
            }
            tscbLeague.SelectedIndex = 0;
        }

        private void FillTeams(OleDbConnection dbconn, int League)
        {
            TeamList = Database.TeamList.Fill(dbconn, League);
        }


        #endregion

        #region UpdateHanding

        protected void UpdateView(object sender, EventArgs e)
        {
            GetData();
            updateLeague();
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
        #endregion

        #region Global Updates
        protected void GetData()
        {
            Database.DatabaseConnection.dbConnect();
            FillTeamLeagues(Database.DatabaseConnection.DBConnection);
            PlayerList = Database.TeamPlayers.Fill(TeamID);
            FixtureList = Database.FixtureList.Fill(Database.DatabaseConnection.DBConnection, TeamID);
            Database.DatabaseConnection.dbDisconnect();
        }

        protected void updateLeague()
        {
            leagueView1.update(TeamList);
            teamView1.update(PlayerList,true);
            fixtureView1.update(FixtureList);
        }
        #endregion

        #region OnClose
        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        #endregion


    }
}
