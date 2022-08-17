namespace testAlarm.Controls
{
    partial class Login
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Name = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Button_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_DBDelete = new System.Windows.Forms.Button();
            this.Button_DBInsert = new System.Windows.Forms.Button();
            this.Button_DBRead = new System.Windows.Forms.Button();
            this.DataGrid_Access = new System.Windows.Forms.DataGridView();
            this.DataGrid_DBUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Access)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_DBUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(435, 19);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(76, 16);
            this.Label_Name.TabIndex = 9;
            this.Label_Name.Text = "UserName:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(550, 19);
            this.TextBox_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(205, 22);
            this.TextBox_Name.TabIndex = 10;
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(589, 45);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(95, 32);
            this.Button_Update.TabIndex = 11;
            this.Button_Update.Text = "DB_Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "=> Database";
            // 
            // Button_DBDelete
            // 
            this.Button_DBDelete.Location = new System.Drawing.Point(203, 72);
            this.Button_DBDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_DBDelete.Name = "Button_DBDelete";
            this.Button_DBDelete.Size = new System.Drawing.Size(91, 32);
            this.Button_DBDelete.TabIndex = 18;
            this.Button_DBDelete.Text = "DB_Delete";
            this.Button_DBDelete.UseVisualStyleBackColor = true;
            this.Button_DBDelete.Click += new System.EventHandler(this.Button_DBDelete_Click);
            // 
            // Button_DBInsert
            // 
            this.Button_DBInsert.Location = new System.Drawing.Point(106, 72);
            this.Button_DBInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_DBInsert.Name = "Button_DBInsert";
            this.Button_DBInsert.Size = new System.Drawing.Size(91, 32);
            this.Button_DBInsert.TabIndex = 17;
            this.Button_DBInsert.Text = "DB_Insert";
            this.Button_DBInsert.UseVisualStyleBackColor = true;
            this.Button_DBInsert.Click += new System.EventHandler(this.Button_DBInsert_Click);
            // 
            // Button_DBRead
            // 
            this.Button_DBRead.Location = new System.Drawing.Point(3, 72);
            this.Button_DBRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_DBRead.Name = "Button_DBRead";
            this.Button_DBRead.Size = new System.Drawing.Size(97, 31);
            this.Button_DBRead.TabIndex = 16;
            this.Button_DBRead.Text = "DB_Reader";
            this.Button_DBRead.UseVisualStyleBackColor = true;
            this.Button_DBRead.Click += new System.EventHandler(this.Button_DBRead_Click);
            // 
            // DataGrid_Access
            // 
            this.DataGrid_Access.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Access.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Access.Location = new System.Drawing.Point(3, 308);
            this.DataGrid_Access.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGrid_Access.Name = "DataGrid_Access";
            this.DataGrid_Access.RowHeadersVisible = false;
            this.DataGrid_Access.RowHeadersWidth = 51;
            this.DataGrid_Access.RowTemplate.Height = 24;
            this.DataGrid_Access.Size = new System.Drawing.Size(1307, 190);
            this.DataGrid_Access.TabIndex = 21;
            // 
            // DataGrid_DBUsers
            // 
            this.DataGrid_DBUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_DBUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_DBUsers.Location = new System.Drawing.Point(3, 108);
            this.DataGrid_DBUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGrid_DBUsers.Name = "DataGrid_DBUsers";
            this.DataGrid_DBUsers.RowHeadersVisible = false;
            this.DataGrid_DBUsers.RowHeadersWidth = 51;
            this.DataGrid_DBUsers.RowTemplate.Height = 24;
            this.DataGrid_DBUsers.Size = new System.Drawing.Size(1307, 155);
            this.DataGrid_DBUsers.TabIndex = 20;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGrid_Access);
            this.Controls.Add(this.DataGrid_DBUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_DBDelete);
            this.Controls.Add(this.Button_DBInsert);
            this.Controls.Add(this.Button_DBRead);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Label_Name);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1422, 610);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Access)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_DBUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_DBDelete;
        private System.Windows.Forms.Button Button_DBInsert;
        private System.Windows.Forms.Button Button_DBRead;
        private System.Windows.Forms.DataGridView DataGrid_Access;
        internal System.Windows.Forms.DataGridView DataGrid_DBUsers;
    }
}
