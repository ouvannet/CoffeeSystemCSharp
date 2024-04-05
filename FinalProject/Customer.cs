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
    public partial class Customer : Form
    {
        private MySqlConnection connection;
        string connectionString = "server=localhost;user=root;database=coffee_shop_system;port=3306;password=";
        public Customer()
        {
            InitializeComponent();
            InitializeDataGridView();
            ConnectToDatabase();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            tblCustomer.AutoGenerateColumns = true;
/*            tblCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/
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

        private void Customer_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in tblCustomer.Columns)
            {
               /* column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "INSERT INTO  customer(name,phone,description) VALUES(@name,@phone,@des)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@des", txtDes.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully!");
                    tblCustomer.Rows.Clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Data insertion failed.");
                }

                connection.Close();
                Console.WriteLine("Connection closed.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        private void LoadData()
        {
            string query = "SELECT id,name,phone,date_create,description FROM customer";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    tblCustomer.Rows.Add(row.ItemArray);

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        private void tblCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
