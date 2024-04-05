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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in tblCustomer.Columns)
            {
               /* column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
            }
        }
    }
}
