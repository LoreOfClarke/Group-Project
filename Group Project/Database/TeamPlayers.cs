using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    class TeamPlayers
    {
        /// <summary>
        /// Fill a list of classes of all of the players in a team
        /// </summary>
        /// <param name="TeamID">The ID of the team</param>
        /// <returns>a list of classes of all of the players in a team</returns>
        public static List<Classes.Player> Fill(int TeamID)
        {
            List<Classes.Player> PlayerList = new List<Classes.Player>();
            //add data from team table
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT Staff.StaffID, Staff.Forename, Staff.Surname, Staff.DOB, Staff.Role FROM Staff INNER JOIN StaffEmployed ON Staff.StaffID = StaffEmployed.StaffID WHERE(((StaffEmployed.TeamID) = @varTeamID) AND((StaffEmployed.Active) = True)); ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID));
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Classes.Player Player = new Classes.Player();
                    Player.PlayerID = Int32.Parse(reader[0].ToString());
                    Player.Forname = reader[1].ToString();
                    Player.Surname = reader[2].ToString();
                    Player.DateOfBirth = DateTime.Parse(reader[3].ToString());
                    Player.Role = reader[4].ToString();
                    PlayerList.Add(Player);
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return PlayerList;
        }
        /// <summary>
        /// Add a new player to the team
        /// </summary>
        /// <param name="Forname">The forname of the player</param>
        /// <param name="surname">The surname of the player</param>
        /// <param name="DateOfBirth">The Date the player was born</param>
        /// <param name="Role">The player's role in the team</param>
        public static void Add(String Forname, String surname, DateTime DateOfBirth, String Role)
        {
            OleDbCommand command;
            command = new OleDbCommand("INSERT INTO Staff (Forename, Surname, DOB, Role) VALUES (@varForname, @varSurname, @varDOB, @varRole)  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varForname", Forname));
            command.Parameters.Add(new OleDbParameter("@varSurname", surname));
            command.Parameters.Add(new OleDbParameter("@varDOB", DateOfBirth.ToString()));
            command.Parameters.Add(new OleDbParameter("@varRole", Role));
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Assign an esisting player to a team, creating a new record
        /// </summary>
        /// <param name="PlayerID">THe ID of the player being assigned</param>
        /// <param name="TeamID">The ID of the team the player is assigned to</param>
        public static void CreateAssign(int PlayerID, int TeamID)
        {
            OleDbCommand command;
            command = new OleDbCommand("INSERT INTO StaffEmployed (StaffID, TeamID, Active) VALUES (@varPlayerID, @varTeamID, 1)  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varPlayerID", PlayerID));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID));
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Assign or unassign an existing player to a team that he has played in before, updating a new record
        /// </summary>
        /// <param name="PlayerID">THe ID of the player being assigned</param>
        /// <param name="TeamID">The ID of the team the player is assigned to</param>
        /// <param name="Active">0 if the player is leaving the team, 1 if he is joining the team</param>
        public static void SetAssign(int PlayerID, int TeamID, int Active)
        {
            OleDbCommand command;
            command = new OleDbCommand("UPDATE StaffEmployed SET Active = @varActive WHERE StaffID = @varPlayerID AND TeamID = @varTeamID ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varActive", Active.ToString()));
            command.Parameters.Add(new OleDbParameter("@varPlayerID", PlayerID.ToString()));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID.ToString()));
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Edit a Player's Details
        /// </summary>
        /// <param name="PlayerID">The ID of the player being edited</param>
        /// <param name="Forname">The forname of the player</param>
        /// <param name="surname">The surname of the player</param>
        /// <param name="DateOfBirth">The Date the player was born</param>
        /// <param name="Role">The player's role in the team</param>
        public static void Edit(int PlayerID, String Forname, String surname, DateTime DateOfBirth, String Role)
        {
            OleDbCommand command;
            command = new OleDbCommand("UPDATE Staff SET  Forename = @varForname, Surname = @varSurname, DOB = @varDOB, Role = varRole WHERE StaffID = @varPlayerID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varForname", Forname));
            command.Parameters.Add(new OleDbParameter("@varSurname", surname));
            command.Parameters.Add(new OleDbParameter("@varDOB", DateOfBirth.ToString()));
            command.Parameters.Add(new OleDbParameter("@varRole", Role));
            command.Parameters.Add(new OleDbParameter("@varPlayerID", PlayerID.ToString()));
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Find a plaer's ID given heir other details
        /// </summary>
        /// <param name="Forname">The forname of the player</param>
        /// <param name="surname">The surname of the player</param>
        /// <param name="DateOfBirth">The Date the player was born</param>
        /// <param name="Role">The player's role in the team</param>
        /// <returns>0 if the player does not exist, otherwise it display's the player's ID</returns>
        public static int FindPlayerID (String Forname, String surname, DateTime DateOfBirth, String Role)
        {
            OleDbCommand command;
            command = new OleDbCommand("SELECT StaffID FROM Staff WHERE Forename = @varForname AND Surname = @varSurname AND DOB = @varDOB AND Role = varRole ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varForname", Forname));
            command.Parameters.Add(new OleDbParameter("@varSurname", surname));
            command.Parameters.Add(new OleDbParameter("@varDOB", DateOfBirth.ToString()));
            command.Parameters.Add(new OleDbParameter("@varRole", Role));
            OleDbDataReader reader = command.ExecuteReader();
            int playerid = 0;
            while (reader.Read())
            {
                playerid = int.Parse(reader[0].ToString());
            }
            return playerid;
        }
        /// <summary>
        /// Delete a player, given their ID
        /// </summary>
        /// <param name="PlayerID"></param>
        public static void Delete(int PlayerID)
        {
            OleDbCommand command;
            command = new OleDbCommand("DELETE FROM Staff WHERE StaffID = @varPlayerID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varPlayerID", PlayerID.ToString()));
            command.ExecuteNonQuery();
        }
    }
}
