using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group_Project.Database
{
    class FixtureList
    {
        /// <summary>
        /// fill a list of fixtures that a team perfoms in any particular league, home or away.
        /// </summary>
        /// <param name="League">The league being searched</param>
        /// <param name="TeamID">The team being reaquested</param>
        /// <returns> a list of fixtures that the team perfoms in the given  league, home or away.</returns>
        public static List<Classes.Fixture> FillLeague(int League, int TeamID)
        {
            List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT TeamFixtures.FixtureID, TeamFixtures.HomeTeam, Teams.TeamName, TeamFixtures.AwayTeam, Teams_1.TeamName, TeamFixtures.FixtureDate, TeamFixtures.FixtureTime, TeamFixtures.Played, TeamFixtures.GoalsFor, TeamFixtures.GoalsAgainst FROM Teams AS Teams_1 INNER JOIN(Teams INNER JOIN TeamFixtures ON Teams.TeamID = TeamFixtures.[HomeTeam]) ON Teams_1.TeamID = TeamFixtures.AwayTeam WHERE(((TeamFixtures.LeagueID) = @varLeague) AND ((Teams.TeamID)= @varTeam) OR ((Teams_1.TeamID)=@varTeam)); ",Database.DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varleague", League));
                command.Parameters.Add(new OleDbParameter("@varTeam", TeamID));
                command.Parameters.Add(new OleDbParameter("@varTeam", TeamID));
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Classes.Fixture Fixture = new Classes.Fixture();
                    Fixture.FixtureID = int.Parse(reader[0].ToString());
                    Fixture.HomeTeamID = int.Parse(reader[1].ToString());
                    Fixture.HomeTeamName = reader[2].ToString();
                    Fixture.AwayTeamID = int.Parse(reader[3].ToString());
                    Fixture.AwayTeamName = reader[4].ToString();
                    Fixture.FixtureDate = DateTime.Parse(reader[5].ToString());
                    Fixture.FixtureTime = DateTime.Parse(reader[6].ToString());
                    if (reader[7].ToString() == "True") Fixture.Played = true; else Fixture.Played = false;
                    Fixture.GoalsFor = reader[8].ToString();
                    Fixture.GoalsAgainst = reader[9].ToString();
                    FixtureList.Add(Fixture);
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return FixtureList;
        }
        /// <summary>
        /// fill a list of fixtures that a team perfoms, home or away.
        /// </summary>
        /// <param name="TeamID">The team being reaquested</param>
        /// <returns>a list of fixtures that the team perfoms</returns>
        public static List<Classes.Fixture> Fill(int TeamID)
        {
            List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT TeamFixtures.FixtureID, TeamFixtures.HomeTeam, Teams.TeamName, TeamFixtures.AwayTeam, Teams_1.TeamName, TeamFixtures.FixtureDate, TeamFixtures.FixtureTime, TeamFixtures.Played, TeamFixtures.GoalsFor, TeamFixtures.GoalsAgainst FROM Teams AS Teams_1 INNER JOIN(Teams INNER JOIN TeamFixtures ON Teams.TeamID = TeamFixtures.[HomeTeam]) ON Teams_1.TeamID = TeamFixtures.AwayTeam WHERE(((Teams.TeamID)= @varTeam) OR ((Teams_1.TeamID)=@varTeam)); ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varTeam", TeamID));
                command.Parameters.Add(new OleDbParameter("@varTeam", TeamID));
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Classes.Fixture Fixture = new Classes.Fixture();
                    Fixture.FixtureID = int.Parse(reader[0].ToString());
                    Fixture.HomeTeamID = int.Parse(reader[1].ToString());
                    Fixture.HomeTeamName = reader[2].ToString();
                    Fixture.AwayTeamID = int.Parse(reader[3].ToString());
                    Fixture.AwayTeamName = reader[4].ToString();
                    Fixture.FixtureDate = DateTime.Parse(reader[5].ToString());
                    Fixture.FixtureTime = DateTime.Parse(reader[6].ToString());
                    if (reader[7].ToString() == "True") Fixture.Played = true; else Fixture.Played = false;
                    Fixture.GoalsFor = reader[8].ToString();
                    Fixture.GoalsAgainst = reader[9].ToString();
                    FixtureList.Add(Fixture);
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return FixtureList;
        }
        /// <summary>
        /// Add a fixture.
        /// </summary>
        /// <param name="leagueID">The league, to which the fixture counts</param>
        /// <param name="HometeamID">The team Playing at home</param>
        /// <param name="AwayteamID">The team playing away</param>
        /// <param name="Date">The date of the fixture</param>
        /// <param name="Time">The time of the kickoff</param>
        public static void Add(int leagueID, int HometeamID, int AwayteamID, DateTime Date, DateTime Time)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO TeamFixtures (LeagueID, HomeTeam, AwayTeam, FixtureDate, FixtureTime, GoalsFor, GoalsAgainst, Played) VALUES (@LeagueID, @HomeID, @AwayID, @FixtureDate, @FixtureTime, 0,0,0) ; ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@LeagueID", leagueID));
                command.Parameters.Add(new OleDbParameter("@HomeID", HometeamID));
                command.Parameters.Add(new OleDbParameter("@AwayID", AwayteamID));
                command.Parameters.Add(new OleDbParameter("@FixtureDate", DateTime.Parse(Date.ToString("dd/MM/yyyy"))));
                command.Parameters.Add(new OleDbParameter("@FixtureTime", DateTime.Parse(Time.ToString("HH:mm"))));
                command.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
        }
        /// <summary>
        /// Edit an unplayed fixture
        /// </summary>
        /// <param name="FixtureID">The fixture being edited</param>
        /// <param name="HometeamID">The team Playing at home</param>
        /// <param name="AwayteamID">The team playing away</param>
        /// <param name="Date">The date of the fixture</param>
        /// <param name="Time">The time of the kickoff</param>
        public static void EditFixture(int FixtureID, int HomeTeam, int AwayTeam, DateTime FixtureDate, DateTime FixtureTime)
        {
            OleDbCommand command;
            command = new OleDbCommand("UPDATE TeamFixtures SET  HomeTeam = @varHomeTeam, AwayTeam = @varAwayTeam, FixtureDate = @varFixtureDate, FixtureTime = @varFixtureTime  WHERE FixtureID = @varFixtureID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varHomeTeam", HomeTeam.ToString()));
            command.Parameters.Add(new OleDbParameter("@varAwayTeam", AwayTeam.ToString()));
            command.Parameters.Add(new OleDbParameter("@varFixtureDate", DateTime.Parse(FixtureDate.ToString("dd/MM/yyyy"))));
            command.Parameters.Add(new OleDbParameter("@varFixtureTime", DateTime.Parse(FixtureTime.ToString("HH:mm"))));
            command.Parameters.Add(new OleDbParameter("@varFixtureID", FixtureID.ToString()));
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Find a fixture's ID
        /// </summary>
        /// <param name="HometeamID">The team Playing at home</param>
        /// <param name="AwayteamID">The team playing away</param>
        /// <param name="Date">The date of the fixture</param>
        /// <param name="Time">The time of the kickoff</param>
        /// <returns></returns>
        public static int FindFixtureID(int HomeTeam, int AwayTeam, DateTime FixtureDate, DateTime FixtureTime)
        {
            OleDbCommand command;
            command = new OleDbCommand("SELECT FixtureID FROM TeamFixtures WHERE HomeTeam = @varHomeTeam AND AwayTeam = @varAwayTeam AND FixtureDate = @varFixtureDate AND FixtureTime = @varFixtureTime ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varHomeTeam", HomeTeam.ToString()));
            command.Parameters.Add(new OleDbParameter("@varAwayTeam", AwayTeam.ToString()));
            command.Parameters.Add(new OleDbParameter("@varFixtureDate", DateTime.Parse(FixtureDate.ToString("dd/MM/yyyy"))));
            command.Parameters.Add(new OleDbParameter("@varFixtureTime", DateTime.Parse(FixtureTime.ToString("HH:mm"))));
            OleDbDataReader reader = command.ExecuteReader();
            int FixtureID = 0;
            while (reader.Read())
            {
                FixtureID = int.Parse(reader[0].ToString());
            }
            return FixtureID;
        }
        /// <summary>
        /// Delete a fixture
        /// </summary>
        /// <param name="FixtureID">The ID of the fixture being deleted</param>
        public static void DeleteFixture(int FixtureID)
        {
            OleDbCommand command;
            command = new OleDbCommand("DELETE FROM TeamFixtures WHERE FixtureID = @varFixtureID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varFixtureID", FixtureID.ToString()));
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Add a soce to the fixture.
        /// </summary>
        /// <param name="FixtureID">The ID of the fixture being edited</param>
        /// <param name="HomeGoals">The amount of home goals</param>
        /// <param name="AwayGoals">The amout of away goals</param>
        public static void AddResult(int FixtureID, int HomeGoals, int AwayGoals)
        {
            OleDbCommand command;
            command = new OleDbCommand("UPDATE TeamFixtures SET  GoalsFor = @varGoalsFor, GoalsAgainst = @varGoalsAgainst, Played = 1 WHERE FixtureID = @varFixtureID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varGoalsFor", HomeGoals.ToString()));
            command.Parameters.Add(new OleDbParameter("@varGoalsAgainst", AwayGoals.ToString()));
            command.Parameters.Add(new OleDbParameter("@varFixtureID", FixtureID.ToString()));
            command.ExecuteNonQuery();
        }
    }
}
