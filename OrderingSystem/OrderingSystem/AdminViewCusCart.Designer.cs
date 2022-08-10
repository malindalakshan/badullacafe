namespace OrderingSystem
{
    partial class AdminViewCusCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewCusCart));
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.usersDBAppDataAdminCartView = new OrderingSystem.UsersDBAppDataAdminCartView();
            this.cuscartviewdb = new System.Windows.Forms.DataGridView();
            this.tblcartviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btncuscartRe = new System.Windows.Forms.Button();
            this.usersDBtblorCusDataApp = new OrderingSystem.UsersDBtblorCusDataApp();
            this.tblorcusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblorcusTableAdapter = new OrderingSystem.UsersDBtblorCusDataAppTableAdapters.tblorcusTableAdapter();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finaltotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataAdminCartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuscartviewdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcartviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBtblorCusDataApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorcusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(606, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 54);
            this.label2.TabIndex = 64;
            this.label2.Text = "View Customer Cart";
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
            this.button2.TabIndex = 66;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button27.TabIndex = 65;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // usersDBAppDataAdminCartView
            // 
            this.usersDBAppDataAdminCartView.DataSetName = "UsersDBAppDataAdminCartView";
            this.usersDBAppDataAdminCartView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuscartviewdb
            // 
            this.cuscartviewdb.AutoGenerateColumns = false;
            this.cuscartviewdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuscartviewdb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.finaltotDataGridViewTextBoxColumn});
            this.cuscartviewdb.DataSource = this.tblorcusBindingSource;
            this.cuscartviewdb.Location = new System.Drawing.Point(345, 157);
            this.cuscartviewdb.Name = "cuscartviewdb";
            this.cuscartviewdb.RowHeadersWidth = 51;
            this.cuscartviewdb.RowTemplate.Height = 24;
            this.cuscartviewdb.Size = new System.Drawing.Size(896, 386);
            this.cuscartviewdb.TabIndex = 67;
            // 
            // tblcartviewBindingSource
            // 
            this.tblcartviewBindingSource.DataMember = "tblcartview";
            // 
            // btncuscartRe
            // 
            this.btncuscartRe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncuscartRe.BackColor = System.Drawing.Color.Transparent;
            this.btncuscartRe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncuscartRe.BackgroundImage")));
            this.btncuscartRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncuscartRe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuscartRe.Location = new System.Drawing.Point(1247, 493);
            this.btncuscartRe.Name = "btncuscartRe";
            this.btncuscartRe.Size = new System.Drawing.Size(50, 50);
            this.btncuscartRe.TabIndex = 68;
            this.btncuscartRe.UseVisualStyleBackColor = false;
            this.btncuscartRe.Click += new System.EventHandler(this.btncuscartRe_Click);
            // 
            // usersDBtblorCusDataApp
            // 
            this.usersDBtblorCusDataApp.DataSetName = "UsersDBtblorCusDataApp";
            this.usersDBtblorCusDataApp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblorcusBindingSource
            // 
            this.tblorcusBindingSource.DataMember = "tblorcus";
            this.tblorcusBindingSource.DataSource = this.usersDBtblorCusDataApp;
            // 
            // tblorcusTableAdapter
            // 
            this.tblorcusTableAdapter.ClearBeforeFill = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "orderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn1.HeaderText = "username";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "foodname";
            this.dataGridViewTextBoxColumn2.HeaderText = "foodname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "foodprice";
            this.dataGridViewTextBoxColumn3.HeaderText = "foodprice";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "foodqty";
            this.dataGridViewTextBoxColumn4.HeaderText = "foodqty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // finaltotDataGridViewTextBoxColumn
            // 
            this.finaltotDataGridViewTextBoxColumn.DataPropertyName = "finaltot";
            this.finaltotDataGridViewTextBoxColumn.HeaderText = "finaltot";
            this.finaltotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finaltotDataGridViewTextBoxColumn.Name = "finaltotDataGridViewTextBoxColumn";
            this.finaltotDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdminViewCusCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 726);
            this.Controls.Add(this.btncuscartRe);
            this.Controls.Add(this.cuscartviewdb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewCusCart";
            this.Text = "AdminViewCusCart";
            this.Load += new System.EventHandler(this.AdminViewCusCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataAdminCartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuscartviewdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcartviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBtblorCusDataApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorcusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button27;
        private UsersDBAppDataAdminCartView usersDBAppDataAdminCartView;
        private System.Windows.Forms.DataGridView cuscartviewdb;
       
        private System.Windows.Forms.BindingSource tblcartviewBindingSource;
        
        
        private System.Windows.Forms.Button btncuscartRe;
        private UsersDBtblorCusDataApp usersDBtblorCusDataApp;
        private System.Windows.Forms.BindingSource tblorcusBindingSource;
        private UsersDBtblorCusDataAppTableAdapters.tblorcusTableAdapter tblorcusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn finaltotDataGridViewTextBoxColumn;
    }
}