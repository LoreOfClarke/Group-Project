using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    static class TeamList
    {
        public static List<Classes.Team> Fill(OleDbConnection DBConnection, int League)
        {
            List<Classes.Team> TeamList = new List<Classes.Team>();
            Classes.Team Team = new Classes.Team();
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT Teams.TeamID, Teams.TeamName, Teams.Stadium FROM Teams INNER JOIN TeamLeague ON Teams.TeamID = TeamLeague.TeamID WHERE (((TeamLeague.Active)=True) AND ((TeamLeague.LeagueID)=@varleague));", DBConnection);
                command.Parameters.Add(new OleDbParameter("@varleague", League));
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Team.TeamID = Int32.Parse(reader[0].ToString());
                    
                    Team.TeamName = reader[1].ToString();
                    Team.Stadium = reader[2].ToString();
                    TeamList.Add(Team);
                }
                MessageBox.Show(TeamList[0].TeamName.ToString());
                MessageBox.Show(TeamList[1].TeamName.ToString());
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return TeamList;
        }
    }
}
