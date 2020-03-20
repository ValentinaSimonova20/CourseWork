using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\valenti\\Documents\\Database.accdb";


        private OleDbConnection myConnection;
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 56);

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();


        }

        

        

        private void closeButton_Click(object sender, EventArgs e)
        {
            myConnection.Close();

            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();
            String role;
            if (RenterRadioButton.Checked)
                role = "Renters";
            else if (OwnerRadioButton.Checked)
                role = "Owners";
            else
            {
                MessageBox.Show("Укажите какой стороной арендного договора вы являетесь");
                return;
            }


            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand("SELECT * FROM "+role+" WHERE Login = @uL AND Pass= @uP",db.getConnection());

            command.Parameters.Add("@uL", OleDbType.VarChar).Value = loginUser; //В заглушку uL помещаем нужную переменную. Заглушки для безопасности 
            command.Parameters.Add("@uP", OleDbType.VarChar).Value = passUser; //В заглушку uP помещаем нужную переменную

            adapter.SelectCommand = command;//выполняем команду
            adapter.Fill(table);//все полученные данные трансформируем внутрь объекта table

            if(table.Rows.Count > 0) // если рядов больше, чем ноль, то данный пользователь есть в таблице
            {
                this.Hide();
                Client1.login = loginUser;
                Client1.role = role;
                if (role == "Renters")
                {
                    
                    MainFormRenters mainForm = new MainFormRenters();                 
                    mainForm.Show();
                }
                else
                {
                    MainFormOwners mainForm = new MainFormOwners();
                    
                    mainForm.Show();
                }

            }
            else
            {
                MessageBox.Show("No");
            }

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

       
    }
}
