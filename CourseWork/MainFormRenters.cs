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
        List<string> data = new List<string>();
        public MainFormRenters()
        {
            InitializeComponent();
            requests();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void requests()
        {
            DB db = new DB();
            db.openConnection();

            String query = "SELECT [Requests.Area_id] FROM Requests  WHERE Renter_id=@r_id";
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@r_id", OleDbType.Integer).Value = Client1.id;
            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                data.Add(reader[0].ToString());

            }

            reader.Close();
            db.closeConnection();

        
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

        private void checkBox1_Click(object sender, EventArgs e)
        {
            // Prevent exception when hiding rows out of view
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[areasDataGridView.DataSource];
            currencyManager.SuspendBinding();

            // Show all lines
            for (int u = 0; u < areasDataGridView.RowCount; u++)
            {
                areasDataGridView.Rows[u].Visible = true;

            }

            // Hide the ones that you want with the filter you want.
            for (int u = 0; u < areasDataGridView.RowCount-1; u++)
            {
                if (data.Contains(areasDataGridView.Rows[u].Cells[0].Value.ToString()))
                {
                    areasDataGridView.Rows[u].Visible = true;
                }
                else
                {
                    areasDataGridView.Rows[u].Visible = false;
                }
            }

            // Resume data grid view binding
            currencyManager.ResumeBinding();
        }
    }
}
