using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Common;

namespace CourseWork
{
    class DB
    {
        static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\valenti\\Documents\\Database.accdb";

        OleDbConnection connection = new OleDbConnection(connectString);
        
        
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public OleDbConnection getConnection()
        {
            return connection;
        }

    }
}
