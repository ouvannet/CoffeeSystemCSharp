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
    public partial class User : Form
    {
        private MySqlConnection connection;
        string connectionString = "server=localhost;user=root;database=coffee_shop_system;port=3306;password=";
        public User()
        {
            InitializeComponent();
            InitializeDataGridView();
            ConnectToDatabase();
            LoadData();
            List<string> items = new List<string> { "1","2" };
            cbRole.Items.AddRange(items.ToArray());
            cbRole.SelectedIndex = 0;
        }
        private void InitializeDataGridView()
        {
            tblUser.AutoGenerateColumns = true;
        }
        private void ConnectToDatabase()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connected to MySQL database.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
        private void User_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in tblUser.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO  user(name,password,email,phone,role_id,description) VALUES(@name,@password,@email,@phone,@role_idm,@description)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@role_idm", cbRole.Text);
            cmd.Parameters.AddWithValue("@description", txtDes.Text);
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data inserted successfully!");
                tblUser.Rows.Clear();
                LoadData();
            }
            else
            {
                MessageBox.Show("Data insertion failed.");
            }

        }

        private void LoadData()
        {
            string query = "SELECT id,name,email,phone,role_id,description FROM user";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    tblUser.Rows.Add(row.ItemArray);

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}
