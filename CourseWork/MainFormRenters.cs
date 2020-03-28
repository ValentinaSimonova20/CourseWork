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
    public partial class MainFormRenters : Form
    {
        
        public MainFormRenters()
        {
            InitializeComponent();
            label3.Text = "Здравствуйте, " + Client1.login;
            requests_LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void MainFormRenters_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.DataSet.Areas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.DataSet.Areas);

        }

        private void areasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void areasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void areasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(areasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                areasDataGridView.CurrentRow.Selected = true;
                //MessageBox.Show(areasDataGridView.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                SelectedArea.area_id = (int)areasDataGridView.Rows[e.RowIndex].Cells["id"].Value;
                SelectedArea.person_id = (int)areasDataGridView.Rows[e.RowIndex].Cells["Owner_id"].Value;
                SelectedArea.areaName = areasDataGridView.Rows[e.RowIndex].Cells["AreaName"].Value.ToString();
                SelectedArea.areaSpace = (int)areasDataGridView.Rows[e.RowIndex].Cells["SpaceOfArea_squareMeter"].Value;
                SelectedArea.price = (int)areasDataGridView.Rows[e.RowIndex].Cells["PricePerMonth"].Value;
                SelectedArea.rooms = (int)areasDataGridView.Rows[e.RowIndex].Cells["Rooms"].Value;
                SelectedArea.describe = areasDataGridView.Rows[e.RowIndex].Cells["Describe"].Value.ToString();
                SelectedArea.dgvType = "areas";
                this.Hide();
                Extended_inf Extended_inf = new Extended_inf();
                Extended_inf.Show();
            }
        }

        private void requests_LoadData()
        {
            DB db = new DB();
            db.openConnection();

            String query = "SELECT [LeasingAppID.id],[LeasingAppID.LeasingAppName]," +
                "[LeasingAppID.SpaceOfArea_squareMeter],[LeasingAppID.Describe]," +
                "[LeasingAppID.Rooms],[LeasingAppID.PricePerMonth],[Owners.id], " +
                "[Owners.Name],[Owners.Surname],[Requests.Accept],[Requests.Request_id] " +
                "FROM (LeasingAppID INNER JOIN Requests ON LeasingAppID.id=Requests.object_id) INNER JOIN Owners ON Requests.Role_Login=Owners.Login WHERE Requests.object_id IN (SELECT id from LeasingAppID where Renter_id=(Select id from Renters WHERE Login=@login))";
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@login", OleDbType.VarChar).Value = Client1.login;
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
 
            }

            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Accept")
            {
                DB db = new DB();
                OleDbCommand command = new OleDbCommand("Update Requests SET Accept=true WHERE Request_id=@r_id", db.getConnection());
                command.Parameters.Add("@r_id", OleDbType.Integer).Value = dataGridView1.Rows[e.RowIndex].Cells["Rid"].Value;
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы принели заявку. Переходите к оплате.Нажмите дважды по предложению.");
                else
                    MessageBox.Show("Error");

                db.closeConnection();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                if(dataGridView1.Rows[e.RowIndex].Cells["Accept"].Value.ToString()=="False")
                {
                    MessageBox.Show("Вы не приняли данную заявку, поэтому не можете оплатить ее.");
                    return;
                }

                SelectedArea.area_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["LeasingApp_id"].Value.ToString());
                SelectedArea.person_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Owners_id"].Value.ToString());
                SelectedArea.areaName = dataGridView1.Rows[e.RowIndex].Cells["LeasingAppName"].Value.ToString();
                SelectedArea.areaSpace = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["areaSpace"].Value.ToString());

                SelectedArea.price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString());
                SelectedArea.rooms = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["rooms_"].Value.ToString());
                SelectedArea.describe = dataGridView1.Rows[e.RowIndex].Cells["descr"].Value.ToString();
                SelectedArea.dgvType = "requests";
                this.Hide();
                Extended_inf Extended_inf = new Extended_inf();
                Extended_inf.Show();




            }
        }
    }
}
