﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project.UserControls
{
    /// <summary>
    /// A User Grid view that allows the user to assign teammembers to a league.
    /// </summary>
    public partial class LeagueTeamAssignmentView : UserControl
    {
        /// <summary>
        /// autogenerated code
        /// </summary>
        public LeagueTeamAssignmentView()
        {
            InitializeComponent();
        }

        #region Update Code
        /// <summary>
        /// Code run to update the usercontrol
        /// </summary>
        /// <param name="Leagues">A list of classes containing all of the leagues data.</param>
        /// <param name="Teams">A List of classes containing all of the teams details.</param>
        public void update(List<Classes.League> Leagues,List<Classes.TeamDetails> Teams)
        {
            dgvLeagues.DataSource = Leagues.ToList();
            dgvTeams.DataSource = Teams.ToList();
        }
        /// <summary>
        /// an event to handle telling the parent form to update all usercontrols.
        /// </summary>
        public event EventHandler UpdateView;
        /// <summary>
        /// An method to handle passing updates up to the parent form
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.UpdateView != null)
                this.UpdateView(this, e);
        }
        #endregion

        #region Object Code
        /// <summary>
        /// If the selection is changed, check whether the team is assinged to the new league
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void dgvLeagues_SelectionChanged(object sender, EventArgs e)
        {
            CheckAssignment();
        }
        /// <summary>
        /// If the selection is changed, check whether the League has the new Team Assigned
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
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
        /// <summary>
        /// On this button click, check the checkbox as to whether or not the team is assigned to the leage, and invert the value. There is an automatic creation if neccessarry.
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
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
        /// <summary>
        /// code that checks the database whether the selected team is assigned to the selected league, and if it is the checkbox is activated
        /// </summary>
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
        /// <summary>
        /// Code that changes the colour of the form
        /// </summary>
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
