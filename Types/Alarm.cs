using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAlarm
{
    class Alarm
    {
        private string type, status;
        private object cmin,cmax,wmin,wmax;
        private static int count = 0;
        private int id;
        public Alarm(string type, object criticalMin, object criticalMax, object warningMin, object warningMax, string status) 
        {
            id += ++count;
            this.type = type;
            cmin = criticalMin;
            cmax = criticalMax;
            wmin = warningMin;
            wmax = warningMax;
            this.status = status;
        }

        public int Id
        {
            get { return id; }
        }
        public string Type 
        {
            get { return type; }
        }

        public object Cmin
        {
            get { return cmin; }
        }

        public object Cmax
        {
            get { return cmax; }
        }

        public object Wmin
        {
            get { return wmin; }
        }

        public object Wmax
        {
            get { return wmax; }
        }

        public string Status
        {
            get { return status; }
        }

    }
}
