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

            long ins_id = cmd.LastInsertedId;
            foreach (DataGridViewRow row in tblPurchaseItem.Rows)
            {
                if (!row.IsNewRow)
                {
                    string query2 = "INSERT INTO purchase_item (purchase_id, product_id, qty,cost) VALUES (@purchase_id, @product_id, @qty,@cost)";
                    MySqlCommand command = new MySqlCommand(query2, connection);
                    command.Parameters.AddWithValue("@purchase_id", ins_id.ToString());
                    command.Parameters.AddWithValue("@product_id", row.Cells["product_id"].Value.ToString());
                    command.Parameters.AddWithValue("@qty", row.Cells["quantity"].Value.ToString());
                    command.Parameters.AddWithValue("@cost", row.Cells["cost"].Value.ToString());



                    command.ExecuteNonQuery();
                }
            }

            
            MessageBox.Show("Insert Successfuly");
            loadPurchase();

            connection.Close();


        }
        private void SearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchProduct.Text.Trim();
            PopulateComboBox(searchText);

        }
        private void PopulateComboBox(string searchText)
        {
            string query = "SELECT id,name FROM product WHERE name LIKE @searchText";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);
                lsb_searchProduct.Items.Clear();

                // Add items to ListBox
                foreach (DataRow row in dataTable.Rows)
                {
                    string displayName = row["name"].ToString();
                    string value = row["id"].ToString();

                    ListBoxItem item = new ListBoxItem(displayName, value);

                    lsb_searchProduct.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void lsb_searchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxItem selectedListBoxItem = (ListBoxItem)lsb_searchProduct.SelectedItem;

            if (selectedListBoxItem != null)
            {
                tblPurchaseItem.Rows.Add(selectedListBoxItem.Value, selectedListBoxItem.DisplayName, 1);
            }
        }

        public class ListBoxItem
        {
            public string DisplayName { get; set; }
            public string Value { get; set; }

            public ListBoxItem(string displayName, string value)
            {
                DisplayName = displayName;
                Value = value;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }



        private void lsb_serachProduct(object sender, EventArgs e)
        {

        }

        private void SearchProduct_TabIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
