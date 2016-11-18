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

        public void update(List<Classes.Player> Players)
        {
            dgvTeamDetails.DataSource = Players.Select(o => new Classes.PlayerDisplayTable() { Forname = o.Forname, Surname = o.Surname, DoB = o.DateOfBirth, Role = o.Role}).ToList();  
        }

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

        public void colourChange()
        {
            ColourChange.ColourPanel(pnlHeader);
            ColourChange.ColourPanel(pnlPlayerInformation);
            ColourChange.ColourPanel(pnlPlayers);
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

    }
}
