using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project.PublicViewUserControls
{
    public partial class LeagueView : UserControl
    {

        public LeagueView()
        {
            InitializeComponent();
        }

        public void update(List<Classes.Team> Teams)
        {
            dgvLeaguePositions.DataSource = Teams.Select(o => new Classes.LeagueTableDisplay() { Name = o.TeamName, GP = o.Matches, W = o.GamesWon, D = o.GamesDrawn, L = o.GamesLost, GF = o.GoalsFor, GA = o.GoalsAgainst, Pts = o.Points }).ToList();
            //Sort by points
        }

        public void ChangeColour()
        {
            ColourChange.ColourPanel(pnlMain);
            ColourChange.ColourPanel(pnlTitle);
            ColourChange.ColourLabel(lblTitle);
            ColourChange.ColourDGV(dgvLeaguePositions);
        }
    }
}
