using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group_Project.Database
{
    static class LeagueList
    {
        /// <summary>
        /// FIll a list of classes with all of the leagues
        /// </summary>
        /// <returns>A list of all of the leagues</returns>
        public static List<Classes.League> Fill()
        {
            List<Classes.League> LeagueList = new List<Classes.League>();
            try
            {
                OleDbCommand command = new OleDbCommand("Select * from League;", Database.DatabaseConnection.DBConnection);
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
        /// <summary>
        /// FIll a list of classes with all of the leagues that a team plays in
        /// </summary>
        /// <param name="TeamID">The team who's leagues are being searched.</param>
        /// <returns>A list of all of the leagues that the team plays in</returns>
        public static List<Classes.League> FillFromTeam( int TeamID)
        {
            List<Classes.League> LeagueList = new List<Classes.League>();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT League.LeagueID, League.LeagueName, League.Capacity, League.Sponsor FROM League INNER JOIN TeamLeague ON League.LeagueID = TeamLeague.LeagueID WHERE(((TeamLeague.TeamID) = 1)); ", Database.DatabaseConnection.DBConnection);
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
        /// <summary>
        /// Add a new league
        /// </summary>
        /// <param name="LeagueName">The name of the league</param>
        /// <param name="Capacity">The league's Capacity</param>
        /// <param name="Sponsor">The League's sponsor</param>
        public static void Add(string LeagueName, int Capacity, string Sponsor)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO League (LeagueName, Capacity, Sponsor) VALUES (@varLeagueName, @varCapacity, @varSponsor) ; ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varLeagueName", LeagueName));
                command.Parameters.Add(new OleDbParameter("@varCapacity", Capacity));
                command.Parameters.Add(new OleDbParameter("@varSponsor", Sponsor.ToString()));
                command.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
        }
        /// <summary>
        /// Edit a league's details
        /// </summary>
        /// <param name="LeagueName">The name of the league</param>
        /// <param name="Capacity">The league's Capacity</param>
        /// <param name="Sponsor">The League's sponsor</param>
        /// <param name="EditingLeague">The ID of the league being edited</param>
        public static void Update(string LeagueName, int Capacity, string Sponsor, int EditingLeague)
        {
            OleDbCommand command;
            command = new OleDbCommand("UPDATE League SET  LeagueName = @varLeagueName, Capacity = @varCapacity, Sponsor = @varSponsor WHERE LeagueID = @varLeagueID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varLeagueName", LeagueName));
            command.Parameters.Add(new OleDbParameter("@varCapacity", Capacity));
            command.Parameters.Add(new OleDbParameter("@varSponsor", Sponsor.ToString()));
            command.Parameters.Add(new OleDbParameter("varLeagueID", EditingLeague.ToString()));
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Delete a league
        /// </summary>
        /// <param name="LeagueID">the ID of the league being deleted</param>
        public static void Delete(int LeagueID)
        {
            OleDbCommand command;
            command = new OleDbCommand("DELETE FROM League WHERE LeagueID = @varLeagueID  ", DatabaseConnection.DBConnection);
            command.Parameters.Add(new OleDbParameter("@varLeagueID", LeagueID));
            command.ExecuteNonQuery();
        }
    }
}
