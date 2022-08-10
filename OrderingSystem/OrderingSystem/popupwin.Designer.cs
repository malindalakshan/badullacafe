namespace OrderingSystem
{
    partial class popupwin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popupwin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Prod = new System.Windows.Forms.Label();
            this.labelaaaaaa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtu = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtq = new System.Windows.Forms.TextBox();
            this.tblcusCartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDBCusCartApp = new OrderingSystem.UsersDBCusCartApp();
            this.comb = new System.Windows.Forms.ComboBox();
            this.BTN_a = new System.Windows.Forms.Button();
            this.BTN_b = new System.Windows.Forms.Button();
            this.tblcusCartTableAdapter = new OrderingSystem.UsersDBCusCartAppTableAdapters.tblcusCartTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcusCartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBCusCartApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Prod
            // 
            this.Prod.AutoSize = true;
            this.Prod.BackColor = System.Drawing.Color.Transparent;
            this.Prod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod.ForeColor = System.Drawing.Color.White;
            this.Prod.Location = new System.Drawing.Point(54, 297);
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(116, 28);
            this.Prod.TabIndex = 1;
            this.Prod.Text = "User Name";
            // 
            // labelaaaaaa
            // 
            this.labelaaaaaa.AutoSize = true;
            this.labelaaaaaa.BackColor = System.Drawing.Color.Transparent;
            this.labelaaaaaa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaaaaaa.ForeColor = System.Drawing.Color.White;
            this.labelaaaaaa.Location = new System.Drawing.Point(54, 336);
            this.labelaaaaaa.Name = "labelaaaaaa";
            this.labelaaaaaa.Size = new System.Drawing.Size(148, 28);
            this.labelaaaaaa.TabIndex = 2;
            this.labelaaaaaa.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Quantity";
            // 
            // txtu
            // 
            this.txtu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_id", true));
            this.txtu.Location = new System.Drawing.Point(248, 297);
            this.txtu.Multiline = true;
            this.txtu.Name = "txtu";
            this.txtu.Size = new System.Drawing.Size(331, 29);
            this.txtu.TabIndex = 5;
            // 
            // txtp
            // 
            this.txtp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_price", true));
            this.txtp.Location = new System.Drawing.Point(248, 380);
            this.txtp.Multiline = true;
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(331, 29);
            this.txtp.TabIndex = 6;
            // 
            // txtq
            // 
            this.txtq.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_Qty", true));
            this.txtq.Location = new System.Drawing.Point(248, 423);
            this.txtq.Multiline = true;
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(331, 29);
            this.txtq.TabIndex = 7;
            // 
            // tblcusCartBindingSource
            // 
            this.tblcusCartBindingSource.DataMember = "tblcusCart";
            this.tblcusCartBindingSource.DataSource = this.usersDBCusCartApp;
            // 
            // usersDBCusCartApp
            // 
            this.usersDBCusCartApp.DataSetName = "UsersDBCusCartApp";
            this.usersDBCusCartApp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comb
            // 
            this.comb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_name", true));
            this.comb.FormattingEnabled = true;
            this.comb.Items.AddRange(new object[] {
            "Muffins",
            "Burger",
            "Fish Bun",
            "Pastries",
            "Rolls",
            "Cake",
            "Submarine Bun",
            "French Frice",
            "Pizza",
            "Kabab Roll",
            "Hot Dogs",
            "Sandwich Bread"});
            this.comb.Location = new System.Drawing.Point(248, 340);
            this.comb.Name = "comb";
            this.comb.Size = new System.Drawing.Size(331, 24);
            this.comb.TabIndex = 8;
            // 
            // BTN_a
            // 
            this.BTN_a.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_a.Location = new System.Drawing.Point(248, 479);
            this.BTN_a.Name = "BTN_a";
            this.BTN_a.Size = new System.Drawing.Size(142, 39);
            this.BTN_a.TabIndex = 9;
            this.BTN_a.Text = "Add to Cart";
            this.BTN_a.UseVisualStyleBackColor = true;
            this.BTN_a.Click += new System.EventHandler(this.BTN_a_Click);
            // 
            // BTN_b
            // 
            this.BTN_b.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_b.Location = new System.Drawing.Point(427, 479);
            this.BTN_b.Name = "BTN_b";
            this.BTN_b.Size = new System.Drawing.Size(152, 39);
            this.BTN_b.TabIndex = 10;
            this.BTN_b.Text = "Buy";
            this.BTN_b.UseVisualStyleBackColor = true;
            // 
            // tblcusCartTableAdapter
            // 
            this.tblcusCartTableAdapter.ClearBeforeFill = true;
            // 
            // popupwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 558);
            this.Controls.Add(this.BTN_b);
            this.Controls.Add(this.BTN_a);
            this.Controls.Add(this.comb);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelaaaaaa);
            this.Controls.Add(this.Prod);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popupwin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popupwin";
            this.Load += new System.EventHandler(this.popupwin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcusCartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBCusCartApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Prod;
        private System.Windows.Forms.Label labelaaaaaa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtu;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.ComboBox comb;
        private System.Windows.Forms.Button BTN_a;
        private System.Windows.Forms.Button BTN_b;
        private UsersDBCusCartApp usersDBCusCartApp;
        private System.Windows.Forms.BindingSource tblcusCartBindingSource;
        private UsersDBCusCartAppTableAdapters.tblcusCartTableAdapter tblcusCartTableAdapter;
    }
}