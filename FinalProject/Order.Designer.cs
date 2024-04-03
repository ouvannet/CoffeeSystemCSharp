namespace FinalProject
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tblOrder = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCard = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Management";
            // 
            // tblOrder
            // 
            this.tblOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tblOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.customerid,
            this.date,
            this.price,
            this.Fees,
            this.Status});
            this.tblOrder.Location = new System.Drawing.Point(448, 542);
            this.tblOrder.Name = "tblOrder";
            this.tblOrder.RowHeadersWidth = 51;
            this.tblOrder.RowTemplate.Height = 24;
            this.tblOrder.Size = new System.Drawing.Size(1114, 388);
            this.tblOrder.TabIndex = 37;
            this.tblOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblOrder_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "ID";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 49;
            // 
            // customerid
            // 
            this.customerid.HeaderText = "CustomerID";
            this.customerid.MinimumWidth = 6;
            this.customerid.Name = "customerid";
            this.customerid.ReadOnly = true;
            this.customerid.Width = 106;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 65;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 67;
            // 
            // Fees
            // 
            this.Fees.HeaderText = "fee";
            this.Fees.MinimumWidth = 6;
            this.Fees.Name = "Fees";
            this.Fees.Width = 55;
            // 
            // Status
            // 
            this.Status.HeaderText = "status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 71;
            // 
            // productCard
            // 
            this.productCard.Location = new System.Drawing.Point(448, 103);
            this.productCard.Name = "productCard";
            this.productCard.Size = new System.Drawing.Size(1114, 413);
            this.productCard.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 39);
            this.label2.TabIndex = 39;
            this.label2.Text = "Product";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(56, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 826);
            this.panel1.TabIndex = 39;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 942);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productCard);
            this.Controls.Add(this.tblOrder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel productCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}