using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAlarm
{
    class Measure
    {
        private byte id;
        private byte typeValue;
        private string type;
        private string configStatus;
        private ushort data;

        public byte Id { get => id; set => id = value; }
        public byte TypeValue { get => typeValue; set => typeValue = value; }
        public string ConfigStatus { get => configStatus; set => configStatus = value; }
        public ushort Data { set => data = value; }

        public string Type() 
        {
            if (typeValue == 0)
                type = "CO2";
            else if (typeValue == 1)
                type = "Humidité";
            else
                type = "Température";
            return type;
        }

        public short GetData() 
        {
            return 0;
        }

        public Measure(byte id, byte typeValue, ushort data) 
        {
            this.Id = id;
            this.TypeValue = typeValue;
            this.Data = data;
            this.configStatus = "Not done";
        }

        public Measure() 
        {
            ConfigStatus = "not done";        
        }



    }
}
