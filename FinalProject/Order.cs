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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
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
        }
    }
}
