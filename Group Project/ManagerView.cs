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
            colourchange();
        }


        private void FillTeamLeagues()
        {
            LeagueList = Database.LeagueList.FillFromTeam(TeamID);
            foreach (Classes.League lg in LeagueList)
            {
                tscbLeague.Items.Add(lg.LeagueName);
            }
            tscbLeague.SelectedIndex = 0;
        }

        private void FillTeams( int League)
        {
            TeamList = Database.TeamList.Fill( League);
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
            FillTeams(LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
            Database.DatabaseConnection.dbDisconnect();
            updateLeague();
        }
        private void tsmiColours_Click(object sender, EventArgs e)
        {

            frmColourChange ColourChangeForm = new frmColourChange();
            ColourChangeForm.Owner = this;
            ColourChangeForm.ColourChangeEvent += ColourChangeForm_ColourChangeEvent;
            ColourChangeForm.ShowDialog();
        }
        #endregion

        #region Global Updates
        protected void GetData()
        {
            tscbLeague.Items.Clear();
            Database.DatabaseConnection.dbConnect();
            FillTeamLeagues();
            PlayerList = Database.TeamPlayers.Fill(TeamID);
            FixtureList = Database.FixtureList.Fill(TeamID);
            Database.DatabaseConnection.dbDisconnect();
        }

        protected void updateLeague()
        {
            leagueView1.update(TeamList);
            teamView1.update(PlayerList,true);
            fixtureView1.update(FixtureList,false, LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
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


        #region Utility Functions

        public event EventHandler ColourChangeEvent;

        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.ColourChangeEvent != null)
                this.ColourChangeEvent(this, e);
        }

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
