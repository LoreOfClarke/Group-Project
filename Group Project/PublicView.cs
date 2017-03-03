using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class FrontPage : Form
    {
        /// <summary>
        /// A list of all the leagues in the databse
        /// </summary>
        private List<Classes.League> LeagueList = new List<Classes.League>();
        /// <summary>
        /// A list of all the teams and their score in the selected league
        /// </summary>
        private List<Classes.Team> TeamList = new List<Classes.Team>();
        /// <summary>
        /// A list of all the players in the selected Team
        /// </summary>
        private List<Classes.Player> PlayerList = new List<Classes.Player>();
        /// <summary>
        /// A list of all the fixtures in the selected league
        /// </summary>
        private List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();


        #region Initial Setup
        /// <summary>
        /// AutoGenerarted Code
        /// </summary>
        public FrontPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On loading the form, connect to the database and fill the league database.
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">Event Arguments</param>
        private void FrontPage_Load(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            FillLeagues();
            Database.DatabaseConnection.dbDisconnect();
            colourchange();
        }
        #endregion
        
        #region Object Events
        /// <summary>
        /// Whenever the league value is changed, including when populating the leage dropdown, then load in the applicable teams.
        /// </summary>
        /// <param name="sender">the sending object</param>
        /// <param name="e">the event arguements</param>
        private void tscbLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            FillTeams(LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
            Database.DatabaseConnection.dbDisconnect();
            leagueView1.update(TeamList);
        }
        /// <summary>
        /// Whenever the team value is changed, including when populating the team dropdown, get the player details and populate related usercontrols
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event Argument</param>
        private void tscbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            PlayerList = Database.TeamPlayers.Fill(TeamList.FirstOrDefault(x => x.TeamName == tscbTeam.Text).TeamID);
            FixtureList = Database.FixtureList.FillLeague(LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId, TeamList.FirstOrDefault(x => x.TeamName == tscbTeam.Text).TeamID);
            Database.DatabaseConnection.dbDisconnect();
            teamView1.update(PlayerList, false);
            fixtureView1.update(FixtureList,false, LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
        }
        /// <summary>
        /// on clicking the login button, open that form as dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Owner = this;
            login.ShowDialog();
            login.ColourChangeEvent += ColourChangeForm_ColourChangeEvent;
        }
        /// <summary>
        /// on clicking the login button, open that form modally
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguement</param>
        private void tsmiColours_Click(object sender, EventArgs e)
        {
            frmColourChange ColourChangeForm = new frmColourChange();
            ColourChangeForm.Owner = this;
            ColourChangeForm.ColourChangeEvent += ColourChangeForm_ColourChangeEvent;
            ColourChangeForm.ShowDialog();
        }
        /// <summary>
        /// on opening this page from other views, change the colours
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguements</param>
        private void FrontPage_VisibleChanged(object sender, EventArgs e)
        {
            colourchange();
        }
        #endregion

        #region Global Updates
        /// <summary>
        /// Fill the leagues table and set up the league dropdown
        /// </summary>
        private void FillLeagues()
        {
            LeagueList = Database.LeagueList.Fill();
            foreach (Classes.League lg in LeagueList)
            {
                tscbLeague.Items.Add(lg.LeagueName);
            }
            tscbLeague.SelectedIndex = 0;
        }
        /// <summary>
        /// Fill the teams class and set up the team dropdown
        /// </summary>
        /// <param name="League"></param>
        private void FillTeams(int League)
        {
            TeamList = Database.TeamList.Fill(League);
            foreach (Classes.Team tm in TeamList)
            {
                tscbTeam.Items.Add(tm.TeamName);
            }
            tscbTeam.SelectedIndex = 0;
        }
        #endregion

        #region Utility Functions
        /// <summary>
        /// the event that other pages can trigger to change the colours
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguemet</param>
        private void ColourChangeForm_ColourChangeEvent(object sender, EventArgs e)
        {
            colourchange();
        }
        /// <summary>
        /// Code to change the colour of all objects and usercontrols
        /// </summary>
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
