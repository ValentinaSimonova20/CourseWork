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
            RequestsStatusDgv.ForeColor = Color.Black;
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
            query = "SELECT [Requests.Area_id],[Requests.Request_id],[Renters.Name], [Renters.Surname],[Areas.AreaName],[Areas.Rooms], " +
                "[Areas.SpaceOfArea_squareMeter],[Areas.PricePerMonth],[Requests.Accept]   " +
                "FROM ((Areas INNER JOIN Requests ON Areas.id=Requests.Area_id) INNER JOIN Renters ON Requests.Renter_id=Renters.id) " +
                "WHERE Requests_initiatair=@role AND Requests.Owner_id=@o_id";
            
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@role", OleDbType.VarChar).Value = Client1.role;
            command.Parameters.Add("@role", OleDbType.VarChar).Value = Client1.id;
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
            }

            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                RequestsStatusDgv.Rows.Add(s);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFormOwners ownForm = new MainFormOwners();
            ownForm.Show();
            
        }
    }
}
