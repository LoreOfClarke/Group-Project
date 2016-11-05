using System.Data.OleDb;
using System.Windows.Forms;

namespace Group_Project.Database
{
    class DatabaseConnection
    {
        private string dbProvider = @"Provider = Microsoft.ACE.OLEDB.12.0;";
        private string dbSource = @"Data Source = footballfixtures.accdb";
        public OleDbConnection DBConnection = new OleDbConnection();
 

        public void dbConnect()
        {
            try
            {
                DBConnection.ConnectionString = dbProvider + dbSource;
                DBConnection.Open();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message, "OLEDB Exception");
            }
        }

        public void dbDisconnect()
        {
            DBConnection.Close();
        }

        public void dbTest()
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
