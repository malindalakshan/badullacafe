namespace OrderingSystem
{
    partial class CustomerCartPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCartPopup));
            this.tblcusCartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDBAppDataAdminCartView = new OrderingSystem.UsersDBAppDataAdminCartView();
            this.usersDBAppDataCus = new OrderingSystem.UsersDBAppDataCus();
            this.tblRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRegTableAdapter = new OrderingSystem.UsersDBAppDataCusTableAdapters.tblRegTableAdapter();
            this.tblcusCartTableAdapter = new OrderingSystem.UsersDBAppDataAdminCartViewTableAdapters.tblcusCartTableAdapter();
            this.button26 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsercart = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.txtproductprice = new System.Windows.Forms.TextBox();
            this.txtproductquty = new System.Windows.Forms.TextBox();
            this.comProductname = new System.Windows.Forms.ComboBox();
            this.btnAddtocart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblcusCartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataAdminCartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // usersDBAppDataCus
            // 
            this.usersDBAppDataCus.DataSetName = "UsersDBAppDataCus";
            this.usersDBAppDataCus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRegBindingSource
            // 
            this.tblRegBindingSource.DataMember = "tblReg";
            this.tblRegBindingSource.DataSource = this.usersDBAppDataCus;
            // 
            // tblRegTableAdapter
            // 
            this.tblRegTableAdapter.ClearBeforeFill = true;
            // 
            // tblcusCartTableAdapter
            // 
            this.tblcusCartTableAdapter.ClearBeforeFill = true;
            // 
            // button26
            // 
            this.button26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button26.BackgroundImage")));
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.Transparent;
            this.button26.Location = new System.Drawing.Point(469, 5);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(39, 27);
            this.button26.TabIndex = 60;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Quantity";
            // 
            // txtUsercart
            // 
            this.txtUsercart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsercart.Location = new System.Drawing.Point(252, 110);
            this.txtUsercart.Name = "txtUsercart";
            this.txtUsercart.Size = new System.Drawing.Size(211, 30);
            this.txtUsercart.TabIndex = 5;
            // 
            // txtproductid
            // 
            this.txtproductid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_id", true));
            this.txtproductid.Enabled = false;
            this.txtproductid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(252, 163);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(211, 30);
            this.txtproductid.TabIndex = 6;
            // 
            // txtproductprice
            // 
            this.txtproductprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_price", true));
            this.txtproductprice.Enabled = false;
            this.txtproductprice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductprice.Location = new System.Drawing.Point(252, 270);
            this.txtproductprice.Name = "txtproductprice";
            this.txtproductprice.Size = new System.Drawing.Size(211, 30);
            this.txtproductprice.TabIndex = 7;
            // 
            // txtproductquty
            // 
            this.txtproductquty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductquty.Location = new System.Drawing.Point(252, 323);
            this.txtproductquty.Name = "txtproductquty";
            this.txtproductquty.Size = new System.Drawing.Size(211, 30);
            this.txtproductquty.TabIndex = 8;
            this.txtproductquty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproductquty_KeyPress);
            // 
            // comProductname
            // 
            this.comProductname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcusCartBindingSource, "Product_name", true));
            this.comProductname.DataSource = this.tblcusCartBindingSource;
            this.comProductname.DisplayMember = "Product_name";
            this.comProductname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comProductname.FormattingEnabled = true;
            this.comProductname.Location = new System.Drawing.Point(252, 216);
            this.comProductname.Name = "comProductname";
            this.comProductname.Size = new System.Drawing.Size(211, 31);
            this.comProductname.TabIndex = 9;
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtocart.Location = new System.Drawing.Point(252, 388);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.Size = new System.Drawing.Size(211, 36);
            this.btnAddtocart.TabIndex = 10;
            this.btnAddtocart.Text = "Add To Cart";
            this.btnAddtocart.UseVisualStyleBackColor = true;
            this.btnAddtocart.Click += new System.EventHandler(this.btnAddtocart_Click);
            // 
            // CustomerCartPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 562);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.comProductname);
            this.Controls.Add(this.txtproductquty);
            this.Controls.Add(this.txtproductprice);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.txtUsercart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerCartPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerCartPopup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomerCartPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblcusCartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataAdminCartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UsersDBAppDataCus usersDBAppDataCus;
        private System.Windows.Forms.BindingSource tblRegBindingSource;
        private UsersDBAppDataCusTableAdapters.tblRegTableAdapter tblRegTableAdapter;
        private UsersDBAppDataAdminCartView usersDBAppDataAdminCartView;
        private System.Windows.Forms.BindingSource tblcusCartBindingSource;
        private UsersDBAppDataAdminCartViewTableAdapters.tblcusCartTableAdapter tblcusCartTableAdapter;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsercart;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.TextBox txtproductprice;
        private System.Windows.Forms.TextBox txtproductquty;
        private System.Windows.Forms.ComboBox comProductname;
        private System.Windows.Forms.Button btnAddtocart;
    }
}