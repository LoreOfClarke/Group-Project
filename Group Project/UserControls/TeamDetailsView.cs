using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project.UserControls
{
    public partial class TeamDetailsView : UserControl
    {
        public TeamDetailsView()
        {
            InitializeComponent();
        }


        int EditMode;

        #region Update Handling
        public void update()
        {
            List<Classes.TeamDetails> Teams = new List<Classes.TeamDetails>();
            Database.DatabaseConnection.dbConnect();
            Teams = Database.TeamList.AllTeams();
            Database.DatabaseConnection.dbDisconnect();
            dgvTeams.DataSource = Teams.ToList();
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
            dgvTeams.Enabled = access;
            txtTeamName.ReadOnly = access;
            txtStadium.ReadOnly = access;
            pnlEdit.Visible = !access;
            pnlStandard.Visible = access;
        }
        public void colourChange()
        {
            ColourChange.ColourSplitPanel(splitContainer1);
            ColourChange.ColourPanel(pnlAdmin);
            ColourChange.ColourPanel(pnlEdit);
            ColourChange.ColourPanel(pnlStandard);
            ColourChange.ColourTextbox(txtStadium);
            ColourChange.ColourTextbox(txtTeamName);
            ColourChange.ColourLabel(lblCurrentTeams);
            ColourChange.ColourLabel(lblStadium);
            ColourChange.ColourLabel(lblTeamName);
            ColourChange.ColourDGV(dgvTeams);
            ColourChange.ColourButton(cmdAdd);
            ColourChange.ColourButton(cmdCancel);
            ColourChange.ColourButton(cmdConfirm);
            ColourChange.ColourButton(cmdDelete);
            ColourChange.ColourButton(cmdDelete);
            ColourChange.ColourButton(cmdUpdate);
        }
        #endregion


        #region Object Code

        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count > 0)
            {
                txtTeamName.Text = dgvTeams.SelectedRows[0].Cells[1].Value.ToString();
                txtStadium.Text = dgvTeams.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                txtTeamName.Text = txtStadium.Text = "";
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DetailsAccess(true);
            EditMode = 0;
            UpdateParent(this, e);
        }

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
                    Database.TeamList.Add( txtTeamName.Text, txtStadium.Text);
                    break;
                case 2:
                    Database.TeamList.Update(txtTeamName.Text, txtStadium.Text, int.Parse(dgvTeams.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                default:
                    MessageBox.Show("Error: Attempted Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Database.DatabaseConnection.dbDisconnect();
            EditMode = 0;
            UpdateParent(this, e);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            EditMode = 1;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            DetailsAccess(false);
            EditMode = 2;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            Database.TeamList.Delete(int.Parse(dgvTeams.SelectedRows[0].Cells[0].Value.ToString()));
            Database.DatabaseConnection.dbDisconnect();
        }

        #endregion
    }
}
