using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
