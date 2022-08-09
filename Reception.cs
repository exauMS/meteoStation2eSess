using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace testAlarm
{
    class Reception
    {
        internal static void ReceptionHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            byte[] ByteArray = new byte[sp.BytesToRead];

            sp.Read(ByteArray, 0, sp.BytesToRead);

            for (int i = 0; i < ByteArray.Length; i++) Data.Collections.DataStorage.Enqueue(ByteArray[i]);
        }
    }
}
