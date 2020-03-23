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
                this.Hide();
                Extended_inf Extended_inf = new Extended_inf();
                Extended_inf.Show();
            }
        }

        private void requests_LoadData()
        {
            DB db = new DB();
            db.openConnection();

            String query = "SELECT [LeasingAppID.LeasingAppName], [Owners.Name],[Owners.Surname],[Requests.Accept] FROM (LeasingAppID INNER JOIN Requests ON LeasingAppID.id=Requests.object_id) INNER JOIN Owners ON Requests.Role_Login=Owners.Login WHERE Requests.object_id IN (SELECT id from LeasingAppID where Renter_id=(Select id from Renters WHERE Login=@login))";
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@login", OleDbType.VarChar).Value = Client1.login;
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
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
