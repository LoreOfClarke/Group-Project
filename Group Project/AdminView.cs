using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class AdminView : Form
    {

        private List<Classes.League> LeagueList = new List<Classes.League>();
        private List<Classes.Team> TeamList = new List<Classes.Team>();
        private List<Classes.Player> PlayerList = new List<Classes.Player>();
        private List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();

        #region Initial Setup
        public AdminView()
        {
            InitializeComponent();
            teamView1.UpdateView += new EventHandler(UpdateView);
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            fixtureView1.UpdateView += new EventHandler(UpdateView);
            teamView1.UpdateView += new EventHandler(UpdateView);
            passwordControlView1.UpdateView += new EventHandler(UpdateView);
            leagueDetailsView1.UpdateView += new EventHandler(UpdateView);
            teamDetailsView1.UpdateView += new EventHandler(UpdateView);
            colourchange();
            GetData();
        }
        #endregion

        #region Global Updates

        protected void GetData()
        {
            tscbLeague.Items.Clear();
            tscbTeam.Items.Clear();
            Database.DatabaseConnection.dbConnect();
            FillLeagues();
            Database.DatabaseConnection.dbDisconnect();
        }


        private void FillLeagues()
        {
            LeagueList = Database.LeagueList.Fill();
            foreach (Classes.League lg in LeagueList)
            {
                tscbLeague.Items.Add(lg.LeagueName);
            }
            tscbLeague.SelectedIndex = 0;
            passwordControlView1.update();
            leagueDetailsView1.update(LeagueList);
            teamDetailsView1.update();
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

        #region UpdateHanding

        protected void UpdateView(object sender, EventArgs e)
        {
            GetData();
            tscbLeague.SelectedIndex = 0;
        }
        #endregion

        #region OnClose
        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
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
            int TeamID = TeamList.FirstOrDefault(x => x.TeamName == tscbTeam.Text).TeamID;
            Database.DatabaseConnection.dbConnect();
            FillPlayers(TeamID);
            FillFixtures(LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId, TeamID);
            Database.DatabaseConnection.dbDisconnect();
            teamView1.update(PlayerList, true);
            teamView1.TeamID = TeamID;
            fixtureView1.update(FixtureList, true, LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
        }

        private void tsmiColours_Click(object sender, EventArgs e)
        {

            frmColourChange ColourChangeForm = new frmColourChange();
            ColourChangeForm.Owner = this;
            ColourChangeForm.ColourChangeEvent += ColourChangeForm_ColourChangeEvent;
            ColourChangeForm.ShowDialog();
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
            fixtureView1.colourChange();
            leagueDetailsView1.colourChange();
            leagueView1.ChangeColour();
            passwordControlView1.colourChange();
            teamDetailsView1.colourChange();
            teamView1.colourChange();
        }
        #endregion

    }
}
