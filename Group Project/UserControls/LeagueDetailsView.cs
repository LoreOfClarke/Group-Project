using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project.UserControls
{
    public partial class LeagueDetailsView : UserControl
    {
        public LeagueDetailsView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// integer to store whether the user is adding or editing a record (1 for adding, 2 for editing)
        /// </summary>
        int EditMode;

        #region Update Handling
        /// <summary>
        /// Code to take the update command from the main form
        /// </summary>
        /// <param name="Leagues">a class to hold all of the details of the leagues</param>
        public void update(List<Classes.League> Leagues)
        {
            dgvLeagues.DataSource = Leagues.ToList();
        }
        /// <summary>
        /// an event to pass the command to update to the parent form
        /// </summary>
        public event EventHandler UpdateView;
        /// <summary>
        /// a method to handle passing an update to the parent without throwing exceptions
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Arguement</param>
        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.UpdateView != null)
                this.UpdateView(this, e);
        }
        #endregion


        #region Utility Functions
        /// <summary>
        /// a utility function to switch between editing/adding mode or not
        /// </summary>
        /// <param name="access">false for editing, true to return to normal</param>
        private void DetailsAccess(bool access)
        {
            dgvLeagues.Enabled = access;
            txtLeagueName.ReadOnly = access;
            txtSponsor.ReadOnly = access;
            if (!access)
            {
                nudCapacity.Minimum = 0;
                nudCapacity.Maximum = 100;
            }
            pnlEdit.Visible = !access;
            pnlStandard.Visible = access;
        }
        /// <summary>
        /// code that changes the colour of the controls
        /// </summary>
        public void colourChange()
        {
            ColourChange.ColourSplitPanel(splitContainer1);
            ColourChange.ColourPanel(pnlAdmin);
            ColourChange.ColourPanel(pnlEdit);
            ColourChange.ColourPanel(pnlStandard);
            ColourChange.ColourTextbox(txtLeagueName);
            ColourChange.ColourTextbox(txtSponsor);
            ColourChange.ColourNumericUD(nudCapacity);
            ColourChange.ColourLabel(lblCapacity);
            ColourChange.ColourLabel(lblCurrentLeagues);
            ColourChange.ColourLabel(lblLeagueName);
            ColourChange.ColourLabel(lblSponsor);
            ColourChange.ColourDGV(dgvLeagues);
            ColourChange.ColourButton(cmdAdd);
            ColourChange.ColourButton(cmdCancel);
            ColourChange.ColourButton(cmdConfirm);
            ColourChange.ColourButton(cmdDelete);
            ColourChange.ColourButton(cmdUpdate);
        }
        #endregion


        #region Object Code
        /// <summary>
        /// when a different League is selected, change the textboxes to display the new record. 
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Arguement</param>
        private void dgvLeagues_SelectionChanged(object sender, EventArgs e)
        {
            nudCapacity.Minimum = 0;
            nudCapacity.Maximum = 100;
            nudCapacity.Value = 0;
            if (dgvLeagues.SelectedRows.Count > 0)
            {
                txtLeagueName.Text = dgvLeagues.SelectedRows[0].Cells[1].Value.ToString();
                nudCapacity.Value = int.Parse(dgvLeagues.SelectedRows[0].Cells[2].Value.ToString());
                txtSponsor.Text = dgvLeagues.SelectedRows[0].Cells[3].Value.ToString();
                nudCapacity.Maximum = nudCapacity.Minimum = nudCapacity.Value;
            }
            else
            {
                txtLeagueName.Text = txtSponsor.Text = "";
            }
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
        /// <summary>
        /// On clicking the Confirm button, check whether the user was editing or adding a record, then connect to the database and perform the changes.
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            DetailsAccess(true);
            Database.DatabaseConnection.dbConnect();
            switch (EditMode)
            {
                case 0:
                    MessageBox.Show("Error: Attempted Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    Database.LeagueList.Add(txtLeagueName.Text, int.Parse(nudCapacity.Value.ToString()), txtSponsor.Text);
                    break;
                case 2:
                    Database.LeagueList.Update(txtLeagueName.Text, int.Parse(nudCapacity.Value.ToString()), txtSponsor.Text,int.Parse(dgvLeagues.SelectedRows[0].Cells[0].Value.ToString()));
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
        /// When the Edit button is clicked, change to editing mode and remember that a record is to be edited, and which record is being changed
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Arguements</param>
        private void cmdUpdate_Click(object sender, EventArgs e)
        {
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
            Database.DatabaseConnection.dbConnect();
            Database.LeagueList.Delete(int.Parse(dgvLeagues.SelectedRows[0].Cells[0].Value.ToString()));
            Database.DatabaseConnection.dbDisconnect();
        }
        #endregion

    }
}
