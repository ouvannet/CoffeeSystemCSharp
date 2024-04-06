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
    public partial class Order : Form
    {
        private MySqlConnection connection;
        string connectionString = "server=localhost;user=root;database=coffee_shop_system;port=3306;password=";
        public Order()
        {
            InitializeComponent();
            ConnectToDatabase();
            LoadTable_Order();
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

        private void tblOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Order_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in tblOrder.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
            productFlow.AutoScroll = true;
            billFlow.AutoScroll = true;

            string query = "SELECT * FROM product";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Assuming your_table_name has two columns named 'id' and 'name'
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    decimal price = reader.GetDecimal("price");
                    ProductCard userControl = new ProductCard();
                    userControl.Pname(name);
                    userControl.PPrice(price);

                    productFlow.Controls.Add(userControl);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                
                
                Billcard bill = new Billcard();

                billFlow.Controls.Add(bill);
                
            }


        }

        private void LoadTable_Order()
        {
            string query = "SELECT id,date,reference_no,customer_id,user_id,discount,total,sale_status FROM sale";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    tblOrder.Rows.Add(row.ItemArray);

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}
