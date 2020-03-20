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
    public partial class Extended_inf : Form
    {
        public Extended_inf()
        {
            InitializeComponent();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Extended_inf_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String TableRole;
            if (Client1.role == "Renters")
                TableRole = "Owners";
            else
                TableRole = "Renters";

            String query = "SELECT Name, Surname FROM " +TableRole+" WHERE id=@id";
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@id", OleDbType.Integer).Value = SelectedArea.person_id;

            adapter.SelectCommand = command;//выполняем команду
            adapter.Fill(table);

            DataRow NameSurname = table.Rows[0];
            String NameS = NameSurname["Name"] + " " + NameSurname["Surname"];
            OwnerLabel.Text = NameS;
            AreaNameLabel.Text = SelectedArea.areaName;
            SqMetrLabel.Text = SelectedArea.areaSpace.ToString();
            RoomsAmountLabel.Text = SelectedArea.rooms.ToString();
            PricePerMeterLabel.Text = SelectedArea.price.ToString();
            AllPriceLabel.Text = (SelectedArea.price * SelectedArea.areaSpace).ToString();
            DescribeLabel.Text = SelectedArea.describe;

            if(Client1.role == "Owners")
            {
                labelRole.Text = "Заказчик";
                labelAreaName.Text = "Название заказа";
                labelDesires.Text = "Пожелания заказчика:";
            }
        }
    }
}
