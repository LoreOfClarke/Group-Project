using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Group_Project.UserControls
{
    public partial class TeamView : UserControl
    {
        public TeamView()
        {
            InitializeComponent();
        }

        private int EditMode = 0;
        internal int TeamID;
        internal int EditingPlayer;

        #region Update Handling
        public event EventHandler UpdateView;

        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.UpdateView != null)
                this.UpdateView(this, e);
        }
        #endregion

        #region Publically Accessable
        public void update(List<Classes.Player> Players, bool CommandsActive)
        {
            dgvTeamDetails.DataSource = Players.Select(o => new Classes.PlayerDisplayTable() { Forname = o.Forname, Surname = o.Surname, DoB = o.DateOfBirth, Role = o.Role}).ToList();
            pnlCommands.Visible = CommandsActive;
                
        }

        public void colourChange()
        {
            ColourChange.ColourPanel(pnlHeader);
            ColourChange.ColourPanel(pnlPlayerInformation);
            ColourChange.ColourPanel(pnlPlayers);
            ColourChange.ColourPanel(pnlCommands);
            ColourChange.ColourPanel(pnlStandard);
            ColourChange.ColourPanel(pnlEdit);
            ColourChange.ColourLabel(lblTeamDetails);
            ColourChange.ColourLabel(lblPlayerInformation);
            ColourChange.ColourLabel(lblForname);
            ColourChange.ColourLabel(lblSurname);
            ColourChange.ColourLabel(lblDoB);
            ColourChange.ColourLabel(lblRole);
            ColourChange.ColourTextbox(txtForname);
            ColourChange.ColourTextbox(txtSurname);
            ColourChange.ColourTextbox(txtRole);

        }
        #endregion

        #region Object Events
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

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            EditMode = 1;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            EditingPlayer = Database.TeamPlayers.FindPlayerID(txtForname.Text, txtSurname.Text, dtpDateOfBirth.Value, txtRole.Text);
            Database.DatabaseConnection.dbDisconnect();
            DetailsAccess(false);
            EditMode = 2;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            Database.DatabaseConnection.dbConnect();
            Database.TeamPlayers.SetAssign(EditingPlayer, TeamID, 0);
            Database.DatabaseConnection.dbDisconnect();
            UpdateParent(this, e);
        }

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

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DetailsAccess(true);
            EditMode = 0;
            UpdateParent(this, e);
        }
        #endregion

        #region Utility Functions
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
        #endregion

    }
}
