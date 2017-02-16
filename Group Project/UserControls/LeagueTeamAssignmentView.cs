using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project.UserControls
{
    public partial class LeagueTeamAssignmentView : UserControl
    {
        public LeagueTeamAssignmentView()
        {
            InitializeComponent();
        }

        #region Update Code
        public void update(List<Classes.League> Leagues,List<Classes.TeamDetails> Teams)
        {
            dgvLeagues.DataSource = Leagues.ToList();
            dgvTeams.DataSource = Teams.ToList();
        }

        public event EventHandler UpdateView;
        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.UpdateView != null)
                this.UpdateView(this, e);
        }
        #endregion

        #region Object Code
        private void dgvLeagues_SelectionChanged(object sender, EventArgs e)
        {
            CheckAssignment();
        }

        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            CheckAssignment();
        }
        
        /// <summary>
        /// This code just exists to stop the user clicking on the checkbox without using the dissable property, since that locks out the colours.
        /// </summary>
        /// <param name="sender">The sending Object</param>
        /// <param name="e">Event Arguement</param>
        private void chkAssigned_Click(object sender, EventArgs e)
        {
            chkAssigned.Checked = !chkAssigned.Checked;
        }

        private void cmdAssign_Click(object sender, EventArgs e)
        {
            int TeamID = int.Parse(dgvTeams.SelectedRows[0].Cells[0].Value.ToString());
            int LeagueID = int.Parse(dgvLeagues.SelectedRows[0].Cells[0].Value.ToString());
            Database.DatabaseConnection.dbConnect();
            if (chkAssigned.Checked)                                    //for unassigning
            {
                Database.TeamLeague.SetAssign(LeagueID, TeamID, 0);
            }
            else                                                            //for assigning
            {
                if (Database.TeamLeague.CheckExists(LeagueID, TeamID))          //if a value in the database exists, change it
                {
                    Database.TeamLeague.SetAssign(LeagueID, TeamID, 1);
                }
                else                                                            //otherwise create it
                {
                    Database.TeamLeague.CreateAssign(LeagueID, TeamID);
                }
            }
            Database.DatabaseConnection.dbDisconnect();
            UpdateParent(this, e);
        }
        #endregion

        #region Utility Code
        private void CheckAssignment()
        {
            if (dgvLeagues.RowCount > 0 && dgvTeams.RowCount > 0 && dgvLeagues.SelectedRows.Count > 0 && dgvTeams.SelectedRows.Count > 0)
            {
                int TeamID = int.Parse(dgvTeams.SelectedRows[0].Cells[0].Value.ToString());
                int LeagueID = int.Parse(dgvLeagues.SelectedRows[0].Cells[0].Value.ToString());
                Database.DatabaseConnection.dbConnect();
                chkAssigned.Checked = Database.TeamLeague.CheckAssign(LeagueID, TeamID);
                Database.DatabaseConnection.dbDisconnect();
            }
        }

        public void colourChange()
        {
            ColourChange.ColourPanel(pnlAssingnment);
            ColourChange.ColourSplitPanel(spnlPanels);
            ColourChange.ColourDGV(dgvLeagues);
            ColourChange.ColourDGV(dgvTeams);
            ColourChange.ColourButton(cmdAssign);
            ColourChange.ColourCheckbox(chkAssigned);
        }
        #endregion

    }
}
