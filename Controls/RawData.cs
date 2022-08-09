using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAlarm.Controls
{
    public sealed partial class RawData : UserControl
    {
        private static RawData instance = null;
        private static readonly object padlock = new object();
        public RawData()
        {
            InitializeComponent();
            grid_raw_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_raw_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public static RawData GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new RawData();
                    return instance;
                }
            }
        }

        public DataGridView getGrid()
        {
            return grid_raw_data;
        }
    }
}
