using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    class TeamLeague
    {
        public static Boolean CheckExists(int LeagueID, int TeamID)
        {
            OleDbCommand command;
            command = new OleDbCommand("SELECT Active FROM TeamLeague WHERE LeagueID = @varLeagueID AND TeamID = @varTeamID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varLeagueID", LeagueID));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID));
            OleDbDataReader reader = command.ExecuteReader();
            return reader.HasRows;
        }
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
        public static void CreateAssign(int LeagueID, int TeamID)
        {
            OleDbCommand command;
            command = new OleDbCommand("INSERT INTO TeamLeague (LeagueID, TeamID, DateChanged, Active) VALUES (@varLeagueID, @varTeamID, @varNow, -1)  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varLeagueID", LeagueID.ToString()));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID.ToString()));
            command.Parameters.Add(new OleDbParameter("@varNow", DateTime.Now.ToString()));
            command.ExecuteNonQuery();
        }

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
