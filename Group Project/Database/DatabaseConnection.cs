using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    static class DatabaseConnection
    {
        private static string dbProvider = @"Provider = Microsoft.ACE.OLEDB.12.0;";
        private static string dbSource = @"Data Source = footballfixtures.accdb";
        public static OleDbConnection DBConnection = new OleDbConnection(dbProvider + dbSource);
 

        public static void dbConnect()
        {
            if (DBConnection.State == System.Data.ConnectionState.Closed)
            { DBConnection.Open(); }
        }

        public static void dbDisconnect()
        {
            if (DBConnection.State == System.Data.ConnectionState.Closed) { DBConnection.Close(); }
        }

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
