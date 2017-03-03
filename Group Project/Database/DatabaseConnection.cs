using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    static class DatabaseConnection
    {
        /// <summary>
        /// A static string containing the Database connection driver
        /// </summary>
        private static string dbProvider = @"Provider = Microsoft.ACE.OLEDB.12.0;";
        /// <summary>
        /// A static String containing the database location
        /// </summary>
        private static string dbSource = @"Data Source = footballfixtures.accdb";
        /// <summary>
        /// The connection to the database
        /// </summary>
        public static OleDbConnection DBConnection = new OleDbConnection(dbProvider + dbSource);
 
        /// <summary>
        /// Connect to the database
        /// </summary>
        public static void dbConnect()
        {
            if (DBConnection.State == System.Data.ConnectionState.Closed)
            { DBConnection.Open(); }
        }
        /// <summary>
        /// Disconnect from the database
        /// </summary>
        public static void dbDisconnect()
        {
            if (DBConnection.State == System.Data.ConnectionState.Closed) { DBConnection.Close(); }
        }
        /// <summary>
        /// A test string to test whether the database has been connected to at any point in the code. Not used in normal running of code.
        /// </summary>
        public static void dbTest()
        {
            try
            {
                dbConnect();
                OleDbCommand command;
                command = new OleDbCommand("Select * from Teams;", DBConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString() + ": " +reader[1].ToString());
                }
                dbDisconnect();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OleDb Exception");
            }
            
        }
    }
}
