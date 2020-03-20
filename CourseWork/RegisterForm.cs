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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userSurnameField.Text = "Введите фамилию";
            loginField.Text = "Введите логин";

            userNameField.ForeColor = Color.Gray;
            userSurnameField.ForeColor = Color.Gray;
            loginField.ForeColor = Color.Gray;


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastpoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }

        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            String tableName;
            if (RenterRadioButton.Checked)
                tableName = "Renters";
            else if (OwnerRadioButton.Checked)
                tableName = "Owners";
            else
            {
                MessageBox.Show("Укажите какой стороной арендного договора вы являетесь");
                return;
            }

            if (isUserExists(tableName))
                return;




            DB db = new DB();
            OleDbCommand command = new OleDbCommand("INSERT INTO "+tableName+" ([Login], [Pass], [Name], [Surname]) VALUES (@login, @pass, @name, @surname)",db.getConnection());
            command.Parameters.Add("@login", OleDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", OleDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", OleDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", OleDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();


        }

        public Boolean isUserExists(String tableName)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand("SELECT * FROM "+tableName+" WHERE Login = @uL ", db.getConnection());
            command.Parameters.Add("@uL", OleDbType.VarChar).Value = loginField.Text; //В заглушку uL помещаем нужную переменную. Заглушки для безопасности 

            adapter.SelectCommand = command;//выполняем команду
            adapter.Fill(table);//все полученные данные трансформируем внутрь объекта table

            if (table.Rows.Count > 0) // если рядов больше, чем ноль, то данный пользователь есть в таблице
            {
                MessageBox.Show("Такой логин уже есть. Введите другой.");
                return true;

            }
            else
            {
                return false;
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
