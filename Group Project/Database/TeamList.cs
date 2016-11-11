using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Linq;

namespace Group_Project.Database
{
    static class TeamList
    {
        public static List<Classes.Team> Fill(OleDbConnection DBConnection, int League)
        {
            List<Classes.Team> TeamList = new List<Classes.Team>();
            //add data from team table
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT Teams.TeamID, Teams.TeamName, Teams.Stadium FROM Teams INNER JOIN TeamLeague ON Teams.TeamID = TeamLeague.TeamID WHERE (((TeamLeague.Active)=True) AND ((TeamLeague.LeagueID)=@varleague));", DBConnection);
                command.Parameters.Add(new OleDbParameter("@varleague", League));
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Classes.Team Team = new Classes.Team();
                    Team.TeamID = Int32.Parse(reader[0].ToString());
                    Team.TeamName = reader[1].ToString();
                    Team.Stadium = reader[2].ToString();
                    TeamList.Add(Team);
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            //add score data from league table
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT TeamFixtures.HomeTeam, TeamFixtures.GoalsFor, TeamFixtures.AwayTeam, TeamFixtures.GoalsAgainst FROM TeamFixtures WHERE(((TeamFixtures.LeagueID) = @varLeague)); ", DBConnection);
                command.Parameters.Add(new OleDbParameter("@varleague", League));
                OleDbDataReader reader = command.ExecuteReader();
                Classes.Team Home = new Classes.Team();
                Classes.Team Away = new Classes.Team();
                while (reader.Read())
                {
                    Home = TeamList.Find(x => x.TeamID == Int32.Parse(reader[0].ToString()));
                    Away = TeamList.Find(x => x.TeamID == Int32.Parse(reader[2].ToString()));
                    Home.GoalsFor += Int32.Parse(reader[1].ToString());
                    Home.GoalsAgainst += Int32.Parse(reader[3].ToString());
                    Away.GoalsFor += Int32.Parse(reader[3].ToString());
                    Away.GoalsAgainst += Int32.Parse(reader[1].ToString());
                    if (Int32.Parse(reader[1].ToString()) > Int32.Parse(reader[3].ToString()))
                    {
                        Home.GamesWon += 1;
                        Away.GamesLost += 1;
                    }
                    else if (Int32.Parse(reader[1].ToString()) < Int32.Parse(reader[3].ToString()))
                    {
                        Home.GamesLost += 1;
                        Away.GamesWon += 1;
                    }
                    else if (Int32.Parse(reader[1].ToString()) == Int32.Parse(reader[3].ToString()))
                    {
                        Home.GamesDrawn += 1;
                        Away.GamesDrawn += 1;
                    }
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }

            return TeamList;
        }
    }
}
