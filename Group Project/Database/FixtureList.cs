using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group_Project.Database
{
    class FixtureList
    {
        public static List<Classes.Fixture> Fill(OleDbConnection DBConnection,int League, int TeamID)
        {
            List<Classes.Fixture> FixtureList = new List<Classes.Fixture>();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT TeamFixtures.FixtureID, TeamFixtures.HomeTeam, Teams.TeamName, TeamFixtures.AwayTeam, Teams_1.TeamName, TeamFixtures.FixtureDate, TeamFixtures.FixtureTime, TeamFixtures.Played, TeamFixtures.GoalsFor, TeamFixtures.GoalsAgainst FROM Teams AS Teams_1 INNER JOIN(Teams INNER JOIN TeamFixtures ON Teams.TeamID = TeamFixtures.[HomeTeam]) ON Teams_1.TeamID = TeamFixtures.AwayTeam WHERE(((TeamFixtures.LeagueID) = @varLeague) AND ((Teams.TeamID)= @varTeam) OR ((Teams_1.TeamID)=@varTeam)); ", DBConnection);
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
    }
}
