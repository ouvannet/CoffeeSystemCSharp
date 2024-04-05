﻿using System;
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
    public partial class mainPage : Form
    {
      /*  public mainPage(UserData user)*/
        public mainPage()
        {
            InitializeComponent();
            Overview ov = new Overview();
            addtopanel(ov);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void addtopanel(Form pch)
        {
            panelBody.Controls.Clear();

            pch.TopLevel = false;
            pch.Dock = DockStyle.Fill;
            panelBody.Controls.Add(pch);
            pch.Show();
        }
        private void btn_purchas_Click(object sender, EventArgs e)
        {
            Purchase pch = new Purchase();
            addtopanel(pch);
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            addtopanel(od);
        }

        private void btn_payments_Click(object sender, EventArgs e)
        {
            Payment pm = new Payment();
            addtopanel(pm);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            User us = new User();
            addtopanel(us);
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Products pd = new Products();
            addtopanel(pd);
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            Overview ov = new Overview();
            addtopanel(ov);
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            addtopanel(cs);
        }
    }
}
