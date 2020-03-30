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

                String query = "SELECT Name, Surname FROM " + TableRole + " WHERE id=@id";
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

            if(Client1.role == "Owners" )
            {
                labelRole.Text = "Заказчик";
                labelAreaName.Text = "Название заказа";
                labelDesires.Text = "Пожелания заказчика:";
            }

            if (SelectedArea.areaType == "request")
            {
                buttonSendRequest.Text = "Принять заявку и оплатить";
                label1.Text = "Оплата";
            }
        }

        private void buttonSendRequest_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            if (buttonSendRequest.Text == "Принять заявку и оплатить")
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO Contracts ([Owner_id], [Renter_id], [Area_id], [Amount_of_money]) VALUES (@own_id, @rent_id, @area_id, @money)", db.getConnection());
                command.Parameters.Add("@own_id", OleDbType.Integer).Value = SelectedArea.person_id;
                command.Parameters.Add("@rent_id", OleDbType.Integer).Value = Client1.id;
                command.Parameters.Add("@area_id", OleDbType.Integer).Value = SelectedArea.area_id;
                command.Parameters.Add("@money", OleDbType.Integer).Value = SelectedArea.price;


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Площадь оплачена. Подождите пока с вами свяжется владелец");
                else
                    MessageBox.Show("Error");

                db.closeConnection();
            }

            else
            {



                String ClientRole = Client1.role;
                int objectId = SelectedArea.area_id; // Если пользователь Owner, то objectId - ID запроса пользователя. Если пользователь renter, то object_id - id помещения 
                int Role_Login = Client1.id;

                

                //Проверяем подавал ли пользователь уже эту заявку
                OleDbCommand command1 = new OleDbCommand("SELECT * FROM Requests WHERE Renter_id = @r_id AND Owner_id= @o_id AND Area_id=@a_id AND Requests_initiatair=@r_i", db.getConnection());

                command1.Parameters.Add("@r_id", OleDbType.Integer).Value = Client1.id;
                command1.Parameters.Add("@o_id", OleDbType.Integer).Value = SelectedArea.person_id;
                command1.Parameters.Add("@a_id", OleDbType.Integer).Value = SelectedArea.area_id;
                command1.Parameters.Add("@r_i", OleDbType.VarChar).Value = Client1.role;

                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command1;//выполняем команду
                adapter.Fill(table);//все полученные данные трансформируем внутрь объекта table

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Вы уже подавали заявку на данный объект!");
                }
                else
                {

                    OleDbCommand command2 = new OleDbCommand("INSERT INTO Requests ([Accept],[Area_id],[Renter_id],[Owner_id],[Requests_initiatair] ) VALUES (@accept, @a_id, @r_id, @o_id,@r_i)", db.getConnection());
                    command2.Parameters.Add("@accept", OleDbType.Boolean).Value = false;
                    command2.Parameters.Add("@a_id", OleDbType.Integer).Value =SelectedArea.area_id;
                    command2.Parameters.Add("@r_id", OleDbType.Integer).Value = Client1.id;
                    command2.Parameters.Add("@o_id", OleDbType.VarChar).Value = SelectedArea.person_id;
                    command2.Parameters.Add("@r_i", OleDbType.VarChar).Value = Client1.role;

                    db.openConnection();

                    if (command2.ExecuteNonQuery() == 1)
                        MessageBox.Show("Ваша заявка отправлена. Дождитесь ответа от данного пользователя.");
                    else
                        MessageBox.Show("Произошла ошибка.");

                    db.closeConnection();
                }




            }
        }
    }
}
