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
    public partial class LeagueDetailsView : UserControl
    {
        public LeagueDetailsView()
        {
            InitializeComponent();
        }

        int EditMode;

        #region Update Handling
        public void update(List<Classes.League> Leagues)
        {
            dgvLeagues.DataSource = Leagues.ToList();
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
            Database.LeagueList.Delete(int.Parse(dgvLeagues.SelectedRows[0].Cells[0].Value.ToString()));
            Database.DatabaseConnection.dbDisconnect();
        }

        #endregion

    }
}
