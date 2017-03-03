﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Group_Project.UserControls
{
    public partial class TeamView : UserControl
    {
        /// <summary>
        /// autogenerated code
        /// </summary>
        public TeamView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// integer to store whether the user is adding or editing a record (1 for adding, 2 for editing)
        /// </summary>
        private int EditMode = 0;
        /// <summary>
        /// Integer to hold the ID of the Team currently being viewed
        /// </summary>
        internal int TeamID;
        /// <summary>
        /// Integer to hold the player currently being edited
        /// </summary>
        internal int EditingPlayer;

        #region Update Handling
        /// <summary>
        /// an event to handle passing the update to the parent form
        /// </summary>
        public event EventHandler UpdateView;
        /// <summary>
        /// A method to handle updating the parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.UpdateView != null)
                this.UpdateView(this, e);
        }
        /// <summary>
        /// A method to handle updating the usercontrol when the form commands a update
        /// </summary>
        /// <param name="Players">A list of player class, containing all of the players in the team</param>
        /// <param name="CommandsActive">Whether or not the players in the team can be edited</param>
        public void update(List<Classes.Player> Players, bool CommandsActive)
        {
            dgvTeamDetails.DataSource = Players.Select(o => new Classes.PlayerDisplayTable() { Forname = o.Forname, Surname = o.Surname, DoB = o.DateOfBirth, Role = o.Role }).ToList();
            pnlCommands.Visible = CommandsActive;

        }
        #endregion

        #region Object Events
        /// <summary>
        /// Code run on changing the selected item on the datagridview. Basically just fills in the textboxes
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void dgvTeamDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeamDetails.SelectedRows.Count > 0)
            {
                txtForname.Text = dgvTeamDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtSurname.Text = dgvTeamDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtRole.Text = dgvTeamDetails.SelectedRows[0].Cells[3].Value.ToString();
                dtpDateOfBirth.MinDate = DateTime.Parse("01/01/1753");
                dtpDateOfBirth.MaxDate = DateTime.Parse("31/12/9998");
                dtpDateOfBirth.Value = DateTime.Parse(dgvTeamDetails.SelectedRows[0].Cells[2].Value.ToString());
                dtpDateOfBirth.MinDate = dtpDateOfBirth.MaxDate = dtpDateOfBirth.Value;
            }
            else
            {
                txtForname.Text = txtSurname.Text = txtRole.Text = "";
                dtpDateOfBirth.MinDate = DateTime.Parse("01/01/1753");
                dtpDateOfBirth.MaxDate = DateTime.Parse("31/12/9998");
                dtpDateOfBirth.Value = dtpDateOfBirth.MinDate;
            }
        }
        /// <summary>
        /// When the add button is clicked, change to editing mode and remember that a record is to be added
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Arguements</param>
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            EditMode = 1;
        }
        /// <summary>
        /// When the Update button is clicked, change to editing mode and remember that a record is to be edited, and which record is being changed
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Arguements</param>
        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            EditingPlayer = Database.TeamPlayers.FindPlayerID(txtForname.Text, txtSurname.Text, dtpDateOfBirth.Value, txtRole.Text);
            Database.DatabaseConnection.dbDisconnect();
            DetailsAccess(false);
            EditMode = 2;
        }
        /// <summary>
        /// When the Delete button is clicked, Connect to the database and delete the record then tell the parent form to update.
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Arguements</param>
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            Database.DatabaseConnection.dbConnect();
            EditingPlayer = Database.TeamPlayers.FindPlayerID(txtForname.Text, txtSurname.Text, dtpDateOfBirth.Value, txtRole.Text);
            Database.TeamPlayers.SetAssign(EditingPlayer, TeamID, 0);
            Database.DatabaseConnection.dbDisconnect();
            UpdateParent(this, e);
            DetailsAccess(true);
        }
        /// <summary>
        /// On clicking the accept button, check whether the user was editing or adding a record, then connect to the database and use the changes.
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void cmdAccept_Click(object sender, EventArgs e)
        {
            DetailsAccess(true);
            Database.DatabaseConnection.dbConnect();
            switch (EditMode)
            { 
                case 0:
                    MessageBox.Show("Error: Attempted Invalid Command","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                case 1:
                    int PlayerID;
                    PlayerID = Database.TeamPlayers.FindPlayerID(txtForname.Text, txtSurname.Text, dtpDateOfBirth.Value, txtRole.Text);
                    if (PlayerID == 0)
                    {
                        Database.TeamPlayers.Add(txtForname.Text, txtSurname.Text, dtpDateOfBirth.Value, txtRole.Text);
                        PlayerID = Database.TeamPlayers.FindPlayerID(txtForname.Text, txtSurname.Text, dtpDateOfBirth.Value, txtRole.Text);
                    }
                    Database.TeamPlayers.CreateAssign(PlayerID, TeamID); 
                    break;
                case 2:
                    Database.TeamPlayers.Edit(EditingPlayer, txtForname.Text, txtSurname.Text, dtpDateOfBirth.Value, txtRole.Text);
                    break;
                default:
                    MessageBox.Show("Error: Attempted Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Database.DatabaseConnection.dbDisconnect();
            EditMode = 0;
            UpdateParent(this, e);
        }
        /// <summary>
        /// On clicking the cancel button, return the form to normal
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DetailsAccess(true);
            EditMode = 0;
            UpdateParent(this, e);
        }
        #endregion

        #region Utility Functions
        /// <summary>
        /// a utility function to switch between editing/adding mode or not
        /// </summary>
        /// <param name="access">false for editing, true to return to normal</param>
        private void DetailsAccess(bool access)
        {
            dgvTeamDetails.Enabled = access;
            txtForname.ReadOnly = access;
            txtRole.ReadOnly = access;
            txtSurname.ReadOnly = access;
            if (!access)
            {
                dtpDateOfBirth.MinDate = DateTime.Parse("1900-01-01");
                dtpDateOfBirth.MaxDate = DateTime.Now;
            }
            pnlEdit.Visible = !access;
            pnlStandard.Visible = access;
        }
        /// <summary>
        /// code that changes the colour of all controls
        /// </summary>
        public void colourChange()
        {
            ColourChange.ColourPanel(pnlHeader);
            ColourChange.ColourPanel(pnlPlayerInformation);
            ColourChange.ColourPanel(pnlPlayers);
            ColourChange.ColourPanel(pnlCommands);
            ColourChange.ColourPanel(pnlStandard);
            ColourChange.ColourPanel(pnlEdit);
            ColourChange.ColourDGV(dgvTeamDetails);
            ColourChange.ColourLabel(lblTeamDetails);
            ColourChange.ColourLabel(lblPlayerInformation);
            ColourChange.ColourLabel(lblForname);
            ColourChange.ColourLabel(lblSurname);
            ColourChange.ColourLabel(lblDoB);
            ColourChange.ColourLabel(lblRole);
            ColourChange.ColourTextbox(txtForname);
            ColourChange.ColourTextbox(txtSurname);
            ColourChange.ColourTextbox(txtRole);
            ColourChange.ColourDTP(dtpDateOfBirth);
            ColourChange.ColourButton(cmdAccept);
            ColourChange.ColourButton(cmdCancel);
            ColourChange.ColourButton(cmdAdd);
            ColourChange.ColourButton(cmdUpdate);
            ColourChange.ColourButton(cmdDelete);
        }
        #endregion

    }
}
