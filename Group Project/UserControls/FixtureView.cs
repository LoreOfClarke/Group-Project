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
        public void update(List<Classes.Fixture> Fixtures)
        {
            dgvFixtures.DataSource = Fixtures.Where(a =>  a.Played == false).Select(x => new Classes.FixtureTableDisplay() { Home_Team = x.HomeTeamName, Away_Team = x.AwayTeamName, Date = x.FixtureDate, Time = x.FixtureTime }).ToList();
            dgvFixtures.Columns[3].DefaultCellStyle.Format = "hh:mm tt";
            dgvResults.DataSource = Fixtures.Where(a=> a.Played).Select(x => new Classes.ResultsTableDisplay() { Home_Team = x.HomeTeamName, Away_Team = x.AwayTeamName, Score = x.GoalsFor + " - " + x.GoalsAgainst, Date = x.FixtureDate, Time = x.FixtureTime }).ToList(); ;
            dgvResults.Columns[4].DefaultCellStyle.Format = "hh:mm tt";
        }

        public void colourChange()
        {
            //ColourChange.ColourPanel(spnlFixtures);
            //ColourChange.ColourPanel(spnlHeader);
            ColourChange.ColourLabel(lblFixtures);
            ColourChange.ColourLabel(lblResults);
            ColourChange.ColourDGV(dgvFixtures);
            ColourChange.ColourDGV(dgvResults);
        }
    }
}
