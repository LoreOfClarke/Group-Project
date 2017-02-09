using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    static class PasswordList
    {
        public static List<Classes.Password> Fill()
        {
            List<Classes.Password> Passwords = new List<Classes.Password>();
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT Username, Pass, AccessRights FROM Login;", DatabaseConnection.DBConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Classes.Password User = new Classes.Password();
                    User.Username = reader[0].ToString();
                    User.PassCode = reader[1].ToString();
                    User.AccessRights = reader[2].ToString();
                    Passwords.Add(User);
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return Passwords;
        }

        public static void Add(string Username, string Password, string AccessRights)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO Login (Username, Pass, AccessRights) VALUES (@varUsername, @varPassword, @varAccessRights) ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varUsername", Username.ToString()));
                command.Parameters.Add(new OleDbParameter("@varPassword", Password.ToString()));
                command.Parameters.Add(new OleDbParameter("@varAccessRights", AccessRights.ToString()));
                command.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
        }
        public static void Update(string Username, string Password, string AccessRights)
        {
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("UPDATE Login SET  Pass = @varPassword, AccessRights = @varAccessRights WHERE Username = @varUsername", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varPassword", Password.ToString()));
                command.Parameters.Add(new OleDbParameter("@varFixtureDate", AccessRights.ToString()));
                command.Parameters.Add(new OleDbParameter("@varUsername", Username.ToString()));
                command.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
        }

        public static void Delete(string Username)
        {
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("DELETE FROM Login WHERE Username = @varUsername  ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varUsername", Username.ToString()));
                command.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
        }
    }
}
