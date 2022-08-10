using System;

namespace OrderingSystem
{
    partial class AdminedtCusAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminedtCusAcc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDBAppDataCus = new OrderingSystem.UsersDBAppDataCus();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.tblRegTableAdapter = new OrderingSystem.UsersDBAppDataCusTableAdapters.tblRegTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmobi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataCus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1114, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(565, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 50);
            this.label2.TabIndex = 57;
            this.label2.Text = "Edit Customer Account";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.tblRegBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(37, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 511);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tblRegBindingSource
            // 
            this.tblRegBindingSource.DataMember = "tblReg";
            this.tblRegBindingSource.DataSource = this.usersDBAppDataCus;
            // 
            // usersDBAppDataCus
            // 
            this.usersDBAppDataCus.DataSetName = "UsersDBAppDataCus";
            this.usersDBAppDataCus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblRegBindingSource, "email", true));
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(1331, 230);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(229, 22);
            this.txtemail.TabIndex = 59;
            this.txtemail.TextChanged += new System.EventHandler(this.txtUserSer_TextChanged);
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
            this.button2.Location = new System.Drawing.Point(1476, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 27);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.Transparent;
            this.button27.Location = new System.Drawing.Point(1521, 9);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(39, 27);
            this.button27.TabIndex = 56;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.Location = new System.Drawing.Point(1468, 509);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(92, 31);
            this.BTN_Refresh.TabIndex = 61;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.Location = new System.Drawing.Point(1331, 509);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(92, 31);
            this.BTN_Delete.TabIndex = 62;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // tblRegTableAdapter
            // 
            this.tblRegTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1114, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password : ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtuname
            // 
            this.txtuname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblRegBindingSource, "username", true));
            this.txtuname.Enabled = false;
            this.txtuname.Location = new System.Drawing.Point(1331, 283);
            this.txtuname.Name = "txtuname";
            this.txtuname.ReadOnly = true;
            this.txtuname.Size = new System.Drawing.Size(229, 22);
            this.txtuname.TabIndex = 59;
            this.txtuname.TextChanged += new System.EventHandler(this.txtUserSer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1114, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "User Name : ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpwd
            // 
            this.txtpwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblRegBindingSource, "password", true));
            this.txtpwd.Enabled = false;
            this.txtpwd.Location = new System.Drawing.Point(1331, 336);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.ReadOnly = true;
            this.txtpwd.Size = new System.Drawing.Size(229, 22);
            this.txtpwd.TabIndex = 59;
            this.txtpwd.TextChanged += new System.EventHandler(this.txtUserSer_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1114, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "First Name : ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // fname
            // 
            this.fname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblRegBindingSource, "firstname", true));
            this.fname.Enabled = false;
            this.fname.Location = new System.Drawing.Point(1331, 177);
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Size = new System.Drawing.Size(229, 22);
            this.fname.TabIndex = 59;
            this.fname.TextChanged += new System.EventHandler(this.txtUserSer_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1114, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mobile Number : ";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmobi
            // 
            this.txtmobi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblRegBindingSource, "telnumber", true));
            this.txtmobi.Enabled = false;
            this.txtmobi.Location = new System.Drawing.Point(1331, 389);
            this.txtmobi.Name = "txtmobi";
            this.txtmobi.ReadOnly = true;
            this.txtmobi.Size = new System.Drawing.Size(229, 22);
            this.txtmobi.TabIndex = 59;
            this.txtmobi.TextChanged += new System.EventHandler(this.txtUserSer_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1114, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Home Address : ";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblRegBindingSource, "homeaddress", true));
            this.txtaddress.Enabled = false;
            this.txtaddress.Location = new System.Drawing.Point(1331, 442);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(229, 51);
            this.txtaddress.TabIndex = 59;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtUserSer_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "firstname";
            this.dataGridViewTextBoxColumn1.FillWeight = 93.5829F;
            this.dataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn2.FillWeight = 92.47417F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn3.FillWeight = 95.55535F;
            this.dataGridViewTextBoxColumn3.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn4.FillWeight = 90.45796F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Password";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "confirmpassword";
            this.dataGridViewTextBoxColumn5.FillWeight = 109.3099F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Confirm Password";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "telnumber";
            this.dataGridViewTextBoxColumn6.FillWeight = 109.3099F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Telephone Number";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "homeaddress";
            this.dataGridViewTextBoxColumn7.FillWeight = 109.3099F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Home Address";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // AdminedtCusAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 726);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtmobi);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminedtCusAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edtCusAcc";
            this.Load += new System.EventHandler(this.edtCusAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox txtemail;
       
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_Delete;
        private UsersDBAppDataCus usersDBAppDataCus;
        private System.Windows.Forms.BindingSource tblRegBindingSource;
        private UsersDBAppDataCusTableAdapters.tblRegTableAdapter tblRegTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmobi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}