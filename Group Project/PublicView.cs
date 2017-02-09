using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class FrontPage : Form
    {
        private List<Classes.League> LeagueList = new List<Classes.League>();
        private List<Classes.Team> TeamList = new List<Classes.Team>();
        private List<Classes.Player> PlayerList = new List<Classes.Player>();
        private List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();


        #region Initial Setup

        public FrontPage()
        {
            InitializeComponent();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            FillLeagues();
            Database.DatabaseConnection.dbDisconnect();
            colourchange();
        }


        #endregion
        
        #region Object Events
        private void tscbLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            FillTeams(LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
            Database.DatabaseConnection.dbDisconnect();
            leagueView1.update(TeamList);
        }
        private void tscbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            FillPlayers(TeamList.FirstOrDefault(x => x.TeamName == tscbTeam.Text).TeamID);
            FillFixtures( LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId, TeamList.FirstOrDefault(x => x.TeamName == tscbTeam.Text).TeamID);
            Database.DatabaseConnection.dbDisconnect();
            teamView1.update(PlayerList, false);
            fixtureView1.update(FixtureList,false, LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
        }
        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Owner = this;
            login.ShowDialog();
            login.ColourChangeEvent += ColourChangeForm_ColourChangeEvent;
        }
        private void tsmiColours_Click(object sender, EventArgs e)
        {
            frmColourChange ColourChangeForm = new frmColourChange();
            ColourChangeForm.Owner = this;
            ColourChangeForm.ColourChangeEvent += ColourChangeForm_ColourChangeEvent;
            ColourChangeForm.ShowDialog();
        }

        private void FrontPage_VisibleChanged(object sender, EventArgs e)
        {
            colourchange();
        }
        #endregion

        #region Global Updates
        private void FillLeagues()
        {
            LeagueList = Database.LeagueList.Fill();
            foreach (Classes.League lg in LeagueList)
            {
                tscbLeague.Items.Add(lg.LeagueName);
            }
            tscbLeague.SelectedIndex = 0;
        }

        private void FillTeams(int League)
        {
            TeamList = Database.TeamList.Fill(League);
            foreach (Classes.Team tm in TeamList)
            {
                tscbTeam.Items.Add(tm.TeamName);
            }
            tscbTeam.SelectedIndex = 0;
        }

        private void FillPlayers(int Team)
        {
            PlayerList = Database.TeamPlayers.Fill(Team);
        }

        private void FillFixtures(int League, int Team)
        {
            FixtureList = Database.FixtureList.FillLeague(League, Team);
        }


        #endregion

        #region Utility Functions
        private void ColourChangeForm_ColourChangeEvent(object sender, EventArgs e)
        {
            colourchange();
        }

        private void colourchange()
        {
            ColourChange.ColourForm(this);
            ColourChange.ColourMenuStrip(menuStrip1);
            leagueView1.ChangeColour();
            fixtureView1.colourChange();
            teamView1.colourChange();
        }

        #endregion

    }
}
