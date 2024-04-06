namespace FinalProject
{
    partial class Products
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
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProductUnit = new System.Windows.Forms.ComboBox();
            this.cboDefaultSaleUnit = new System.Windows.Forms.ComboBox();
            this.cboDefaultPurchaseUnit = new System.Windows.Forms.ComboBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tblProduct = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_standard = new System.Windows.Forms.Panel();
            this.pn_combo = new System.Windows.Forms.Panel();
            this.dgvListCbItem = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsb_searchProduct = new System.Windows.Forms.ListBox();
            this.cboSearchPro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).BeginInit();
            this.pn_standard.SuspendLayout();
            this.pn_combo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCbItem)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBrand
            // 
            this.cboBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(477, 204);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(387, 44);
            this.cboBrand.TabIndex = 18;
            this.cboBrand.Text = "Brand id";
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(49, 199);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(387, 44);
            this.cboCategory.TabIndex = 17;
            this.cboCategory.Text = "Category id";
            // 
            // cboProductType
            // 
            this.cboProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Items.AddRange(new object[] {
            "standard",
            "combo"});
            this.cboProductType.Location = new System.Drawing.Point(51, 118);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(385, 44);
            this.cboProductType.TabIndex = 16;
            this.cboProductType.Text = "standard";
            this.cboProductType.TextChanged += new System.EventHandler(this.cboProductType_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(900, 118);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(387, 48);
            this.txtProductName.TabIndex = 14;
            this.txtProductName.Text = "Product Name";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(477, 118);
            this.txtProductCode.Multiline = true;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(387, 48);
            this.txtProductCode.TabIndex = 13;
            this.txtProductCode.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 12;
            // 
            // txtProductCost
            // 
            this.txtProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCost.Location = new System.Drawing.Point(876, 30);
            this.txtProductCost.Multiline = true;
            this.txtProductCost.Name = "txtProductCost";
            this.txtProductCost.Size = new System.Drawing.Size(387, 48);
            this.txtProductCost.TabIndex = 11;
            this.txtProductCost.Text = "Product Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Products";
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Location = new System.Drawing.Point(453, 33);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(387, 44);
            this.cboProductUnit.TabIndex = 21;
            this.cboProductUnit.Text = "Product Unit";
            // 
            // cboDefaultSaleUnit
            // 
            this.cboDefaultSaleUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDefaultSaleUnit.FormattingEnabled = true;
            this.cboDefaultSaleUnit.Location = new System.Drawing.Point(27, 118);
            this.cboDefaultSaleUnit.Name = "cboDefaultSaleUnit";
            this.cboDefaultSaleUnit.Size = new System.Drawing.Size(387, 44);
            this.cboDefaultSaleUnit.TabIndex = 20;
            this.cboDefaultSaleUnit.Text = "Default Sale Unit id";
            // 
            // cboDefaultPurchaseUnit
            // 
            this.cboDefaultPurchaseUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDefaultPurchaseUnit.FormattingEnabled = true;
            this.cboDefaultPurchaseUnit.Location = new System.Drawing.Point(453, 118);
            this.cboDefaultPurchaseUnit.Name = "cboDefaultPurchaseUnit";
            this.cboDefaultPurchaseUnit.Size = new System.Drawing.Size(387, 44);
            this.cboDefaultPurchaseUnit.TabIndex = 23;
            this.cboDefaultPurchaseUnit.Text = "Default Purchase Unit id";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(900, 204);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(387, 48);
            this.txtProductPrice.TabIndex = 24;
            this.txtProductPrice.Text = "Product Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1368, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 192);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1386, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Product image";
            // 
            // cboSupplier
            // 
            this.cboSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(25, 34);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(387, 44);
            this.cboSupplier.TabIndex = 27;
            this.cboSupplier.Text = "Select Supplier";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.HotPink;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(1350, 377);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(257, 46);
            this.btnAddProduct.TabIndex = 28;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tblProduct
            // 
            this.tblProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.type,
            this.name,
            this.code,
            this.Category,
            this.Unit,
            this.Cost,
            this.Price,
            this.Image,
            this.Supplier});
            this.tblProduct.Location = new System.Drawing.Point(30, 594);
            this.tblProduct.Name = "tblProduct";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblProduct.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblProduct.RowTemplate.Height = 24;
            this.tblProduct.Size = new System.Drawing.Size(1588, 779);
            this.tblProduct.TabIndex = 37;
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
            // type
            // 
            this.type.FillWeight = 120.3045F;
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 120.3045F;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // code
            // 
            this.code.FillWeight = 120.3045F;
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.FillWeight = 120.3045F;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.FillWeight = 105.9178F;
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            // 
            // Cost
            // 
            this.Cost.FillWeight = 105.9178F;
            this.Cost.HeaderText = "cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            // 
            // Price
            // 
            this.Price.FillWeight = 105.9178F;
            this.Price.HeaderText = "price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Image
            // 
            this.Image.FillWeight = 105.9178F;
            this.Image.HeaderText = "image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Supplier
            // 
            this.Supplier.FillWeight = 105.9178F;
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            // 
            // pn_standard
            // 
            this.pn_standard.Controls.Add(this.cboProductUnit);
            this.pn_standard.Controls.Add(this.txtProductCost);
            this.pn_standard.Controls.Add(this.cboDefaultSaleUnit);
            this.pn_standard.Controls.Add(this.cboSupplier);
            this.pn_standard.Controls.Add(this.cboDefaultPurchaseUnit);
            this.pn_standard.Location = new System.Drawing.Point(21, 254);
            this.pn_standard.Name = "pn_standard";
            this.pn_standard.Size = new System.Drawing.Size(1266, 213);
            this.pn_standard.TabIndex = 38;
            // 
            // pn_combo
            // 
            this.pn_combo.Controls.Add(this.dgvListCbItem);
            this.pn_combo.Controls.Add(this.lsb_searchProduct);
            this.pn_combo.Controls.Add(this.cboSearchPro);
            this.pn_combo.Location = new System.Drawing.Point(21, 269);
            this.pn_combo.Name = "pn_combo";
            this.pn_combo.Size = new System.Drawing.Size(1285, 305);
            this.pn_combo.TabIndex = 39;
            this.pn_combo.Visible = false;
            // 
            // dgvListCbItem
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCbItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListCbItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCbItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.PName,
            this.Qty});
            this.dgvListCbItem.Location = new System.Drawing.Point(362, 15);
            this.dgvListCbItem.Name = "dgvListCbItem";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCbItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListCbItem.RowHeadersWidth = 51;
            this.dgvListCbItem.RowTemplate.Height = 24;
            this.dgvListCbItem.Size = new System.Drawing.Size(884, 282);
            this.dgvListCbItem.TabIndex = 19;
            this.dgvListCbItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCbItem_CellContentClick);
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PID.HeaderText = "ID";
            this.PID.MinimumWidth = 6;
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "Product Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            // 
            // lsb_searchProduct
            // 
            this.lsb_searchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_searchProduct.FormattingEnabled = true;
            this.lsb_searchProduct.ItemHeight = 25;
            this.lsb_searchProduct.Location = new System.Drawing.Point(30, 68);
            this.lsb_searchProduct.Name = "lsb_searchProduct";
            this.lsb_searchProduct.Size = new System.Drawing.Size(281, 229);
            this.lsb_searchProduct.TabIndex = 18;
            this.lsb_searchProduct.SelectedIndexChanged += new System.EventHandler(this.lsb_searchProduct_SelectedIndexChanged);
            // 
            // cboSearchPro
            // 
            this.cboSearchPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchPro.FormattingEnabled = true;
            this.cboSearchPro.Location = new System.Drawing.Point(30, 18);
            this.cboSearchPro.Name = "cboSearchPro";
            this.cboSearchPro.Size = new System.Drawing.Size(281, 44);
            this.cboSearchPro.TabIndex = 17;
            this.cboSearchPro.TextChanged += new System.EventHandler(this.cboSearchPro_TextChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 942);
            this.Controls.Add(this.pn_combo);
            this.Controls.Add(this.pn_standard);
            this.Controls.Add(this.tblProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboProductType);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).EndInit();
            this.pn_standard.ResumeLayout(false);
            this.pn_standard.PerformLayout();
            this.pn_combo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCbItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.ComboBox cboDefaultSaleUnit;
        private System.Windows.Forms.ComboBox cboDefaultPurchaseUnit;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView tblProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.Panel pn_standard;
        private System.Windows.Forms.Panel pn_combo;
        private System.Windows.Forms.ComboBox cboSearchPro;
        private System.Windows.Forms.ListBox lsb_searchProduct;
        private System.Windows.Forms.DataGridView dgvListCbItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}