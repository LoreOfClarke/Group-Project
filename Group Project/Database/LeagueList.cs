using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group_Project.Database
{
    static class LeagueList
    {
        public static List<Classes.League> Fill(OleDbConnection DBConnection)
        {
            List<Classes.League> LeagueList = new List<Classes.League>();
            try
            {
                OleDbCommand command = new OleDbCommand("Select * from League;", DBConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Classes.League League = new Classes.League();
                    League.LeagueId = Int32.Parse(reader[0].ToString());
                    League.LeagueName = reader[1].ToString();
                    League.Capacity = Int32.Parse(reader[2].ToString());
                    League.Sponsor = reader[3].ToString();
                    LeagueList.Add(League);
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return LeagueList;
        }

        public static List<Classes.League> FillFromTeam(OleDbConnection DBConnection, int TeamID)
        {
            List<Classes.League> LeagueList = new List<Classes.League>();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT League.LeagueID, League.LeagueName, League.Capacity, League.Sponsor FROM League INNER JOIN TeamLeague ON League.LeagueID = TeamLeague.LeagueID WHERE(((TeamLeague.TeamID) = 1)); ", DBConnection);
                command.Parameters.Add(new OleDbParameter("@varteam", TeamID));
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Classes.League League = new Classes.League();
                    League.LeagueId = Int32.Parse(reader[0].ToString());
                    League.LeagueName = reader[1].ToString();
                    League.Capacity = Int32.Parse(reader[2].ToString());
                    League.Sponsor = reader[3].ToString();
                    LeagueList.Add(League);
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return LeagueList;
        }
    }
}
