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
   
    //TODO Форма для просмотра статуса заявок пользователя(Owner-а).Различные проверки для  двух видов пользователей были ли уже добавлены заявки или оплачены договоры

    public partial class Extended_inf : Form
    {

        //Массив для всех площадей владельца(заполняется только в случе если пользователь Owner)
        List<string[]> data = new List<string[]>();

        public Extended_inf()
        {
            InitializeComponent();
            if (Client1.role == "Owners")
            {
                ownerAreas();
                fillComboBox();
            }
            else
            {
                AreasComboBox.Visible = false;
            }

            

        }

        private void ownerAreas()
        {
            DB db = new DB();
            db.openConnection();

            String query = "SELECT [id],[AreaName],[SpaceOfArea_squareMeter],[Rooms],[PricePerMonth] FROM Areas  WHERE Owner_id=@o_id";
            OleDbCommand command = new OleDbCommand(query, db.getConnection());
            command.Parameters.Add("@o_id", OleDbType.Integer).Value = Client1.id;
            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();

            }

            reader.Close();
            db.closeConnection();


        }


        //Заполняем combpbox, для удобного выбора своей площади
        private void fillComboBox()
        {
            foreach(string[] area in data)
            {
                String res = " ";
                res = area[1] + ", " + area[2] + " кв.м.," + area[3] + " комнат(ы), " + area[4] + " руб/мес";
                AreasComboBox.Items.Add(res);
            }

        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            if (SelectedArea.areaType == "request" || (SelectedArea.areaType== "UsersRequest" && SelectedArea.accept==true))
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
                //Проверить оплачивал ли пользователь уже данную заявку, если да, то не оплачивать еще раз
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
                if (Client1.role == "Owners")
                {
                    MessageBox.Show(string.Join(" ", data[AreasComboBox.SelectedIndex]));
                    String ClientRole = Client1.role;
                    int objectId = SelectedArea.area_id; // Если пользователь Owner, то objectId - ID запроса пользователя. Если пользователь renter, то object_id - id помещения 
                    int Role_Login = Client1.id;



                    //Проверяем подавал ли пользователь уже эту заявку
                    OleDbCommand command1 = new OleDbCommand("SELECT * FROM Requests WHERE Renter_id = @r_id AND Owner_id= @o_id AND Area_id=@a_id AND Requests_initiatair=@r_i", db.getConnection());

                    command1.Parameters.Add("@r_id", OleDbType.Integer).Value = SelectedArea.person_id;
                    command1.Parameters.Add("@o_id", OleDbType.Integer).Value = Client1.id;
                    command1.Parameters.Add("@a_id", OleDbType.Integer).Value = data[AreasComboBox.SelectedIndex][0];
                    command1.Parameters.Add("@r_i", OleDbType.VarChar).Value = Client1.role;

                    DataTable table = new DataTable();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command1;//выполняем команду
                    adapter.Fill(table);//все полученные данные трансформируем внутрь объекта table

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Вы уже подавали заявку c данной площадью данному пользователю.");
                    }
                    else
                    {

                        OleDbCommand command2 = new OleDbCommand("INSERT INTO Requests ([Accept],[Area_id],[Renter_id],[Owner_id],[Requests_initiatair] ) VALUES (@accept, @a_id, @r_id, @o_id,@r_i)", db.getConnection());
                        command2.Parameters.Add("@accept", OleDbType.Boolean).Value = false;
                        command2.Parameters.Add("@a_id", OleDbType.Integer).Value = data[AreasComboBox.SelectedIndex][0];
                        command2.Parameters.Add("@r_id", OleDbType.Integer).Value = SelectedArea.person_id;
                        command2.Parameters.Add("@o_id", OleDbType.VarChar).Value = Client1.id;
                        command2.Parameters.Add("@r_i", OleDbType.VarChar).Value = Client1.role;

                        db.openConnection();

                        if (command2.ExecuteNonQuery() == 1)
                            MessageBox.Show("Ваша заявка отправлена. Дождитесь ответа от данного пользователя.");
                        else
                            MessageBox.Show("Произошла ошибка.");

                        db.closeConnection();
                    }
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
                        command2.Parameters.Add("@a_id", OleDbType.Integer).Value = SelectedArea.area_id;
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
}
