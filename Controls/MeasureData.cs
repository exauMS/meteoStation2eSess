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
    public sealed partial class MeasureData : UserControl
    {
        private static MeasureData instance = null;
        private static readonly object padlock = new object();
        public MeasureData()
        {
          
            InitializeComponent();
            grid_measure_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_measure_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        
        public static MeasureData GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new MeasureData();
                    return instance;
                }
            }
        }

        public void SetComboBoxConfigIdMeasure(object item)
        {
            comboBox_configId_measure.Items.Add(item);
        }

       

        private void bt_configId_measure_Click(object sender, EventArgs e)
        {
            Data.Collections.ConfigMeasureIdDict.Add(comboBox_configId_measure.SelectedItem, new List<int> { (int)numericUD_valMin_measure.Value, (int)numericUD_valMax_measure.Value });
            AlarmData.GetInstance.SetComboBoxConfigIdAlarm(comboBox_configId_measure.SelectedItem);
            DataRow dr = Tables.DataFromRawData.Select($"ID={comboBox_configId_measure.SelectedItem}").FirstOrDefault();
            if (dr != null)
            {
                dr["ConfigStatus"] = "done";
                dr["Data"] = 0;
                //dr.
            }
            comboBox_configId_measure.Items.Remove(comboBox_configId_measure.SelectedItem);
           
        }

        public DataGridView getGrid()
        {
            return grid_measure_data;
        }

        
    }
}
