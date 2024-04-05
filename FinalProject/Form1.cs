using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            
            string connectionString = "server=localhost;user=root;database=coffee_shop_system;port=3306;password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM user where name=@name and password=@password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", txt_user_name.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Create a new User object and populate it with data from the database
                        UserData loggedInUser = new UserData();
                        if (!reader.IsDBNull(reader.GetOrdinal("id")))
                        {
                            loggedInUser.Id = reader.GetInt32("id");
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("name")))
                        {
                            loggedInUser.Name = reader.GetString("name");
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("email")))
                        {
                            loggedInUser.Email = reader.GetString("email");
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("phone")))
                        {
                            loggedInUser.Phone = reader.GetString("phone");
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("role_id")))
                        {
                            loggedInUser.Role = reader.GetInt32("role_id");
                        }

                        this.Hide();
           /*             new mainPage(loggedInUser).Show();*/
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Invalid username or password.");
                    }
                }

                connection.Close();
                Console.WriteLine("Connection closed.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }

        }
    }
}
