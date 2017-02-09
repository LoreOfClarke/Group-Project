using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    class TeamPlayers
    {
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

        public static void CreateAssign(int PlayerID, int TeamID)
        {
            OleDbCommand command;
            command = new OleDbCommand("INSERT INTO StaffEmployed (StaffID, TeamID, Active) VALUES (@varPlayerID, @varTeamID, 1)  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varPlayerID", PlayerID));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID));
            command.ExecuteNonQuery();
        }

        public static void SetAssign(int PlayerID, int TeamID, int Active)
        {
            OleDbCommand command;
            command = new OleDbCommand("UPDATE StaffEmployed SET Active = @varActive WHERE StaffID = @varPlayerID AND TeamID = @varTeamID ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varActive", Active.ToString()));
            command.Parameters.Add(new OleDbParameter("@varPlayerID", PlayerID.ToString()));
            command.Parameters.Add(new OleDbParameter("@varTeamID", TeamID.ToString()));
            command.ExecuteNonQuery();
        }

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

        public static void Delete(int PlayerID)
        {
            OleDbCommand command;
            command = new OleDbCommand("DELETE FROM Staff WHERE StaffID = @varPlayerID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varPlayerID", PlayerID.ToString()));
            command.ExecuteNonQuery();
        }
    }
}
