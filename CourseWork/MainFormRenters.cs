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
            LoadData();
            RequestsGridView.ForeColor = Color.Black;
            areasDataGridView.ForeColor = Color.Black;

        }

       

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //Определяем какие пользователи подали заявку клиенту
        //показываем их при выборе флага checkbox
        private void requests()
        {
            DB db = new DB();
            db.openConnection();

            String query = "SELECT [Area_id] FROM Requests  WHERE Renter_id=@r_id AND Requests_initiatair<>@role";
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@r_id", OleDbType.Integer).Value = Client1.id;
            command.Parameters.Add("@role", OleDbType.VarChar).Value = Client1.role;
            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                data.Add(reader[0].ToString());

            }

            reader.Close();
            db.closeConnection();

        
    }

        //Загружаем во вторую dgv информацию о заявках, которые подал сам клиент
        private void LoadData()
        {

            DB db = new DB();
            db.openConnection();

            String query = "SELECT [Areas.id],[Areas.Owner_id],[Areas.AreaName],[Areas.Rooms], [Areas.SpaceOfArea_squareMeter],[Areas.PricePerMonth],[Requests.Accept],[Areas.Describe] FROM (Areas INNER JOIN Requests ON Areas.id=Requests.Area_id) WHERE Requests.Renter_id=@r_id AND Requests_initiatair=@role";
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@r_id", OleDbType.Integer).Value = Client1.id;
            command.Parameters.Add("@role", OleDbType.VarChar).Value = Client1.role;
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }

            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                RequestsGridView.Rows.Add(s);
            }


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
                if(data.Contains(SelectedArea.area_id.ToString()))
                    SelectedArea.areaType = "request";
                else
                    SelectedArea.areaType = "normal";
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

            if (!checkBox1.Checked)
            {
                // Show all lines
                for (int u = 0; u < areasDataGridView.RowCount; u++)
                {
                    areasDataGridView.Rows[u].Visible = true;

                }
            }
            else
            {

                // Hide the ones that you want with the filter you want.
                for (int u = 0; u < areasDataGridView.RowCount - 1; u++)
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
            }

            // Resume data grid view binding
            currencyManager.ResumeBinding();
        }

        private void RequestsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RequestsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                RequestsGridView.CurrentRow.Selected = true;

                //MessageBox.Show(areasDataGridView.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                SelectedArea.area_id = int.Parse(RequestsGridView.Rows[e.RowIndex].Cells["id_a"].Value.ToString());
                SelectedArea.person_id = int.Parse(RequestsGridView.Rows[e.RowIndex].Cells["id_own"].Value.ToString());
                SelectedArea.areaName = RequestsGridView.Rows[e.RowIndex].Cells["Area_Name"].Value.ToString();
                SelectedArea.areaSpace = int.Parse(RequestsGridView.Rows[e.RowIndex].Cells["square"].Value.ToString());
                SelectedArea.price = int.Parse(RequestsGridView.Rows[e.RowIndex].Cells["price_perMonth"].Value.ToString());
                SelectedArea.rooms = int.Parse(RequestsGridView.Rows[e.RowIndex].Cells["roomsAmount"].Value.ToString());
                SelectedArea.describe = RequestsGridView.Rows[e.RowIndex].Cells["descr"].Value.ToString();
                SelectedArea.accept = bool.Parse(RequestsGridView.Rows[e.RowIndex].Cells["Accept"].Value.ToString());
                SelectedArea.areaType = "UsersRequest";

                this.Hide();
                Extended_inf Extended_inf = new Extended_inf();
                Extended_inf.Show();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logForm = new LoginForm();
            logForm.Show();
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddObject addobj = new AddObject();
            addobj.Show();
        }

        private void Contract_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContractsForm contrsForm = new ContractsForm();
            contrsForm.Show();
        }

        private void areasDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[areasDataGridView.DataSource];
            currencyManager.SuspendBinding();
            if (checkBox1.Checked)
            {
                for (int u = 0; u < areasDataGridView.RowCount - 1; u++)
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
            }
            currencyManager.ResumeBinding();
        }
    }
}
