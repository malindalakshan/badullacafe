namespace OrderingSystem
{
    partial class CustomercusReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomercusReg));
            this.button27 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cusCreate = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txthome = new System.Windows.Forms.TextBox();
            this.txttele = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.usersDBAppDataCus = new OrderingSystem.UsersDBAppDataCus();
            this.tblRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRegTableAdapter = new OrderingSystem.UsersDBAppDataCusTableAdapters.tblRegTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.Transparent;
            this.button27.Location = new System.Drawing.Point(1218, 5);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(39, 27);
            this.button27.TabIndex = 56;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cusCreate
            // 
            this.cusCreate.BackColor = System.Drawing.Color.Transparent;
            this.cusCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusCreate.ForeColor = System.Drawing.Color.Red;
            this.cusCreate.Location = new System.Drawing.Point(656, 646);
            this.cusCreate.Name = "cusCreate";
            this.cusCreate.Size = new System.Drawing.Size(207, 51);
            this.cusCreate.TabIndex = 27;
            this.cusCreate.Text = "REGISTER";
            this.cusCreate.UseVisualStyleBackColor = false;
            this.cusCreate.Click += new System.EventHandler(this.cusCreate_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(1017, 484);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(192, 27);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "SHOW PASSWORD";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(526, 300);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(459, 22);
            this.txtfirst.TabIndex = 22;
            // 
            // txtcpass
            // 
            this.txtcpass.Location = new System.Drawing.Point(526, 489);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.PasswordChar = '.';
            this.txtcpass.Size = new System.Drawing.Size(459, 22);
            this.txtcpass.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(231, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 38);
            this.label3.TabIndex = 19;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(234, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 38);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(234, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(230, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 38);
            this.label6.TabIndex = 19;
            this.label6.Text = "Telephone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(234, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 38);
            this.label7.TabIndex = 19;
            this.label7.Text = "Home Address";
            // 
            // txthome
            // 
            this.txthome.Location = new System.Drawing.Point(526, 581);
            this.txthome.Multiline = true;
            this.txthome.Name = "txthome";
            this.txthome.Size = new System.Drawing.Size(459, 51);
            this.txthome.TabIndex = 21;
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(526, 535);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(459, 22);
            this.txttele.TabIndex = 21;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(526, 390);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(459, 22);
            this.txtusername.TabIndex = 21;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(526, 438);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '.';
            this.txtpass.Size = new System.Drawing.Size(459, 22);
            this.txtpass.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(526, 344);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(459, 22);
            this.txtemail.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1128, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 27);
            this.button3.TabIndex = 59;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BackColor = System.Drawing.Color.White;
            this.btnmax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmax.BackgroundImage")));
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.ForeColor = System.Drawing.Color.Transparent;
            this.btnmax.Location = new System.Drawing.Point(1173, 5);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(39, 27);
            this.btnmax.TabIndex = 58;
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
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
            // cusReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 729);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.cusCreate);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txthome);
            this.Controls.Add(this.txtcpass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cusReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cusReg";
            this.Load += new System.EventHandler(this.cusReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBAppDataCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cusCreate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthome;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnmax;
        private UsersDBAppDataCus usersDBAppDataCus;
        private System.Windows.Forms.BindingSource tblRegBindingSource;
        private UsersDBAppDataCusTableAdapters.tblRegTableAdapter tblRegTableAdapter;
    }
}