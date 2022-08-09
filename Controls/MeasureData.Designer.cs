
namespace testAlarm.Controls
{
    partial class MeasureData
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
            this.panel_configId_measure = new System.Windows.Forms.Panel();
            this.lb_valMax_measure = new System.Windows.Forms.Label();
            this.lb_valMin_measure = new System.Windows.Forms.Label();
            this.numericUD_valMax_measure = new System.Windows.Forms.NumericUpDown();
            this.numericUD_valMin_measure = new System.Windows.Forms.NumericUpDown();
            this.bt_configId_measure = new System.Windows.Forms.Button();
            this.label_configId = new System.Windows.Forms.Label();
            this.comboBox_configId_measure = new System.Windows.Forms.ComboBox();
            this.grid_measure_data = new System.Windows.Forms.DataGridView();
            this.panel_configId_measure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_valMax_measure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_valMin_measure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_measure_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_configId_measure
            // 
            this.panel_configId_measure.Controls.Add(this.lb_valMax_measure);
            this.panel_configId_measure.Controls.Add(this.lb_valMin_measure);
            this.panel_configId_measure.Controls.Add(this.numericUD_valMax_measure);
            this.panel_configId_measure.Controls.Add(this.numericUD_valMin_measure);
            this.panel_configId_measure.Controls.Add(this.bt_configId_measure);
            this.panel_configId_measure.Controls.Add(this.label_configId);
            this.panel_configId_measure.Controls.Add(this.comboBox_configId_measure);
            this.panel_configId_measure.Location = new System.Drawing.Point(542, 23);
            this.panel_configId_measure.Name = "panel_configId_measure";
            this.panel_configId_measure.Size = new System.Drawing.Size(231, 292);
            this.panel_configId_measure.TabIndex = 2;
            // 
            // lb_valMax_measure
            // 
            this.lb_valMax_measure.AutoSize = true;
            this.lb_valMax_measure.Location = new System.Drawing.Point(71, 139);
            this.lb_valMax_measure.Name = "lb_valMax_measure";
            this.lb_valMax_measure.Size = new System.Drawing.Size(66, 13);
            this.lb_valMax_measure.TabIndex = 7;
            this.lb_valMax_measure.Text = "Valeur Max :";
            // 
            // lb_valMin_measure
            // 
            this.lb_valMin_measure.AutoSize = true;
            this.lb_valMin_measure.Location = new System.Drawing.Point(74, 56);
            this.lb_valMin_measure.Name = "lb_valMin_measure";
            this.lb_valMin_measure.Size = new System.Drawing.Size(63, 13);
            this.lb_valMin_measure.TabIndex = 6;
            this.lb_valMin_measure.Text = "Valeur Min :";
            // 
            // numericUD_valMax_measure
            // 
            this.numericUD_valMax_measure.Location = new System.Drawing.Point(3, 155);
            this.numericUD_valMax_measure.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUD_valMax_measure.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUD_valMax_measure.Name = "numericUD_valMax_measure";
            this.numericUD_valMax_measure.Size = new System.Drawing.Size(225, 20);
            this.numericUD_valMax_measure.TabIndex = 5;
            // 
            // numericUD_valMin_measure
            // 
            this.numericUD_valMin_measure.Location = new System.Drawing.Point(3, 72);
            this.numericUD_valMin_measure.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUD_valMin_measure.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUD_valMin_measure.Name = "numericUD_valMin_measure";
            this.numericUD_valMin_measure.Size = new System.Drawing.Size(225, 20);
            this.numericUD_valMin_measure.TabIndex = 4;
            // 
            // bt_configId_measure
            // 
            this.bt_configId_measure.Location = new System.Drawing.Point(3, 266);
            this.bt_configId_measure.Name = "bt_configId_measure";
            this.bt_configId_measure.Size = new System.Drawing.Size(225, 23);
            this.bt_configId_measure.TabIndex = 3;
            this.bt_configId_measure.Text = "Configurer";
            this.bt_configId_measure.UseVisualStyleBackColor = true;
            this.bt_configId_measure.Click += new System.EventHandler(this.bt_configId_measure_Click);
            // 
            // label_configId
            // 
            this.label_configId.AutoSize = true;
            this.label_configId.Location = new System.Drawing.Point(74, 0);
            this.label_configId.Name = "label_configId";
            this.label_configId.Size = new System.Drawing.Size(72, 13);
            this.label_configId.TabIndex = 2;
            this.label_configId.Text = "Configurer id :";
            // 
            // comboBox_configId_measure
            // 
            this.comboBox_configId_measure.FormattingEnabled = true;
            this.comboBox_configId_measure.Location = new System.Drawing.Point(0, 26);
            this.comboBox_configId_measure.Name = "comboBox_configId_measure";
            this.comboBox_configId_measure.Size = new System.Drawing.Size(228, 21);
            this.comboBox_configId_measure.TabIndex = 0;
            // 
            // grid_measure_data
            // 
            this.grid_measure_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_measure_data.Location = new System.Drawing.Point(3, 23);
            this.grid_measure_data.Name = "grid_measure_data";
            this.grid_measure_data.RowHeadersVisible = false;
            this.grid_measure_data.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_measure_data.Size = new System.Drawing.Size(533, 292);
            this.grid_measure_data.TabIndex = 5;
            // 
            // MeasureData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_measure_data);
            this.Controls.Add(this.panel_configId_measure);
            this.Name = "MeasureData";
            this.Size = new System.Drawing.Size(776, 338);
            this.panel_configId_measure.ResumeLayout(false);
            this.panel_configId_measure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_valMax_measure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_valMin_measure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_measure_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_configId_measure;
        private System.Windows.Forms.Button bt_configId_measure;
        private System.Windows.Forms.Label label_configId;
        private System.Windows.Forms.ComboBox comboBox_configId_measure;
        private System.Windows.Forms.DataGridView grid_measure_data;
        private System.Windows.Forms.Label lb_valMax_measure;
        private System.Windows.Forms.Label lb_valMin_measure;
        private System.Windows.Forms.NumericUpDown numericUD_valMax_measure;
        private System.Windows.Forms.NumericUpDown numericUD_valMin_measure;
    }
}
