using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    class TeamLeague
    {
        /// <summary>
        /// Check whether or not there is a record in the database to be edited, or if it needs to be created
        /// </summary>
        /// <param name="LeagueID">The league that the team will play in</param>
        /// <param name="TeamID">The playing team</param>
        /// <returns>True if a record exists, False if a record needs to be created</returns>
        public static Boolean CheckExists(int LeagueID, int TeamID)
        {
            OleDbCommand command;
            command = new OleDbCommand("SELECT Active FROM TeamLeague WHERE LeagueID = @varLeagueID AND TeamID = @varTeamID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varLeagueID", LeagueID));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID));
            OleDbDataReader reader = command.ExecuteReader();
            return reader.HasRows;
        }
        /// <summary>
        /// Check whether or not a team is assigned to a league
        /// </summary>
        /// <param name="LeagueID">The ID of the league being checked</param>
        /// <param name="TeamID">The ID of the team being checked</param>
        /// <returns>True if the team is playing in the league. False if they are not.</returns>
        public static Boolean CheckAssign(int LeagueID, int TeamID)
        {
            OleDbCommand command;
            command = new OleDbCommand("SELECT Active FROM TeamLeague WHERE LeagueID = @varLeagueID AND TeamID = @varTeamID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varLeagueID", LeagueID));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID));
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    switch (reader[0].ToString())
                    {
                        case "False":
                            return false;
                        case "True":
                            return true;
                        default:
                            //MessageBox.Show("ERROR IN DATABASE: BOOL NOT TRUE OR FALSE", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(reader[0].ToString());
                            break;
                    }
                }
            }
            return reader.HasRows;
        }
        /// <summary>
        /// Create a record in the table (this means no record was there previously, and so also includes assigning the team and league together.
        /// </summary>
        /// <param name="LeagueID">The ID of the league being assigned</param>
        /// <param name="TeamID">The ID of the team being assigned</param>
        public static void CreateAssign(int LeagueID, int TeamID)
        {
            OleDbCommand command;
            command = new OleDbCommand("INSERT INTO TeamLeague (LeagueID, TeamID, DateChanged, Active) VALUES (@varLeagueID, @varTeamID, @varNow, -1)  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varLeagueID", LeagueID.ToString()));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID.ToString()));
            command.Parameters.Add(new OleDbParameter("@varNow", DateTime.Now.ToString()));
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Set the record of the team and leage to either assgn them together or seperate them.
        /// </summary>
        /// <param name="LeagueID">The ID of the league being (un)assigned</param>
        /// <param name="TeamID">The ID of the team being (un)assigned</param>
        /// <param name="Active">0 if the team is being unassigned, 1 if the team is being assigned</param>
        public static void SetAssign(int LeagueID, int TeamID, int Active)
        {
            OleDbCommand command;
            command = new OleDbCommand("UPDATE TeamLeague SET Active = @varActive, DateChanged = @varNow WHERE LeagueID = @varLeagueID AND TeamID = @varTeamID ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varActive", Active.ToString()));
            command.Parameters.Add(new OleDbParameter("@varNow", DateTime.Now.ToString()));
            command.Parameters.Add(new OleDbParameter("@varLeagueID", LeagueID.ToString()));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID.ToString()));
            command.ExecuteNonQuery();
        }
    }
}
