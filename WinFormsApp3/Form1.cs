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
            form.FormClosed += (s, args) => this.Show(); 
            form.Show();
        }

        private int GetUserId(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string sql = "SELECT ID FROM Userb WHERE login = @login AND password = @password";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    return -1;
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
                SwitchToForm(new admin2());
                return;
            }
            int userId = GetUserId(login, password);
            if (userId > 0)
            {
                MessageBox.Show("Успешный вход!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                SwitchToForm(new main2(userId));
            }
            else
            {
                MessageBox.Show("Логин или пароль не совпадают", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
           
            int testUserId = 1;
            information infoForm = new information(testUserId);
            infoForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
