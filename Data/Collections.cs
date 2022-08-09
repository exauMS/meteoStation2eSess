using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAlarm.Data
{
    class Collections
    {
        private static Queue<byte> dataStorage = new Queue<byte>();
        private static ArrayList dataObjectList = new ArrayList();
        private static ArrayList idList = new ArrayList();
        private static ArrayList configMeasureIdList = new ArrayList();
        private static Dictionary<object, List<int>> configMeasureIdDict = new Dictionary<object, List<int>>(); //id + min max values in a list
        private static ArrayList measureList = new ArrayList();

        public static Queue<Byte> DataStorage
        {
            get { return dataStorage; }
        }

        public static ArrayList DataObjectList
        {
            get { return dataObjectList; }
        }

        public static ArrayList ConfigMeasureIdList
        {
            get { return configMeasureIdList; }
        }

        public static Dictionary<object, List<int>> ConfigMeasureIdDict
        {
            get { return configMeasureIdDict; }
        }

        public static ArrayList IdList
        {
            get { return idList; }
        }

        public static ArrayList MeasureList
        {
            get { return measureList; }
        }


    }
}
