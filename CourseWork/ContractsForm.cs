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
    public partial class ContractsForm : Form
    {
        public ContractsForm()
        {
            InitializeComponent();
            showContract();
            ContractDataGridView.ForeColor = Color.Black;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFormRenters mainRent = new MainFormRenters();
            mainRent.Show();
        }

        private void showContract()
        {
            DB db = new DB();
            db.openConnection();
            String query;
            query = "SELECT [Owners.Name],[Owners.Surname],[Areas.AreaName], [Areas.Rooms], " +
                "[Areas.SpaceOfArea_squareMeter],[Contracts.Amount_of_money]  " +
                "FROM ((Areas INNER JOIN Contracts ON Areas.id=Contracts.Area_id) INNER JOIN Owners ON Contracts.Owner_id=Owners.id) " +
                "WHERE Contracts.Renter_id=@r_id";

            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@r_id", OleDbType.Integer).Value = Client1.id;
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();

            }

            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                ContractDataGridView.Rows.Add(s);
            }
        }
    }
}
