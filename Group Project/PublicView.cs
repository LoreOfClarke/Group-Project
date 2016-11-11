using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group_Project
{
    public partial class FrontPage : Form
    {
        private List<Classes.League> LeagueList = new List<Classes.League>();
        private List<Classes.Team> TeamList = new List<Classes.Team>();
        public FrontPage()
        {
            InitializeComponent();
        }

        #region Initial Setup

        private void FrontPage_Load(object sender, EventArgs e)
        {
            Database.DatabaseConnection DatabaseConnection = new Database.DatabaseConnection();
            DatabaseConnection.dbConnect();
            FillLeagues(DatabaseConnection.DBConnection);
            DatabaseConnection.dbDisconnect();
        }

        private void FillLeagues(OleDbConnection dbconn)
        {
            LeagueList = Database.LeagueList.Fill(dbconn);
            foreach (Classes.League lg in LeagueList)
            {
                tscbLeague.Items.Add(lg.LeagueName);
            }
            tscbLeague.SelectedIndex = 0;
            FillTeams(dbconn,LeagueList.FirstOrDefault(x => x.LeagueName == tscbLeague.Text).LeagueId);
        }

        private void FillTeams(OleDbConnection dbconn ,int League)
        {
            TeamList = Database.TeamList.Fill(dbconn, League);
            foreach (Classes.Team tm in TeamList)
            {
                tscbTeam.Items.Add(tm.TeamName);
            }
            tscbTeam.SelectedIndex = 0;
            update();
        }
        #endregion

        #region Global Updates
        public void update()
        {
            leagueView1.update(TeamList);
        }
        #endregion
    }
}
