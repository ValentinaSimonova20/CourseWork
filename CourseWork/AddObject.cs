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
    public partial class AddObject : Form
    {
        public AddObject()
        {
            InitializeComponent();
            if (Client1.role == "Owners")
            {
                labelAdd.Text += " Площадь";
            }
            else
            {
                labelAdd.Text += " Заявку";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddObj_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String tableName, column_id, column_name; ;
            if (Client1.role == "Owners")
            {
                column_id = "Owner_id";
                tableName = "Areas";
                column_name = "AreaName";
            }
            else
            {
                column_id = "Renter_id";
                tableName = "LeasingAppID";
                column_name = "LeasingAppName";
            }



            OleDbCommand command = new OleDbCommand("INSERT INTO " + tableName + " (["+ column_id + "], ["+ column_name + "], [SpaceOfArea_squareMeter], [Rooms],[PricePerMonth],[Describe]) VALUES (@person_id, @obj_name, @space, @rooms,@price,@descr)", db.getConnection());
            command.Parameters.Add("@person_id", OleDbType.Integer).Value = Client1.id;
            command.Parameters.Add("@obj_name", OleDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@space", OleDbType.Integer).Value = int.Parse(textBoxMetrs.Text);
            command.Parameters.Add("@rooms", OleDbType.Integer).Value = int.Parse(textBoxRooms.Text);
            command.Parameters.Add("@price", OleDbType.VarChar).Value = textBoxPrice.Text;
            command.Parameters.Add("@descr", OleDbType.VarChar).Value = textBoxDescribe.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Объект успешно добавлен");
            else
                MessageBox.Show("Ошибка");

            db.closeConnection();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Client1.role == "Owners")
            {
                MainFormOwners mainOwn = new MainFormOwners();
                mainOwn.Show();
            }
            else
            {
                MainFormRenters mainRent = new MainFormRenters();
                mainRent.Show();
            }
        }
    }
}
