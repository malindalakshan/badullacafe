namespace OrderingSystem
{
    partial class AdminviewCusFeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminviewCusFeed));
            this.button2 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cuscartviewdb = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userfeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblfeedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDBFeedAppData = new OrderingSystem.UsersDBFeedAppData();
            this.tblfeedTableAdapter = new OrderingSystem.UsersDBFeedAppDataTableAdapters.tblfeedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cuscartviewdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBFeedAppData)).BeginInit();
            this.SuspendLayout();
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
            this.button2.TabIndex = 62;
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
            this.button27.TabIndex = 61;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(548, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 54);
            this.label2.TabIndex = 63;
            this.label2.Text = "View Customer Feedback";
            // 
            // cuscartviewdb
            // 
            this.cuscartviewdb.AutoGenerateColumns = false;
            this.cuscartviewdb.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cuscartviewdb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cuscartviewdb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.cuscartviewdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuscartviewdb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userfeedDataGridViewTextBoxColumn});
            this.cuscartviewdb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuscartviewdb.DataSource = this.tblfeedBindingSource;
            this.cuscartviewdb.Location = new System.Drawing.Point(338, 171);
            this.cuscartviewdb.Name = "cuscartviewdb";
            this.cuscartviewdb.ReadOnly = true;
            this.cuscartviewdb.RowHeadersWidth = 51;
            this.cuscartviewdb.RowTemplate.Height = 24;
            this.cuscartviewdb.Size = new System.Drawing.Size(896, 464);
            this.cuscartviewdb.TabIndex = 68;
            this.cuscartviewdb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuscartviewdb_CellContentClick);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "Id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userfeedDataGridViewTextBoxColumn
            // 
            this.userfeedDataGridViewTextBoxColumn.DataPropertyName = "userfeed";
            this.userfeedDataGridViewTextBoxColumn.HeaderText = "FeedBack";
            this.userfeedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userfeedDataGridViewTextBoxColumn.Name = "userfeedDataGridViewTextBoxColumn";
            this.userfeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.userfeedDataGridViewTextBoxColumn.Width = 300;
            // 
            // tblfeedBindingSource
            // 
            this.tblfeedBindingSource.DataMember = "tblfeed";
            this.tblfeedBindingSource.DataSource = this.usersDBFeedAppData;
            // 
            // usersDBFeedAppData
            // 
            this.usersDBFeedAppData.DataSetName = "UsersDBFeedAppData";
            this.usersDBFeedAppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblfeedTableAdapter
            // 
            this.tblfeedTableAdapter.ClearBeforeFill = true;
            // 
            // AdminviewCusFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 728);
            this.Controls.Add(this.cuscartviewdb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button27);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminviewCusFeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewCusFeed";
            this.Load += new System.EventHandler(this.viewCusFeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuscartviewdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBFeedAppData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView cuscartviewdb;
        private UsersDBFeedAppData usersDBFeedAppData;
        private System.Windows.Forms.BindingSource tblfeedBindingSource;
        private UsersDBFeedAppDataTableAdapters.tblfeedTableAdapter tblfeedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userfeedDataGridViewTextBoxColumn;
    }
}