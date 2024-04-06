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
        private MySqlConnection connection;
        string connectionString = "server=localhost;user=root;database=coffee_shop_system;port=3306;password=";

        public Products()
        {
            InitializeComponent();
            ConnectToDatabase();
            PopulateComboBox("id,name", "category","name","id",cboCategory);
            PopulateComboBox("id,name", "brand", "name","id",cboBrand);
            PopulateComboBox("id,name", "unit", "name","id",cboDefaultPurchaseUnit);
            PopulateComboBox("id,name", "unit", "name","id",cboDefaultSaleUnit);
            PopulateComboBox("id,name", "unit", "name","id",cboProductUnit);
            PopulateComboBox("id,name", "supplier", "name","id",cboSupplier);

            cboSearchPro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSearchPro.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboSearchPro.AutoCompleteCustomSource = new AutoCompleteStringCollection();
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

        private void Products_Load(object sender, EventArgs e)
        {
            loadProduct();

        }

        public void loadProduct()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);


            string query = "SELECT id,type,name,code,category_id,unit_id,cost,price,img,supplier_id from product";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                tblProduct.Rows.Clear();
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
            MySqlConnection connection = new MySqlConnection(connectionString);


            connection.Open();
         
            string query = "INSERT INTO product(type,name,code,brand_id,category_id,unit_id,default_sale_unit_id,default_purchase_unit_id,cost,price,supplier_id) " +
                "VALUES(@type,@name,@code,@brand_id,@category_id,@unit_id,@default_sale_unit_id,@default_purchase_unit_id,@cost,@price,@supplier_id)";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@type", cboProductType.Text);
            cmd.Parameters.AddWithValue("@name", txtProductName.Text);
            cmd.Parameters.AddWithValue("@code", txtProductCode.Text);
            cmd.Parameters.AddWithValue("@brand_id", cboBrand.Text);

            cmd.Parameters.AddWithValue("@category_id", cboCategory.Text);
            cmd.Parameters.AddWithValue("@unit_id", cboProductUnit.Text);
            cmd.Parameters.AddWithValue("@default_sale_unit_id", cboDefaultSaleUnit.Text);
            cmd.Parameters.AddWithValue("@default_purchase_unit_id", cboDefaultPurchaseUnit.Text);
            cmd.Parameters.AddWithValue("@cost", txtProductCost.Text);
            cmd.Parameters.AddWithValue("@price", txtProductPrice.Text);
            cmd.Parameters.AddWithValue("@supplier_id",cboSupplier.Text);
            cmd.ExecuteNonQuery();
            long ins_id = cmd.LastInsertedId;
            if (cboProductType.Text == "combo")
            {
                foreach (DataGridViewRow row in dgvListCbItem.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string query2 = "INSERT INTO combo_item (cb_id, product_id, qty) VALUES (@cb_id, @p_id, @qty)";
                        MySqlCommand command = new MySqlCommand(query2, connection);
                        command.Parameters.AddWithValue("@cb_id", ins_id.ToString());
                        command.Parameters.AddWithValue("@p_id", row.Cells["PID"].Value.ToString());
                        command.Parameters.AddWithValue("@qty", row.Cells["Qty"].Value.ToString());

                        // Add parameters for other columns if needed

                        command.ExecuteNonQuery();
                    }
                }

            }

            MessageBox.Show("Insert Successfuly");
            loadProduct();
            txtProductName.Text = "";
            txtProductCode.Text = "";
            txtProductCost.Text = "";
            txtProductPrice.Text = "";

            connection.Close();





        }

        private void cboProductType_TextChanged(object sender, EventArgs e)
        {
            string ptype = cboProductType.Text;
            if (ptype == "combo")
            {
                pn_standard.Visible = false;
                pn_combo.Visible = true;
            }
            else if (ptype == "standard")
            {
                pn_standard.Visible = true;
                pn_combo.Visible = false;

            }
        }

        private void PopulateComboBox(string select,string table,string show,string val,ComboBox cb)
        {
            string query = "SELECT "+select+" FROM "+table;
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                cb.DataSource = dataTable;
                cb.DisplayMember = show;
                cb.ValueMember = val;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboSearchPro_TextChanged(object sender, EventArgs e)
        {
            string searchText = cboSearchPro.Text.Trim();
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
                dgvListCbItem.Rows.Add(selectedListBoxItem.Value, selectedListBoxItem.DisplayName,1);
            }
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
}
