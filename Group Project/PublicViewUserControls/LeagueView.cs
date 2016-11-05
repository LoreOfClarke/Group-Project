using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project.PublicViewUserControls
{
    public partial class LeagueView : UserControl
    {
        public LeagueView()
        {
            InitializeComponent();
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
