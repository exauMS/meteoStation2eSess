
namespace testAlarm
{
    partial class Meteo
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.bt_connexion = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.bt_raw_data = new System.Windows.Forms.Button();
            this.bt_measure = new System.Windows.Forms.Button();
            this.bt_alarm = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BtLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM2";
            // 
            // bt_connexion
            // 
            this.bt_connexion.Location = new System.Drawing.Point(301, 498);
            this.bt_connexion.Margin = new System.Windows.Forms.Padding(4);
            this.bt_connexion.Name = "bt_connexion";
            this.bt_connexion.Size = new System.Drawing.Size(100, 28);
            this.bt_connexion.TabIndex = 2;
            this.bt_connexion.Text = "connexion";
            this.bt_connexion.UseVisualStyleBackColor = true;
            this.bt_connexion.Click += new System.EventHandler(this.bt_connexion_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(621, 498);
            this.bt_stop.Margin = new System.Windows.Forms.Padding(4);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(100, 28);
            this.bt_stop.TabIndex = 3;
            this.bt_stop.Text = "stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // panel_container
            // 
            this.panel_container.Location = new System.Drawing.Point(16, 50);
            this.panel_container.Margin = new System.Windows.Forms.Padding(4);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1035, 416);
            this.panel_container.TabIndex = 4;
            // 
            // bt_raw_data
            // 
            this.bt_raw_data.Location = new System.Drawing.Point(16, 15);
            this.bt_raw_data.Margin = new System.Windows.Forms.Padding(4);
            this.bt_raw_data.Name = "bt_raw_data";
            this.bt_raw_data.Size = new System.Drawing.Size(100, 28);
            this.bt_raw_data.TabIndex = 5;
            this.bt_raw_data.Text = "donnée brut";
            this.bt_raw_data.UseVisualStyleBackColor = true;
            this.bt_raw_data.Click += new System.EventHandler(this.bt_raw_data_Click);
            // 
            // bt_measure
            // 
            this.bt_measure.Location = new System.Drawing.Point(124, 15);
            this.bt_measure.Margin = new System.Windows.Forms.Padding(4);
            this.bt_measure.Name = "bt_measure";
            this.bt_measure.Size = new System.Drawing.Size(100, 28);
            this.bt_measure.TabIndex = 6;
            this.bt_measure.Text = "mésure";
            this.bt_measure.UseVisualStyleBackColor = true;
            this.bt_measure.Click += new System.EventHandler(this.bt_measure_Click);
            // 
            // bt_alarm
            // 
            this.bt_alarm.Location = new System.Drawing.Point(232, 15);
            this.bt_alarm.Margin = new System.Windows.Forms.Padding(4);
            this.bt_alarm.Name = "bt_alarm";
            this.bt_alarm.Size = new System.Drawing.Size(100, 28);
            this.bt_alarm.TabIndex = 7;
            this.bt_alarm.Text = "alarme";
            this.bt_alarm.UseVisualStyleBackColor = true;
            this.bt_alarm.Click += new System.EventHandler(this.bt_alarm_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BtLogin
            // 
            this.BtLogin.Location = new System.Drawing.Point(352, 13);
            this.BtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(100, 28);
            this.BtLogin.TabIndex = 8;
            this.BtLogin.Text = "login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // Meteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.bt_alarm);
            this.Controls.Add(this.bt_measure);
            this.Controls.Add(this.bt_raw_data);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_connexion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Meteo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_connexion;
        private System.Windows.Forms.Button bt_stop;
        internal System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Button bt_raw_data;
        private System.Windows.Forms.Button bt_measure;
        private System.Windows.Forms.Button bt_alarm;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BtLogin;
    }
}

