namespace OrderingSystem
{
    partial class AdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editcartad = new System.Windows.Forms.Button();
            this.cusre = new System.Windows.Forms.Button();
            this.adlogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editcartad
            // 
            this.editcartad.BackColor = System.Drawing.Color.Transparent;
            this.editcartad.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcartad.ForeColor = System.Drawing.Color.Black;
            this.editcartad.Location = new System.Drawing.Point(839, 300);
            this.editcartad.Name = "editcartad";
            this.editcartad.Size = new System.Drawing.Size(405, 48);
            this.editcartad.TabIndex = 19;
            this.editcartad.Text = "Edit Food Cart";
            this.editcartad.UseVisualStyleBackColor = false;
            this.editcartad.Click += new System.EventHandler(this.editcartad_Click);
            // 
            // cusre
            // 
            this.cusre.BackColor = System.Drawing.Color.Transparent;
            this.cusre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusre.ForeColor = System.Drawing.Color.Black;
            this.cusre.Location = new System.Drawing.Point(839, 420);
            this.cusre.Name = "cusre";
            this.cusre.Size = new System.Drawing.Size(405, 48);
            this.cusre.TabIndex = 20;
            this.cusre.Text = "View Customer Feedback";
            this.cusre.UseVisualStyleBackColor = false;
            this.cusre.Click += new System.EventHandler(this.cusre_Click);
            // 
            // adlogout
            // 
            this.adlogout.BackColor = System.Drawing.Color.Transparent;
            this.adlogout.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adlogout.ForeColor = System.Drawing.Color.Black;
            this.adlogout.Location = new System.Drawing.Point(839, 480);
            this.adlogout.Name = "adlogout";
            this.adlogout.Size = new System.Drawing.Size(405, 48);
            this.adlogout.TabIndex = 21;
            this.adlogout.Text = "Log Out";
            this.adlogout.UseVisualStyleBackColor = false;
            this.adlogout.Click += new System.EventHandler(this.adlogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(839, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Edit Customer Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(839, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(405, 48);
            this.button2.TabIndex = 22;
            this.button2.Text = "View Customer Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 726);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adlogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cusre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editcartad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editcartad;
        private System.Windows.Forms.Button cusre;
        private System.Windows.Forms.Button adlogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}