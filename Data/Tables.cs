using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAlarm.Data
{
    class Tables
    {
        private static DataTable dataFromSensor = new DataTable();
        private static DataTable dataFromRawData = new DataTable();
        private static DataTable dataFromMeasureData = new DataTable();

        public static DataTable DataFromSensor
        {
            get { return dataFromSensor; }
        }

        public static DataTable DataFromRawData
        {
            get { return dataFromRawData; }
        }

        public static DataTable DataFromMeasureData
        {
            get { return dataFromMeasureData; }
        }
        internal class Columns
        {
            //columns raw data
            internal static DataColumn Serial = new DataColumn("Serial");
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn Data = new DataColumn("Data");
            internal static DataColumn CheckSum = new DataColumn("CheckSum");
        }

        internal class ColumnsMeasure 
        {
            //columns measure data
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn ConfigStatus = new DataColumn("ConfigStatus");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn Data = new DataColumn("Data");
            internal static DataColumn LastUpdate = new DataColumn("LastUpdate");
            internal static DataColumn Alarm = new DataColumn("Alarm");
        }

        internal class ColumnsAlarm 
        {
            //columns alarm data
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn CriticalMin = new DataColumn("CriticalMin");
            internal static DataColumn WarningMin = new DataColumn("WarningMin");
            internal static DataColumn WarningMax = new DataColumn("WarningMax");
            internal static DataColumn CriticalMax = new DataColumn("CriticalMax");
            internal static DataColumn Status = new DataColumn("Status");
        }
    }
}
