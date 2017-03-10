using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    static class TeamList
    {
        /// <summary>
        /// Fill a list of classs with all of the teams in a league
        /// </summary>
        /// <param name="League">The ID of the league being searched</param>
        /// <returns>a list of classs with all of the teams in a league</returns>
        public static List<Classes.Team> Fill(int League)
        {
            List<Classes.Team> TeamList = new List<Classes.Team>();
            //add data from team table
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT Teams.TeamID, Teams.TeamName, Teams.Stadium FROM Teams INNER JOIN TeamLeague ON Teams.TeamID = TeamLeague.TeamID WHERE (((TeamLeague.Active)=True) AND ((TeamLeague.LeagueID)=@varleague));", Database.DatabaseConnection.DBConnection);
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
                command = new OleDbCommand("SELECT TeamFixtures.HomeTeam, TeamFixtures.GoalsFor, TeamFixtures.AwayTeam, TeamFixtures.GoalsAgainst FROM TeamFixtures WHERE(((TeamFixtures.LeagueID) = @varLeague)); ",Database.DatabaseConnection.DBConnection);
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
        /// <summary>
        /// Fill a list of classes with all teams on record
        /// </summary>
        /// <returns>a list of classes containing all teams in the database</returns>
        public static List<Classes.TeamDetails> AllTeams()
        {
            List<Classes.TeamDetails> List = new List<Classes.TeamDetails>();
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT Teams.TeamID, Teams.TeamName, Teams.Stadium FROM Teams;", Database.DatabaseConnection.DBConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Classes.TeamDetails Team = new Classes.TeamDetails();
                    Team.TeamID = Int32.Parse(reader[0].ToString());
                    Team.TeamName = reader[1].ToString();
                    Team.Stadium = reader[2].ToString();
                    List.Add(Team);
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return List;
        }
        /// <summary>
        /// Add a new team
        /// </summary>
        /// <param name="TeamName">The name of the team</param>
        /// <param name="Stadium">The stadium a team plays in</param>
        public static void Add(string TeamName, string Stadium)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO Teams (TeamName, Stadium) VALUES (@varTeamName, @varStadium) ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varTeamName", TeamName.ToString()));
                command.Parameters.Add(new OleDbParameter("@varStadium", Stadium.ToString()));
                command.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
        }
        /// <summary>
        /// Update a team's details
        /// </summary>
        /// <param name="TeamName">The new name of the team</param>
        /// <param name="Stadium">The new staduim</param>
        /// <param name="TeamID"> The ID of the team being updated</param>
        public static void Update(string TeamName, string Stadium, int TeamID)
        {
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("UPDATE Teams SET  TeamName = @varTeamName, Stadium = @varStadium WHERE TeamID = @varTeamID", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varTeamName", TeamName.ToString()));
                command.Parameters.Add(new OleDbParameter("@varStadium", Stadium.ToString()));
                command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID));
                command.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
        }
        /// <summary>
        /// Delete a team
        /// </summary>
        /// <param name="TeamID">The ID of the team to delete</param>
        public static void Delete(int TeamID)
        {
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("DELETE FROM Teams WHERE TeamID = @varTeamID  ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID.ToString()));
                command.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
        }
        
    }
}
