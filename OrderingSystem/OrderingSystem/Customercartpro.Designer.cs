namespace OrderingSystem
{
    partial class Cuscartpro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuscartpro));
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btncuscartRe = new System.Windows.Forms.Button();
            this.txtcusfoodview = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDELE = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tblorcusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDBtblorCusDataApp = new OrderingSystem.UsersDBtblorCusDataApp();
            this.tblorcusTableAdapter = new OrderingSystem.UsersDBtblorCusDataAppTableAdapters.tblorcusTableAdapter();
            this.tblorCUS = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finaltotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblorcusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBtblorCusDataApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorCUS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(712, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY CART";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1465, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 27);
            this.button3.TabIndex = 60;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BackColor = System.Drawing.Color.White;
            this.btnmax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmax.BackgroundImage")));
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.ForeColor = System.Drawing.Color.Transparent;
            this.btnmax.Location = new System.Drawing.Point(1512, 5);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(39, 27);
            this.btnmax.TabIndex = 59;
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btncuscartRe
            // 
            this.btncuscartRe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncuscartRe.BackColor = System.Drawing.Color.Transparent;
            this.btncuscartRe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncuscartRe.BackgroundImage")));
            this.btncuscartRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncuscartRe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuscartRe.Location = new System.Drawing.Point(1454, 483);
            this.btncuscartRe.Name = "btncuscartRe";
            this.btncuscartRe.Size = new System.Drawing.Size(50, 50);
            this.btncuscartRe.TabIndex = 62;
            this.btncuscartRe.UseVisualStyleBackColor = false;
            this.btncuscartRe.Click += new System.EventHandler(this.btncuscartRe_Click);
            // 
            // txtcusfoodview
            // 
            this.txtcusfoodview.Location = new System.Drawing.Point(663, 593);
            this.txtcusfoodview.Multiline = true;
            this.txtcusfoodview.Name = "txtcusfoodview";
            this.txtcusfoodview.ReadOnly = true;
            this.txtcusfoodview.Size = new System.Drawing.Size(228, 31);
            this.txtcusfoodview.TabIndex = 65;
            this.txtcusfoodview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(572, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 64;
            this.label2.Text = "Total : ";
            // 
            // btnDELE
            // 
            this.btnDELE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDELE.BackColor = System.Drawing.Color.Transparent;
            this.btnDELE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDELE.BackgroundImage")));
            this.btnDELE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDELE.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELE.Location = new System.Drawing.Point(1398, 483);
            this.btnDELE.Name = "btnDELE";
            this.btnDELE.Size = new System.Drawing.Size(50, 50);
            this.btnDELE.TabIndex = 67;
            this.btnDELE.UseVisualStyleBackColor = false;
            this.btnDELE.Click += new System.EventHandler(this.btnDELE_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(919, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 31);
            this.button2.TabIndex = 69;
            this.button2.Text = "Check Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tblorcusBindingSource
            // 
            this.tblorcusBindingSource.DataMember = "tblorcus";
            this.tblorcusBindingSource.DataSource = this.usersDBtblorCusDataApp;
            // 
            // usersDBtblorCusDataApp
            // 
            this.usersDBtblorCusDataApp.DataSetName = "UsersDBtblorCusDataApp";
            this.usersDBtblorCusDataApp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblorcusTableAdapter
            // 
            this.tblorcusTableAdapter.ClearBeforeFill = true;
            // 
            // tblorCUS
            // 
            this.tblorCUS.AllowUserToAddRows = false;
            this.tblorCUS.AutoGenerateColumns = false;
            this.tblorCUS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblorCUS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.orderIdDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.foodnameDataGridViewTextBoxColumn,
            this.foodpriceDataGridViewTextBoxColumn,
            this.foodqtyDataGridViewTextBoxColumn,
            this.finaltotDataGridViewTextBoxColumn});
            this.tblorCUS.DataSource = this.tblorcusBindingSource;
            this.tblorCUS.Location = new System.Drawing.Point(157, 83);
            this.tblorCUS.Name = "tblorCUS";
            this.tblorCUS.RowHeadersWidth = 51;
            this.tblorCUS.RowTemplate.Height = 24;
            this.tblorCUS.Size = new System.Drawing.Size(1235, 450);
            this.tblorCUS.TabIndex = 71;
            this.tblorCUS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblorCUS_CellContentClick);
            // 
            // Col
            // 
            this.Col.HeaderText = "Select";
            this.Col.MinimumWidth = 6;
            this.Col.Name = "Col";
            this.Col.Width = 125;
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
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodnameDataGridViewTextBoxColumn
            // 
            this.foodnameDataGridViewTextBoxColumn.DataPropertyName = "foodname";
            this.foodnameDataGridViewTextBoxColumn.HeaderText = "foodname";
            this.foodnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodnameDataGridViewTextBoxColumn.Name = "foodnameDataGridViewTextBoxColumn";
            this.foodnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodpriceDataGridViewTextBoxColumn
            // 
            this.foodpriceDataGridViewTextBoxColumn.DataPropertyName = "foodprice";
            this.foodpriceDataGridViewTextBoxColumn.HeaderText = "foodprice";
            this.foodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodpriceDataGridViewTextBoxColumn.Name = "foodpriceDataGridViewTextBoxColumn";
            this.foodpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodqtyDataGridViewTextBoxColumn
            // 
            this.foodqtyDataGridViewTextBoxColumn.DataPropertyName = "foodqty";
            this.foodqtyDataGridViewTextBoxColumn.HeaderText = "foodqty";
            this.foodqtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodqtyDataGridViewTextBoxColumn.Name = "foodqtyDataGridViewTextBoxColumn";
            this.foodqtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // finaltotDataGridViewTextBoxColumn
            // 
            this.finaltotDataGridViewTextBoxColumn.DataPropertyName = "finaltot";
            this.finaltotDataGridViewTextBoxColumn.HeaderText = "finaltot";
            this.finaltotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finaltotDataGridViewTextBoxColumn.Name = "finaltotDataGridViewTextBoxColumn";
            this.finaltotDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cuscartpro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 726);
            this.Controls.Add(this.tblorCUS);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDELE);
            this.Controls.Add(this.btncuscartRe);
            this.Controls.Add(this.txtcusfoodview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuscartpro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cartpro";
            this.Load += new System.EventHandler(this.cartpro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblorcusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBtblorCusDataApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorCUS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btncuscartRe;
        private System.Windows.Forms.TextBox txtcusfoodview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDELE;
        private System.Windows.Forms.Button button2;
        private UsersDBtblorCusDataApp usersDBtblorCusDataApp;
        private System.Windows.Forms.BindingSource tblorcusBindingSource;
        private UsersDBtblorCusDataAppTableAdapters.tblorcusTableAdapter tblorcusTableAdapter;
        private System.Windows.Forms.DataGridView tblorCUS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finaltotDataGridViewTextBoxColumn;
    }
}