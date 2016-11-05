﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group_Project.Database
{
    static class LeagueList
    {
        public static List<Classes.League> Fill(OleDbConnection DBConnection)
        {
            List<Classes.League> LeagueList = new List<Classes.League>();
            Classes.League League = new Classes.League();
            try
            {
                OleDbCommand command = new OleDbCommand("Select * from League;", DBConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
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