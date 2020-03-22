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
    public partial class MainFormOwners : Form
    {
        

        public MainFormOwners()
        {
            InitializeComponent();
            label3.Text ="Здравствуйте, "+Client1.login;
            requests_LoadData();


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void leasingAppIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.leasingAppIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void MainFormOwners_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.LeasingAppID". При необходимости она может быть перемещена или удалена.
            this.leasingAppIDTableAdapter.Fill(this.databaseDataSet.LeasingAppID);
            

        }

        private void leasingAppIDDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            leasingAppIDDataGridView.CurrentRow.Selected = true;
            //MessageBox.Show(areasDataGridView.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
            SelectedArea.area_id = (int)leasingAppIDDataGridView.Rows[e.RowIndex].Cells["id"].Value;
            SelectedArea.person_id = (int)leasingAppIDDataGridView.Rows[e.RowIndex].Cells["Renter_id"].Value;
            SelectedArea.areaName = leasingAppIDDataGridView.Rows[e.RowIndex].Cells["LeasingAppName"].Value.ToString();
            SelectedArea.areaSpace = (int)leasingAppIDDataGridView.Rows[e.RowIndex].Cells["SpaceSquare"].Value;
            SelectedArea.price = (int)leasingAppIDDataGridView.Rows[e.RowIndex].Cells["PricePerMonth"].Value;
            SelectedArea.rooms = (int)leasingAppIDDataGridView.Rows[e.RowIndex].Cells["Rooms"].Value;
            SelectedArea.describe = leasingAppIDDataGridView.Rows[e.RowIndex].Cells["Describe"].Value.ToString();
            this.Hide();
            Extended_inf Extended_inf = new Extended_inf();
            Extended_inf.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void requests_LoadData() {
            DB db = new DB();
            db.openConnection();

            String query = "SELECT [Areas.AreaName], [Renters.Name],[Renters.Surname] FROM (Areas INNER JOIN Requests ON Areas.id=Requests.object_id) INNER JOIN Renters ON Requests.Role_Login=Renters.Login WHERE Requests.object_id IN (SELECT id from Areas where Owner_id=(Select id from Owners WHERE Login=@login))";
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@login", OleDbType.VarChar).Value = Client1.login;
            OleDbDataReader reader= command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();
            db.closeConnection();

            foreach(string[] s in data) {
                dataGridView1.Rows.Add(s);
            }

        }
    }
}
