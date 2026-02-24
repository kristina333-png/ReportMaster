
using System;
using Microsoft.Data.SqlClient;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp3
{
    public partial class reg : Form
    {
        private string connect = "Server=localhost\\SQLEXPRESS;Database=people;Trusted_Connection=true;TrustServerCertificate=true;";
        public reg()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToForm(new Form1());

        }

        private void SwitchToForm(Form form)
        {

            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
 
        private bool IsLoginExists(string login)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open(); 
                string sql = "SELECT COUNT(*) FROM Userb WHERE login = @login";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    var result = command.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) > 0;
                }
            }
        }

    
        private bool IsEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();  
                string sql = "SELECT COUNT(*) FROM Userb WHERE email = @email";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    var result = command.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) > 0;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string login = guna2TextBox1.Text.Trim();
            string email = guna2TextBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text) ||
               string.IsNullOrWhiteSpace(guna2TextBox2.Text) ||
               string.IsNullOrWhiteSpace(guna2TextBox3.Text) ||
               string.IsNullOrWhiteSpace(guna2TextBox4.Text)||
               string.IsNullOrWhiteSpace(guna2TextBox5.Text))

            {
                MessageBox.Show("Заполните все поля!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guna2TextBox5.Text != guna2TextBox4.Text)
            {
                MessageBox.Show("Пароли не совпадают!!", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guna2TextBox5.Text.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать не менее 6 символов!", "Ошибка",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsLoginExists(login))
            {
                MessageBox.Show("Этот логин уже занят!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            if (IsEmailExists(email))
            {
                MessageBox.Show("Этот email уже зарегистрирован!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();

                    string sql = "INSERT INTO Userb (login, password, email, phone_number) VALUES (@log, @pass, @email, @phone)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@log", guna2TextBox1.Text);
                        command.Parameters.AddWithValue("@pass", guna2TextBox4.Text);
                        command.Parameters.AddWithValue("@email", guna2TextBox3.Text);
                        command.Parameters.AddWithValue("@phone", guna2TextBox2.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Успешная регистрация!");
                this.Hide();
                new Form1().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

    }
    }

