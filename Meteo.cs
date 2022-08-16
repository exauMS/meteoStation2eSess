using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testAlarm.Controls;

namespace testAlarm
{
    public partial class Meteo : Form
    {
        
        private Controls.RawData rawDataPage;
        private Controls.MeasureData measureDataPage;
        private Controls.AlarmData alarmDataPage;
        private Controls.Login loginDataPage;


        public Meteo()
        {
            InitializeComponent();
            this.rawDataPage = RawData.GetInstance;
            this.measureDataPage = MeasureData.GetInstance;
            this.alarmDataPage = AlarmData.GetInstance;
            this.loginDataPage = Login.GetInstance;


            SerialPort.DataReceived += new SerialDataReceivedEventHandler(Reception.ReceptionHandler);

            // raw data
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Serial);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Type);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Data);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.CheckSum);

            // measure data
            Data.Tables.DataFromRawData.Columns.Add(Data.Tables.ColumnsMeasure.ID);
            Data.Tables.DataFromRawData.Columns.Add(Data.Tables.ColumnsMeasure.ConfigStatus);
            Data.Tables.DataFromRawData.Columns.Add(Data.Tables.ColumnsMeasure.Type);
            Data.Tables.DataFromRawData.Columns.Add(Data.Tables.ColumnsMeasure.Data);
            Data.Tables.DataFromRawData.Columns.Add(Data.Tables.ColumnsMeasure.LastUpdate);
            Data.Tables.DataFromRawData.Columns.Add(Data.Tables.ColumnsMeasure.Alarm);

            // alarm data
            Data.Tables.DataFromMeasureData.Columns.Add(Data.Tables.ColumnsAlarm.ID);
            Data.Tables.DataFromMeasureData.Columns.Add(Data.Tables.ColumnsAlarm.Type);
            Data.Tables.DataFromMeasureData.Columns.Add(Data.Tables.ColumnsAlarm.CriticalMin);
            Data.Tables.DataFromMeasureData.Columns.Add(Data.Tables.ColumnsAlarm.WarningMin);
            Data.Tables.DataFromMeasureData.Columns.Add(Data.Tables.ColumnsAlarm.WarningMax);
            Data.Tables.DataFromMeasureData.Columns.Add(Data.Tables.ColumnsAlarm.CriticalMax);
            Data.Tables.DataFromMeasureData.Columns.Add(Data.Tables.ColumnsAlarm.Status);














            /* dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;*/



        }



        private void bt_connexion_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Open();
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (SerialPort.IsOpen)
            {
                bt_connexion.Text = "open";
                bt_connexion.BackColor = Color.LightGreen;
                bt_stop.BackColor = Color.Salmon;
            }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (!SerialPort.IsOpen)
            {
                bt_connexion.Text = "connexion";
                bt_connexion.BackColor = Color.Transparent;
                bt_stop.BackColor = Color.Transparent;
            }
        }

        private void bt_raw_data_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(rawDataPage);
        }

        private void bt_measure_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(measureDataPage);
        }

        private void bt_alarm_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(alarmDataPage);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Treatment.DataTreatment(Data.Tables.DataFromSensor, rawDataPage.getGrid());
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(loginDataPage);
        }
    }
}
