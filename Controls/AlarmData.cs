using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testAlarm.Data;

namespace testAlarm.Controls
{
    public sealed partial class AlarmData : UserControl
    {
        private static AlarmData instance = null;
        private static readonly object padlock = new object();
        public AlarmData()
        {
            InitializeComponent();
            grid_alarm_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_alarm_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        // Singleton
        public static AlarmData GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new AlarmData();
                    return instance;
                }
            }
        }

        public DataGridView getGrid()
        {
            return grid_alarm_data;
        }

        public void SetComboBoxConfigIdAlarm(object item)
        {
            comboBoxId.Items.Add(item);
        }

        private void comboBoxId_SelectedValueChanged(object sender, EventArgs e)
        {
            List<int> list = Data.Collections.ConfigMeasureIdDict[comboBoxId.SelectedItem];
            numericUpDownCMin.Value = list[0];
            numericUpDownCMax.Value = list[1];


        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            List<int> list = Data.Collections.ConfigMeasureIdDict[comboBoxId.SelectedItem];
            //Checking
            if ((numericUpDownCMax.Value <= list[1] && numericUpDownCMax.Value > list[0]) &&
                (numericUpDownCMin.Value < list[1] && numericUpDownCMin.Value >= list[0]) &&
                (numericUpDownWMax.Value < numericUpDownCMax.Value && numericUpDownWMax.Value > numericUpDownCMin.Value && numericUpDownWMax.Value > numericUpDownWMin.Value) &&
                (numericUpDownWMin.Value > numericUpDownCMin.Value))
            {
                Tables.DataFromMeasureData.Rows.Add(new object[] { comboBoxId.SelectedItem, "-", numericUpDownCMin.Value, numericUpDownWMin.Value, numericUpDownWMax.Value, numericUpDownCMax.Value, "-" });
                getGrid().DataSource = Tables.DataFromMeasureData;
                comboBoxId.Items.Remove(comboBoxId.SelectedItem);
            }
            else
            {
                MessageBox.Show("Erreur Configuration");
            }
        }
    }
}
