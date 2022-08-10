namespace OrderingSystem
{
    partial class AdminedtcusCartAd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminedtcusCartAd));
            this.AdaEDTcart = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcusCartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDBAppDataAdminCartView = new OrderingSystem.UsersDBAppDataAdminCartView();
            this.tblcusCartTableAdapter = new OrderingSystem.UsersDBAppDataAdminCartViewTableAdapters.tblcusCartTableAdapter();
            this.button27 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CARTadminedt = new System.Windows.Forms.Button();
            this.CARTadsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdaEDTcart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcusCartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataAdminCartView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaEDTcart
            // 
            this.AdaEDTcart.AllowUserToDeleteRows = false;
            this.AdaEDTcart.AutoGenerateColumns = false;
            this.AdaEDTcart.BackgroundColor = System.Drawing.Color.White;
            this.AdaEDTcart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdaEDTcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdaEDTcart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn});
            this.AdaEDTcart.DataSource = this.tblcusCartBindingSource;
            this.AdaEDTcart.GridColor = System.Drawing.Color.Red;
            this.AdaEDTcart.Location = new System.Drawing.Point(98, 139);
            this.AdaEDTcart.Name = "AdaEDTcart";
            this.AdaEDTcart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AdaEDTcart.RowHeadersWidth = 51;
            this.AdaEDTcart.RowTemplate.Height = 24;
            this.AdaEDTcart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdaEDTcart.Size = new System.Drawing.Size(931, 410);
            this.AdaEDTcart.TabIndex = 0;
            this.AdaEDTcart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdaEDTcart_KeyDown);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "Product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 150;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "Product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "Product Price";
            this.productpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            this.productpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblcusCartBindingSource
            // 
            this.tblcusCartBindingSource.DataMember = "tblcusCart";
            this.tblcusCartBindingSource.DataSource = this.usersDBAppDataAdminCartView;
            // 
            // usersDBAppDataAdminCartView
            // 
            this.usersDBAppDataAdminCartView.DataSetName = "UsersDBAppDataAdminCartView";
            this.usersDBAppDataAdminCartView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcusCartTableAdapter
            // 
            this.tblcusCartTableAdapter.ClearBeforeFill = true;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.Transparent;
            this.button27.Location = new System.Drawing.Point(1512, 5);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(39, 27);
            this.button27.TabIndex = 58;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1465, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 27);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(549, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 50);
            this.label2.TabIndex = 59;
            this.label2.Text = "Edit Customer Cart";
            // 
            // CARTadminedt
            // 
            this.CARTadminedt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARTadminedt.Location = new System.Drawing.Point(1064, 358);
            this.CARTadminedt.Name = "CARTadminedt";
            this.CARTadminedt.Size = new System.Drawing.Size(204, 51);
            this.CARTadminedt.TabIndex = 60;
            this.CARTadminedt.Text = "Edit Product Price";
            this.CARTadminedt.UseVisualStyleBackColor = true;
            this.CARTadminedt.Click += new System.EventHandler(this.CARTadminedt_Click);
            // 
            // CARTadsave
            // 
            this.CARTadsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARTadsave.Location = new System.Drawing.Point(1290, 358);
            this.CARTadsave.Name = "CARTadsave";
            this.CARTadsave.Size = new System.Drawing.Size(214, 51);
            this.CARTadsave.TabIndex = 61;
            this.CARTadsave.Text = "Save Product Price";
            this.CARTadsave.UseVisualStyleBackColor = true;
            this.CARTadsave.Click += new System.EventHandler(this.CARTadsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1059, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 62;
            this.label1.Text = "Product_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1059, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 63;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1059, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 64;
            this.label4.Text = "Product Price";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_name", true));
            this.textBox1.Location = new System.Drawing.Point(1227, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(277, 28);
            this.textBox1.TabIndex = 65;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_price", true));
            this.textBox3.Location = new System.Drawing.Point(1227, 300);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 28);
            this.textBox3.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_id", true));
            this.textBox2.Location = new System.Drawing.Point(1227, 198);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(277, 30);
            this.textBox2.TabIndex = 68;
            // 
            // AdminedtcusCartAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 726);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CARTadsave);
            this.Controls.Add(this.CARTadminedt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AdaEDTcart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminedtcusCartAd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edtcusCartAd";
            this.Load += new System.EventHandler(this.edtcusCartAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdaEDTcart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcusCartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataAdminCartView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdaEDTcart;
        private UsersDBAppDataAdminCartView usersDBAppDataAdminCartView;
        private System.Windows.Forms.BindingSource tblcusCartBindingSource;
        private UsersDBAppDataAdminCartViewTableAdapters.tblcusCartTableAdapter tblcusCartTableAdapter;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CARTadminedt;
        private System.Windows.Forms.Button CARTadsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}