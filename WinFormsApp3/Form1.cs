using Microsoft.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        private string connect = "Server=localhost\\SQLEXPRESS;Database=people;Trusted_Connection=true;TrustServerCertificate=true;";
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToForm(new reg());
        }
        private void SwitchToForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private bool IsLoginCorrect(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Userb WHERE login = @login AND password = @password";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    var result = command.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) > 0;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string login = guna2TextBox1.Text.Trim();
            string password = guna2TextBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text) ||
                string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (login.ToLower() == "admin" && password == "20072007")
            {
                MessageBox.Show("Добро пожаловать, Администратор!", "Админ панель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                SwitchToForm(new Admin());
                return; 
            }

            if (IsLoginCorrect(login, password))
            {
                MessageBox.Show("Успешный вход!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                SwitchToForm(new main());
            }
            else
            {
                MessageBox.Show("Логин или пароль не совпадают", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    }
