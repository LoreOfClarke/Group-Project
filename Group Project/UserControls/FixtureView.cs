using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project.UserControls
{
    public partial class FixtureView : UserControl
    {
        public FixtureView()
        {
            InitializeComponent();
        }
        
        private int EditMode = 0;
        private int EditingFixture;
        private List<Classes.Fixture> FixturesList;
        private int LeagueID;


        #region Update Handling
        public void update(List<Classes.Fixture> Fixtures,bool EditMode, int  inleagueID)
        {
            LeagueID = inleagueID;
            FixturesList = Fixtures;
            pnlAdmin.Visible = EditMode;
            dgvFixtures.DataSource = Fixtures.Where(a =>  a.Played == false).Select(x => new Classes.FixtureTableDisplay() { Home_Team = x.HomeTeamName, Away_Team = x.AwayTeamName, Date = x.FixtureDate, Time = x.FixtureTime }).ToList();
            dgvFixtures.Columns[3].DefaultCellStyle.Format = "hh:mm tt";
            dgvResults.DataSource = Fixtures.Where(a=> a.Played).Select(x => new Classes.ResultsTableDisplay() { Home_Team = x.HomeTeamName, Away_Team = x.AwayTeamName, Score = x.GoalsFor + " - " + x.GoalsAgainst, Date = x.FixtureDate, Time = x.FixtureTime }).ToList(); ;
            dgvResults.Columns[4].DefaultCellStyle.Format = "hh:mm tt";
        }

        public event EventHandler UpdateView;

        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.UpdateView != null)
                this.UpdateView(this, e);
        }
        #endregion

        #region Utility Functions
        private void DetailsAccess(bool access)
        {
            dgvFixtures.Enabled = access;
            dgvResults.Enabled = access;
            txtAwayTeam.ReadOnly = access;
            txtHomeTeam.ReadOnly = access;
            nudAwayGoals.ReadOnly = access;
            nudHomeGoals.ReadOnly = access;
            if (!access)
            {
                dtpDate.MinDate = dtpTime.MinDate = DateTime.Parse("01/01/1753");
                dtpDate.MaxDate = dtpTime.MaxDate = DateTime.Parse("31/12/9998"); ;
                dtpDate.Value = DateTime.Parse(dgvFixtures.SelectedRows[0].Cells[2].Value.ToString());
                dtpDate.MinDate = DateTime.Now;
            }
            spnlEdit.Visible = access;
            pnlEditing.Visible = !access;
        }
        public void colourChange()
        {
            ColourChange.ColourSplitPanel(spnlFixtures);
            ColourChange.ColourSplitPanel(spnlHeader);
            ColourChange.ColourLabel(lblFixtures);
            ColourChange.ColourLabel(lblResults);
            ColourChange.ColourDGV(dgvFixtures);
            ColourChange.ColourDGV(dgvResults);
            ColourChange.ColourPanel(pnlAdmin);
            ColourChange.ColourPanel(pnlEditing);
            ColourChange.ColourPanel(pnlEditMode);
            ColourChange.ColourTextbox(txtHomeTeam);
            ColourChange.ColourTextbox(txtAwayTeam);
            ColourChange.ColourLabel(lblAwayGoals);
            ColourChange.ColourLabel(lblAwayTime);
            ColourChange.ColourLabel(lblDate);
            ColourChange.ColourLabel(lblHomeGoals);
            ColourChange.ColourLabel(lblTime);
            ColourChange.ColourLabel(lblHomeTeam);
            ColourChange.ColourNumericUD(nudAwayGoals);
            ColourChange.ColourNumericUD(nudHomeGoals);
            ColourChange.ColourDTP(dtpDate);
            ColourChange.ColourDTP(dtpTime);
            ColourChange.ColourButton(cmdAccept);
            ColourChange.ColourButton(cmdAdd);
            ColourChange.ColourButton(cmdAddResult);
            ColourChange.ColourButton(cmdCancel);
            ColourChange.ColourButton(cmdDelete);
            ColourChange.ColourButton(cmdEdit);
        }
        #endregion

        #region ObjectCode
        private void dgvFixtures_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFixtures.SelectedRows.Count > 0)
            {
                txtHomeTeam.Text = dgvFixtures.SelectedRows[0].Cells[0].Value.ToString();
                txtAwayTeam.Text = dgvFixtures.SelectedRows[0].Cells[1].Value.ToString();
                dtpDate.MinDate = dtpTime.MinDate = DateTime.Parse("01/01/1753");
                dtpDate.MaxDate = dtpTime.MaxDate = DateTime.Parse("31/12/9998");
                dtpDate.Value = DateTime.Parse(dgvFixtures.SelectedRows[0].Cells[2].Value.ToString());
                dtpDate.MinDate = dtpDate.MaxDate = dtpDate.Value;
                dtpTime.Value = DateTime.Parse(dgvFixtures.SelectedRows[0].Cells[3].Value.ToString());
                dtpTime.MinDate = dtpTime.MaxDate = dtpTime.Value;
                nudHomeGoals.Text = "";
                nudAwayGoals.Text = "";
            }
            else
            {
                txtHomeTeam.Text = txtAwayTeam.Text =  "";
                nudAwayGoals.Value = nudHomeGoals.Value = 0;
                dtpTime.MinDate = dtpDate.MinDate = DateTime.Parse("01/01/1753");
                dtpTime.MaxDate = dtpDate.MaxDate = DateTime.Parse("31/12/9998");
                dtpDate.Value = dtpDate.MinDate;
                dtpTime.Value = dtpTime.MinDate;
            }
        }

        private void dgvResults_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            EditMode = 1;
        }


        private void cmdEdit_Click(object sender, EventArgs e)
        {
            
            Database.DatabaseConnection.dbConnect();
            //I needed to be a bit squirrelly here to cut down on database searches. What i've done here is pulled the fixtures list out, and searched
            //for any the team's ID depending on the first team that has the correct name that has a fixture. This is a bit of an issue, but should be fine
            //as long as names are kept different in each league.
            int HometeamID, AwayteamID;
            HometeamID = FixturesList.Where(x => x.HomeTeamName == txtHomeTeam.Text).FirstOrDefault().HomeTeamID;
            AwayteamID = FixturesList.Where(x => x.AwayTeamName == txtAwayTeam.Text).FirstOrDefault().AwayTeamID;
            EditingFixture = Database.FixtureList.FindFixtureID(HometeamID, AwayteamID, dtpDate.Value, dtpTime.Value);
            Database.DatabaseConnection.dbDisconnect();
            DetailsAccess(false);
            EditMode = 2;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            Database.DatabaseConnection.dbConnect();
            int HometeamID, AwayteamID;
            HometeamID = FixturesList.Where(x => x.HomeTeamName == txtHomeTeam.Text).FirstOrDefault().HomeTeamID;
            AwayteamID = FixturesList.Where(x => x.AwayTeamName == txtAwayTeam.Text).FirstOrDefault().AwayTeamID;
            int FixtureID = Database.FixtureList.FindFixtureID(HometeamID, AwayteamID, dtpDate.Value, dtpTime.Value);
            Database.FixtureList.DeleteFixture(FixtureID);
            Database.DatabaseConnection.dbDisconnect();
            UpdateParent(this, e);
            DetailsAccess(true);
        }

        private void cmdAddResult_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            Database.DatabaseConnection.dbConnect();
            int HometeamID, AwayteamID;
            HometeamID = FixturesList.Where(x => x.HomeTeamName == txtHomeTeam.Text).FirstOrDefault().HomeTeamID;
            AwayteamID = FixturesList.Where(x => x.AwayTeamName == txtAwayTeam.Text).FirstOrDefault().AwayTeamID;
            int FixtureID = Database.FixtureList.FindFixtureID(HometeamID, AwayteamID, dtpDate.Value, dtpTime.Value);
            Database.FixtureList.AddResult(FixtureID,int.Parse(nudHomeGoals.Value.ToString()),int.Parse(nudAwayGoals.Value.ToString()));
            Database.DatabaseConnection.dbDisconnect();
            UpdateParent(this, e);
            DetailsAccess(true);
        }

        ///TD: find a way to search for team id's based off of their name. Combobox perhaps

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            DetailsAccess(true);
            int HometeamID, AwayteamID;
            Database.DatabaseConnection.dbConnect();
            switch (EditMode)
            {
                case 0:
                    MessageBox.Show("Error: Attempted Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    //Unfortunately this requires that a team already has a match assigend to them before they can play... this has been TD tagged, and will be gotten back to.
                    HometeamID = FixturesList.Where(x => x.HomeTeamName == txtHomeTeam.Text).FirstOrDefault().HomeTeamID;
                    AwayteamID = FixturesList.Where(x => x.AwayTeamName == txtAwayTeam.Text).FirstOrDefault().AwayTeamID;
                    Database.FixtureList.Add(LeagueID, HometeamID, AwayteamID, dtpDate.Value, dtpTime.Value);
                    break;
                case 2:
                    HometeamID = FixturesList.Where(x => x.HomeTeamName == txtHomeTeam.Text).FirstOrDefault().HomeTeamID;
                    AwayteamID = FixturesList.Where(x => x.AwayTeamName == txtAwayTeam.Text).FirstOrDefault().AwayTeamID;
                    Database.FixtureList.EditFixture(EditingFixture, HometeamID, AwayteamID, dtpDate.Value, dtpTime.Value);
                    break;
                default:
                    MessageBox.Show("Error: Attempted Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Database.DatabaseConnection.dbDisconnect();
            EditMode = 0;
            UpdateParent(this, e);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DetailsAccess(true);
            EditMode = 0;
            UpdateParent(this, e);
        }

        #endregion

    }
}
