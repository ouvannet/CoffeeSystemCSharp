using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=coffee_shop_system;port=3306;password=";
            MySqlConnection connection = new MySqlConnection(connectionString);



            string query = "SELECT * from product";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    tblProduct.Rows.Add(row.ItemArray);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=coffee_shop_system;port=3306;password=";
            MySqlConnection connection = new MySqlConnection(connectionString);


            connection.Open();
         
            string query = "INSERT INTO product(type,name,code,brand_id,category_id,unit_id,default_sale_unit_id,default_purchase_unit_id,cost,price,supplier_id) " +
                "VALUES(@type,@name,@code,@brand_id,@category_id,@unit_id,@default_sale_unit_id,@default_purchase_unit_id,@cost,@price,@supplier_id)";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@type", cboProductType.Text);
            cmd.Parameters.AddWithValue("@name", txtProductName.Text);
            cmd.Parameters.AddWithValue("@code", cboBrand.Text);
            cmd.Parameters.AddWithValue("@brand_id", cboBrand.Text);

            cmd.Parameters.AddWithValue("@category_id", cboCategory.Text);
            cmd.Parameters.AddWithValue("@unit_id", cboProductUnit.Text);
            cmd.Parameters.AddWithValue("@default_sale_unit_id", cboDefaultSaleUnit.Text);
            cmd.Parameters.AddWithValue("@default_purchase_unit_id", cboDefaultPurchaseUnit.Text);
            cmd.Parameters.AddWithValue("@cost", txtProductCost.Text);
            cmd.Parameters.AddWithValue("@price", txtProductPrice.Text);
            cmd.Parameters.AddWithValue("@supplier_id",cboSupplier.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("dddd");

            


            connection.Close();





        }
    }
}
