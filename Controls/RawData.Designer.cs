
namespace testAlarm.Controls
{
    partial class RawData
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
            this.grid_raw_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_raw_data)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_raw_data
            // 
            this.grid_raw_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_raw_data.Location = new System.Drawing.Point(19, 18);
            this.grid_raw_data.Name = "grid_raw_data";
            this.grid_raw_data.RowHeadersVisible = false;
            this.grid_raw_data.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_raw_data.Size = new System.Drawing.Size(733, 292);
            this.grid_raw_data.TabIndex = 0;
            // 
            // RawData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_raw_data);
            this.Name = "RawData";
            this.Size = new System.Drawing.Size(776, 338);
            ((System.ComponentModel.ISupportInitialize)(this.grid_raw_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_raw_data;
    }
}
