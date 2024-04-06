
namespace FinalProject
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.cboSupplierID = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboPaymentStatus = new System.Windows.Forms.ComboBox();
            this.txtPaymentTerm = new System.Windows.Forms.TextBox();
            this.btnCreatePurchase = new System.Windows.Forms.Button();
            this.tblPurchase = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPurchaseItem = new System.Windows.Forms.DataGridView();
            this.lsb_searchProduct = new System.Windows.Forms.ListBox();
            this.searchProduct = new System.Windows.Forms.ComboBox();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPurchaseItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Purchase";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(109, 131);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(387, 48);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 2;
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(109, 274);
            this.txtPaid.Multiline = true;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(387, 48);
            this.txtPaid.TabIndex = 3;
            this.txtPaid.Text = "Paid";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(109, 201);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(387, 48);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.Text = "Discount";
            // 
            // txtShipping
            // 
            this.txtShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipping.Location = new System.Drawing.Point(109, 345);
            this.txtShipping.Multiline = true;
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(387, 48);
            this.txtShipping.TabIndex = 5;
            this.txtShipping.Text = "Shipping";
            // 
            // cboSupplierID
            // 
            this.cboSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplierID.FormattingEnabled = true;
            this.cboSupplierID.Location = new System.Drawing.Point(555, 131);
            this.cboSupplierID.Name = "cboSupplierID";
            this.cboSupplierID.Size = new System.Drawing.Size(334, 44);
            this.cboSupplierID.TabIndex = 6;
            this.cboSupplierID.Text = "Supplier";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(555, 274);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(334, 44);
            this.cboStatus.TabIndex = 7;
            this.cboStatus.Text = "Status";
            // 
            // cboPaymentStatus
            // 
            this.cboPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentStatus.FormattingEnabled = true;
            this.cboPaymentStatus.Location = new System.Drawing.Point(555, 199);
            this.cboPaymentStatus.Name = "cboPaymentStatus";
            this.cboPaymentStatus.Size = new System.Drawing.Size(334, 44);
            this.cboPaymentStatus.TabIndex = 8;
            this.cboPaymentStatus.Text = "Payment Status";
            // 
            // txtPaymentTerm
            // 
            this.txtPaymentTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentTerm.Location = new System.Drawing.Point(555, 345);
            this.txtPaymentTerm.Multiline = true;
            this.txtPaymentTerm.Name = "txtPaymentTerm";
            this.txtPaymentTerm.Size = new System.Drawing.Size(334, 48);
            this.txtPaymentTerm.TabIndex = 9;
            this.txtPaymentTerm.Text = "Payment Term";
            // 
            // btnCreatePurchase
            // 
            this.btnCreatePurchase.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreatePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreatePurchase.Location = new System.Drawing.Point(555, 413);
            this.btnCreatePurchase.Name = "btnCreatePurchase";
            this.btnCreatePurchase.Size = new System.Drawing.Size(334, 46);
            this.btnCreatePurchase.TabIndex = 29;
            this.btnCreatePurchase.Text = "Create Purchase";
            this.btnCreatePurchase.UseVisualStyleBackColor = false;
            this.btnCreatePurchase.Click += new System.EventHandler(this.btnCreatePurchase_Click);
            // 
            // tblPurchase
            // 
            this.tblPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.date,
            this.discount,
            this.paid,
            this.shipping,
            this.Supplier_id,
            this.payment_status,
            this.status,
            this.payment_term});
            this.tblPurchase.Location = new System.Drawing.Point(109, 481);
            this.tblPurchase.Name = "tblPurchase";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPurchase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblPurchase.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPurchase.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblPurchase.RowTemplate.Height = 24;
            this.tblPurchase.Size = new System.Drawing.Size(1450, 779);
            this.tblPurchase.TabIndex = 38;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.FillWeight = 57.10773F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // date
            // 
            this.date.FillWeight = 120.3045F;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.FillWeight = 120.3045F;
            this.discount.HeaderText = "Discount";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // paid
            // 
            this.paid.FillWeight = 120.3045F;
            this.paid.HeaderText = "Paid";
            this.paid.MinimumWidth = 6;
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            // 
            // shipping
            // 
            this.shipping.FillWeight = 120.3045F;
            this.shipping.HeaderText = "Shipping";
            this.shipping.MinimumWidth = 6;
            this.shipping.Name = "shipping";
            this.shipping.ReadOnly = true;
            // 
            // Supplier_id
            // 
            this.Supplier_id.FillWeight = 105.9178F;
            this.Supplier_id.HeaderText = "Supplier_id";
            this.Supplier_id.MinimumWidth = 6;
            this.Supplier_id.Name = "Supplier_id";
            // 
            // payment_status
            // 
            this.payment_status.FillWeight = 105.9178F;
            this.payment_status.HeaderText = "Payment_status";
            this.payment_status.MinimumWidth = 6;
            this.payment_status.Name = "payment_status";
            // 
            // status
            // 
            this.status.FillWeight = 105.9178F;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // payment_term
            // 
            this.payment_term.FillWeight = 105.9178F;
            this.payment_term.HeaderText = "Payment_term";
            this.payment_term.MinimumWidth = 6;
            this.payment_term.Name = "payment_term";
            this.payment_term.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tblPurchaseItem
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPurchaseItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tblPurchaseItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPurchaseItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.purchase_id,
            this.product_id,
            this.Quantity,
            this.Cost});
            this.tblPurchaseItem.Location = new System.Drawing.Point(1200, 131);
            this.tblPurchaseItem.Name = "tblPurchaseItem";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPurchaseItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tblPurchaseItem.RowHeadersWidth = 51;
            this.tblPurchaseItem.RowTemplate.Height = 24;
            this.tblPurchaseItem.Size = new System.Drawing.Size(407, 279);
            this.tblPurchaseItem.TabIndex = 41;
            // 
            // lsb_searchProduct
            // 
            this.lsb_searchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_searchProduct.FormattingEnabled = true;
            this.lsb_searchProduct.ItemHeight = 25;
            this.lsb_searchProduct.Location = new System.Drawing.Point(913, 181);
            this.lsb_searchProduct.Name = "lsb_searchProduct";
            this.lsb_searchProduct.Size = new System.Drawing.Size(281, 229);
            this.lsb_searchProduct.TabIndex = 40;
            this.lsb_searchProduct.SelectedIndexChanged += new System.EventHandler(this.lsb_searchProduct_SelectedIndexChanged);
            // 
            // searchProduct
            // 
            this.searchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProduct.FormattingEnabled = true;
            this.searchProduct.Location = new System.Drawing.Point(913, 131);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(281, 44);
            this.searchProduct.TabIndex = 39;
            this.searchProduct.TabIndexChanged += new System.EventHandler(this.SearchProduct_TabIndexChanged);
            this.searchProduct.TextChanged += new System.EventHandler(this.SearchProduct_TextChanged);
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PID.HeaderText = "ID";
            this.PID.MinimumWidth = 6;
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // purchase_id
            // 
            this.purchase_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchase_id.HeaderText = "Purchase_id";
            this.purchase_id.MinimumWidth = 6;
            this.purchase_id.Name = "purchase_id";
            this.purchase_id.ReadOnly = true;
            // 
            // product_id
            // 
            this.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_id.HeaderText = "Product_id";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 125;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 942);
            this.Controls.Add(this.tblPurchaseItem);
            this.Controls.Add(this.lsb_searchProduct);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.tblPurchase);
            this.Controls.Add(this.btnCreatePurchase);
            this.Controls.Add(this.txtPaymentTerm);
            this.Controls.Add(this.cboPaymentStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboSupplierID);
            this.Controls.Add(this.txtShipping);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase";
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.tblPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPurchaseItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.ComboBox cboSupplierID;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboPaymentStatus;
        private System.Windows.Forms.TextBox txtPaymentTerm;
        private System.Windows.Forms.Button btnCreatePurchase;
        private System.Windows.Forms.DataGridView tblPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_term;
        private System.Windows.Forms.DataGridView tblPurchaseItem;
        private System.Windows.Forms.ListBox lsb_searchProduct;
        private System.Windows.Forms.ComboBox searchProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}