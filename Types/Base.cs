using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAlarm
{
    class Base
    {
         byte id;
         byte type;
         short serial;
         ushort data;
         uint checkSum;

        public Base(short serial, byte id, byte type, ushort data, uint checkSum)
        {
            this.Serial = serial;
            this.Id = id;
            this.Type = type;
            this.Data = data;
            this.CheckSum = checkSum;
        }

        public Base() { }

        
        

        public byte Id { get => id; set => id = value; }
        public byte Type { get => type; set => type = value; }
        public short Serial { get => serial; set => serial = value; }
        public ushort Data { get => data; set => data = value; }
        public uint CheckSum { get => checkSum; set => checkSum = value; }
    }
}
