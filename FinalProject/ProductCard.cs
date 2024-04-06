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
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void Pname(string name)
        {
            lbl_name.Text = name;
        }
        public void PPrice(decimal price)
        {
            lbl_price.Text = price.ToString();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
