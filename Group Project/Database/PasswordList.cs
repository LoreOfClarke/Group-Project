using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    static class PasswordList
    {
        /// <summary>
        /// Fill a list of classes of all of the passwords
        /// </summary>
        /// <returns>a list of classes of all of the passwords</returns>
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
        /// <summary>
        /// Add a new username and password
        /// </summary>
        /// <param name="Username">The username</param>
        /// <param name="Password">The password</param>
        /// <param name="AccessRights">Either "ADMINISTRATOR" for admin access, or the ID of the team that the person has access too.</param>
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
        /// <summary>
        /// Edit a username and password.
        /// </summary>
        /// <param name="Username">The username</param>
        /// <param name="Password">The password</param>
        /// <param name="AccessRights">Either "ADMINISTRATOR" for admin access, or the ID of the team that the person has access too.</param>
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
        /// <summary>
        /// Delete a usename and password
        /// </summary>
        /// <param name="Username">the username to delete</param>
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
        /// <summary>
        /// Get the password to a username
        /// </summary>
        /// <param name="Username">The username, to which a password is being pulled out</param>
        /// <returns>The correct password for the username</returns>
        public static string GetPassword(string Username)
        {
            string Password = "";
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT Pass FROM Login WHERE Username = @varUsername  ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varUsername", Username.ToString()));
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Password = reader[0].ToString();
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return Password;
        }
        /// <summary>
        /// Gets the password for the given username
        /// </summary>
        /// <param name="Username">the username</param>
        /// <returns>Either "ADMINISTRATOR" for admin access, or the ID of the team that the person has access to</returns>
        public static string GetAccessLevel(string Username)
        {
            string AccessLevel = "";
            try
            {
                OleDbCommand command;
                command = new OleDbCommand("SELECT AccessRights FROM Login WHERE Username = @varUsername  ", DatabaseConnection.DBConnection);
                command.Parameters.Add(new OleDbParameter("@varUsername", Username.ToString()));
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AccessLevel = reader[0].ToString();
                }
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            return AccessLevel;
        }
    }
}
