using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project.UserControls
{
    public partial class PasswordControlView : UserControl
    {
        public PasswordControlView()
        {
            InitializeComponent();
        }

        List<Classes.Password> Passwords;
        List<Classes.TeamDetails> TeamList;

        public int EditMode;
        public string Edituser;

        #region Update Handling
        public void update()
        {
            Database.DatabaseConnection.dbConnect();
            TeamList = Database.TeamList.AllTeams();
            Passwords = Database.PasswordList.Fill();
            Database.DatabaseConnection.dbDisconnect();
            dgvPasswords.DataSource = Passwords.Select(o => new Classes.PasswordTableDisplay() { Name = o.Username, Access_Level = o.AccessRights }).ToList();
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
            dgvPasswords.Enabled = access;
            txtUsername.ReadOnly = access;
            txtPassword.ReadOnly = access;
            txtPasswordVerfic.ReadOnly = access;
            cboAccess.Items.Clear();
            if (!access)
            {
                cboAccess.SelectedText = "";
                cboAccess.Items.Add("ADMINISTRATOR");
                foreach (Classes.TeamDetails Team in TeamList)
                {
                    cboAccess.Items.Add(Team.TeamID);
                }
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
            ColourChange.ColourTextbox(txtUsername);
            ColourChange.ColourTextbox(txtPassword);
            ColourChange.ColourTextbox(txtPasswordVerfic);
            ColourChange.ColourCombobox(cboAccess);
            ColourChange.ColourLabel(lblAccess);
            ColourChange.ColourLabel(lblCurrentLogins);
            ColourChange.ColourLabel(lblPassword);
            ColourChange.ColourLabel(lblPasswordVerific);
            ColourChange.ColourLabel(lblUsername);
            ColourChange.ColourDGV(dgvPasswords);
            ColourChange.ColourButton(cmdAdd);
            ColourChange.ColourButton(cmdCancel);
            ColourChange.ColourButton(cmdConfirm);
            ColourChange.ColourButton(cmdDelete);
            ColourChange.ColourButton(cmdDelete);
            ColourChange.ColourButton(cmdUpdate);
        }
        #endregion

        #region Object Code
        private void dgvPasswords_SelectionChanged(object sender, EventArgs e)
        {
            cboAccess.Items.Clear();
            if (dgvPasswords.SelectedRows.Count > 0)
            {
                txtUsername.Text = dgvPasswords.SelectedRows[0].Cells[0].Value.ToString();
                cboAccess.Items.Add(dgvPasswords.SelectedRows[0].Cells[1].Value.ToString());
                cboAccess.SelectedIndex = 0;
            }
            else
            {
                txtUsername.Text = txtPassword.Text = txtPasswordVerfic.Text = "";
            }
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
            Edituser = txtUsername.Text;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            Database.DatabaseConnection.dbConnect();
            Database.PasswordList.Delete(txtUsername.Text);
            Database.DatabaseConnection.dbDisconnect();
        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordVerfic.Text)
            {
                DetailsAccess(true);
                Database.DatabaseConnection.dbConnect();
                switch (EditMode)
                {
                    case 0:
                        MessageBox.Show("Error: Attempted Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                        Database.PasswordList.Add(txtUsername.Text, txtPassword.Text, cboAccess.Text);
                        break;
                    case 2:
                        Database.PasswordList.Update(txtUsername.Text, txtPassword.Text, cboAccess.Text);
                        break;
                    default:
                        MessageBox.Show("Error: Attempted Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                Database.DatabaseConnection.dbDisconnect();
                EditMode = 0;
                UpdateParent(this, e);
            }
            else MessageBox.Show("Error: Password and Password Verification do not contain the same text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
