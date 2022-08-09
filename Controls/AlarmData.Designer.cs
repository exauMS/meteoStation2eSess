
namespace testAlarm.Controls
{
    partial class AlarmData
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
            this.panelConfigAlarm = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.numericUpDownTempsObsolete = new System.Windows.Forms.NumericUpDown();
            this.lb_obsolete = new System.Windows.Forms.Label();
            this.numericUpDownWMin = new System.Windows.Forms.NumericUpDown();
            this.lbWmin = new System.Windows.Forms.Label();
            this.numericUpDownCMin = new System.Windows.Forms.NumericUpDown();
            this.lbCmin = new System.Windows.Forms.Label();
            this.numericUpDownWMax = new System.Windows.Forms.NumericUpDown();
            this.lbWmax = new System.Windows.Forms.Label();
            this.numericUpDownCMax = new System.Windows.Forms.NumericUpDown();
            this.lbCmax = new System.Windows.Forms.Label();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.grid_alarm_data = new System.Windows.Forms.DataGridView();
            this.panelConfigAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempsObsolete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alarm_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConfigAlarm
            // 
            this.panelConfigAlarm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelConfigAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelConfigAlarm.Controls.Add(this.btnValider);
            this.panelConfigAlarm.Controls.Add(this.numericUpDownTempsObsolete);
            this.panelConfigAlarm.Controls.Add(this.lb_obsolete);
            this.panelConfigAlarm.Controls.Add(this.numericUpDownWMin);
            this.panelConfigAlarm.Controls.Add(this.lbWmin);
            this.panelConfigAlarm.Controls.Add(this.numericUpDownCMin);
            this.panelConfigAlarm.Controls.Add(this.lbCmin);
            this.panelConfigAlarm.Controls.Add(this.numericUpDownWMax);
            this.panelConfigAlarm.Controls.Add(this.lbWmax);
            this.panelConfigAlarm.Controls.Add(this.numericUpDownCMax);
            this.panelConfigAlarm.Controls.Add(this.lbCmax);
            this.panelConfigAlarm.Controls.Add(this.comboBoxId);
            this.panelConfigAlarm.Controls.Add(this.lb_id);
            this.panelConfigAlarm.Location = new System.Drawing.Point(542, 23);
            this.panelConfigAlarm.Name = "panelConfigAlarm";
            this.panelConfigAlarm.Size = new System.Drawing.Size(221, 292);
            this.panelConfigAlarm.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Location = new System.Drawing.Point(3, 266);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(211, 19);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // numericUpDownTempsObsolete
            // 
            this.numericUpDownTempsObsolete.Location = new System.Drawing.Point(3, 210);
            this.numericUpDownTempsObsolete.Name = "numericUpDownTempsObsolete";
            this.numericUpDownTempsObsolete.Size = new System.Drawing.Size(215, 20);
            this.numericUpDownTempsObsolete.TabIndex = 11;
            // 
            // lb_obsolete
            // 
            this.lb_obsolete.AutoSize = true;
            this.lb_obsolete.BackColor = System.Drawing.Color.Gray;
            this.lb_obsolete.Location = new System.Drawing.Point(42, 197);
            this.lb_obsolete.Name = "lb_obsolete";
            this.lb_obsolete.Size = new System.Drawing.Size(119, 13);
            this.lb_obsolete.TabIndex = 10;
            this.lb_obsolete.Text = "Temps max  (secondes)";
            // 
            // numericUpDownWMin
            // 
            this.numericUpDownWMin.Location = new System.Drawing.Point(3, 174);
            this.numericUpDownWMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownWMin.Name = "numericUpDownWMin";
            this.numericUpDownWMin.Size = new System.Drawing.Size(215, 20);
            this.numericUpDownWMin.TabIndex = 9;
            // 
            // lbWmin
            // 
            this.lbWmin.AutoSize = true;
            this.lbWmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbWmin.Location = new System.Drawing.Point(69, 158);
            this.lbWmin.Name = "lbWmin";
            this.lbWmin.Size = new System.Drawing.Size(73, 13);
            this.lbWmin.TabIndex = 8;
            this.lbWmin.Text = "Warning Min :";
            // 
            // numericUpDownCMin
            // 
            this.numericUpDownCMin.Location = new System.Drawing.Point(3, 135);
            this.numericUpDownCMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownCMin.Name = "numericUpDownCMin";
            this.numericUpDownCMin.Size = new System.Drawing.Size(215, 20);
            this.numericUpDownCMin.TabIndex = 7;
            // 
            // lbCmin
            // 
            this.lbCmin.AutoSize = true;
            this.lbCmin.BackColor = System.Drawing.Color.Red;
            this.lbCmin.Location = new System.Drawing.Point(69, 119);
            this.lbCmin.Name = "lbCmin";
            this.lbCmin.Size = new System.Drawing.Size(64, 13);
            this.lbCmin.TabIndex = 6;
            this.lbCmin.Text = "Critical Min :";
            // 
            // numericUpDownWMax
            // 
            this.numericUpDownWMax.Location = new System.Drawing.Point(3, 96);
            this.numericUpDownWMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownWMax.Name = "numericUpDownWMax";
            this.numericUpDownWMax.Size = new System.Drawing.Size(215, 20);
            this.numericUpDownWMax.TabIndex = 5;
            // 
            // lbWmax
            // 
            this.lbWmax.AutoSize = true;
            this.lbWmax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbWmax.Location = new System.Drawing.Point(69, 79);
            this.lbWmax.Name = "lbWmax";
            this.lbWmax.Size = new System.Drawing.Size(76, 13);
            this.lbWmax.TabIndex = 4;
            this.lbWmax.Text = "Warning Max :";
            // 
            // numericUpDownCMax
            // 
            this.numericUpDownCMax.Location = new System.Drawing.Point(3, 56);
            this.numericUpDownCMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownCMax.Name = "numericUpDownCMax";
            this.numericUpDownCMax.Size = new System.Drawing.Size(215, 20);
            this.numericUpDownCMax.TabIndex = 3;
            // 
            // lbCmax
            // 
            this.lbCmax.AutoSize = true;
            this.lbCmax.BackColor = System.Drawing.Color.Red;
            this.lbCmax.Location = new System.Drawing.Point(69, 40);
            this.lbCmax.Name = "lbCmax";
            this.lbCmax.Size = new System.Drawing.Size(67, 13);
            this.lbCmax.TabIndex = 2;
            this.lbCmax.Text = "Critical Max :";
            // 
            // comboBoxId
            // 
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(3, 16);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(215, 21);
            this.comboBoxId.TabIndex = 1;
            this.comboBoxId.SelectedValueChanged += new System.EventHandler(this.comboBoxId_SelectedValueChanged);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(30, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(158, 13);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "Sélectionner un Id à configurer :";
            // 
            // grid_alarm_data
            // 
            this.grid_alarm_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alarm_data.Location = new System.Drawing.Point(3, 23);
            this.grid_alarm_data.Name = "grid_alarm_data";
            this.grid_alarm_data.RowHeadersVisible = false;
            this.grid_alarm_data.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_alarm_data.Size = new System.Drawing.Size(533, 292);
            this.grid_alarm_data.TabIndex = 4;
            // 
            // AlarmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_alarm_data);
            this.Controls.Add(this.panelConfigAlarm);
            this.Name = "AlarmData";
            this.Size = new System.Drawing.Size(776, 338);
            this.panelConfigAlarm.ResumeLayout(false);
            this.panelConfigAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempsObsolete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alarm_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfigAlarm;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.NumericUpDown numericUpDownTempsObsolete;
        private System.Windows.Forms.Label lb_obsolete;
        private System.Windows.Forms.NumericUpDown numericUpDownWMin;
        private System.Windows.Forms.Label lbWmin;
        private System.Windows.Forms.NumericUpDown numericUpDownCMin;
        private System.Windows.Forms.Label lbCmin;
        private System.Windows.Forms.NumericUpDown numericUpDownWMax;
        private System.Windows.Forms.Label lbWmax;
        private System.Windows.Forms.NumericUpDown numericUpDownCMax;
        private System.Windows.Forms.Label lbCmax;
        private System.Windows.Forms.ComboBox comboBoxId;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.DataGridView grid_alarm_data;
    }
}
