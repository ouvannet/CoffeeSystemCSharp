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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        string connectionString = "server=localhost;user=root;database=coffee_shop_system;port=3306;password=";


        public void loadPurchase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);


            string query = "SELECT * from purchase";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                tblPurchase.Rows.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    tblPurchase.Rows.Add(row.ItemArray);
                }

            }
          
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
          
            }



        }




        private void btnCreatePurchase_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);


            connection.Open();

            string query = "INSERT INTO purchase(discount,paid,shipping,supplier_id,pay_status,status,pay_term) " +
                "VALUES(@discount,@paid,@shipping,@supplier_id,@pay_status,@status,@pay_term)";
            MySqlCommand cmd = new MySqlCommand(query, connection);


           
            cmd.Parameters.AddWithValue("@discount", txtDiscount.Text);
            cmd.Parameters.AddWithValue("@paid", txtPaid.Text);
            cmd.Parameters.AddWithValue("@shipping", txtShipping.Text);

            cmd.Parameters.AddWithValue("@supplier_id", cboSupplierID.Text);
            cmd.Parameters.AddWithValue("@pay_status", cboPaymentStatus.Text);
            cmd.Parameters.AddWithValue("@status",cboStatus.Text);
            cmd.Parameters.AddWithValue("@pay_term", txtPaymentTerm.Text);
       
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Insert Successfuly");
            loadPurchase();

            connection.Close();







        }
    }
}
