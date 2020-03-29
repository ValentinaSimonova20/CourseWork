using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ClientRequests : Form
    {
        public ClientRequests()
        {
            InitializeComponent();
            requests_LoadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void requests_LoadData()
        {
            DB db = new DB();
            db.openConnection();
            String query;
            if (Client1.role == "Renters")
            {
                query = "SELECT [Requests.Request_id],[Areas.AreaName], [Requests.Accept] FROM (Areas INNER JOIN Requests ON Areas.id=Requests.object_id) WHERE Requests.Role_Login=@r_L";
            }
            else
            {
                query = "SELECT [Requests.Request_id],[LeasingAppID.LeasingAppName], [Requests.Accept] FROM (LeasingAppID INNER JOIN Requests ON LeasingAppID.id=Requests.object_id) WHERE Requests.Role_Login=@r_L";
            }
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@login", OleDbType.VarChar).Value = Client1.id;
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }
    }
}
