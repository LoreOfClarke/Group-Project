using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class ManagerView : Form
    {
        /// <summary>
        /// an integer for keeping track of team that the manager is allowed to edit
        /// </summary>
        public int TeamID;
        /// <summary>
        /// A List containing all of the leagues in the database.
        /// </summary>
        private List<Classes.League> LeagueList = new List<Classes.League>();
        /// <summary>
        /// A List containing all of the Teams and their results in the selected league.
        /// </summary>
        private List<Classes.Team> TeamList = new List<Classes.Team>();
        /// <summary>
        /// A List containing all of the players in the selected team.
        /// </summary>
        private List<Classes.Player> PlayerList = new List<Classes.Player>();
        /// <summary>
        /// A List containing all of the fixtures in the League.
        /// </summary>
        private List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();



        #region Initial Setup
        /// <summary>
        /// auto genrated code
        /// </summary>
        public ManagerView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// on form load set up the back updating event, and get the data, and update the user controls. Also Do the colour changing.
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguement</param>
        private void ManagerView_Load(object sender, EventArgs e)
        {
            teamView1.UpdateView += new EventHandler(UpdateView);
            teamView1.TeamID = TeamID;
            GetData();
            updateLeague();
            colourchange();
        }
        /// <summary>
        /// Fill the League class, and dropdown
        /// </summary>
        private void FillTeamLeagues()
        {
            LeagueList = Database.LeagueList.FillFromTeam(TeamID);
            foreach (Classes.League lg in LeagueList)
            {
                tscbLeague.Items.Add(lg.LeagueName);
            }
            tscbLeague.SelectedIndex = 0;
        }
        #endregion

        #region UpdateHanding
        /// <summary>
        /// get the update data and update the usercontrols
        /// </summary>
        /// <param name="sender">the sending object</param>
        /// <param name="e">event arguemnet</param>
        protected void UpdateView(object sender, EventArgs e)
        {
            GetData();
            updateLeague();
        }
        #endregion

        #region Object Events
        /// <summary>
        /// when the league dropdown is changed fill the team class and update the related user controls
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguement</param>
        private void tscbLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            TeamList = Database.TeamList.Fill(LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
            Database.DatabaseConnection.dbDisconnect();
            updateLeague();
        }
        /// <summary>
        /// when the colour change button is clicked open the colour change form
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
        /// Oper the user guide PDF
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("User Guide.pdf");
        }
        #endregion

        #region Global Updates
        /// <summary>
        /// fill the classes
        /// </summary>
        protected void GetData()
        {
            tscbLeague.Items.Clear();
            Database.DatabaseConnection.dbConnect();
            FillTeamLeagues();
            PlayerList = Database.TeamPlayers.Fill(TeamID);
            FixtureList = Database.FixtureList.Fill(TeamID);
            Database.DatabaseConnection.dbDisconnect();
        }
        /// <summary>
        /// update the user controls
        /// </summary>
        protected void updateLeague()
        {
            leagueView1.update(TeamList);
            teamView1.update(PlayerList,true);
            fixtureView1.update(FixtureList,false, LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
        }
        #endregion

        #region OnClose
        /// <summary>
        /// closng button closes the form
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguement</param>
        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// when this form is closed, open the public view form
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguement</param>
        private void ManagerView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        #endregion


        #region Utility Functions
        /// <summary>
        /// event that user controls can call to change the entire form's colour
        /// </summary>
        public event EventHandler ColourChangeEvent;
        /// <summary>
        /// code to pass the colour change event to it's parent.
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguement</param>
        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.ColourChangeEvent != null)
                this.ColourChangeEvent(this, e);
        }
        /// <summary>
        /// code to andle the colour change event from usercontrols, just runs the utility function.
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event argument</param>
        private void ColourChangeForm_ColourChangeEvent(object sender, EventArgs e)
        {
            colourchange();
        }
        /// <summary>
        /// code to change the colour of the entire form and usercontrols
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
