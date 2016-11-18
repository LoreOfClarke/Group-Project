using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    class TeamPlayers
    {
        public static List<Classes.Player> Fill(OleDbConnection DBConnection, int TeamID)
        {
            List<Classes.Player> PlayerList = new List<Classes.Player>();
            //add data from team table
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT Staff.StaffID, Staff.Forename, Staff.Surname, Staff.DOB, Staff.Role FROM Staff INNER JOIN StaffEmployed ON Staff.StaffID = StaffEmployed.StaffID WHERE(((StaffEmployed.TeamID) = @varTeamID) AND((StaffEmployed.Active) = True)); ", DBConnection);
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
    }
}
