using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testAlarm.Controls;
using testAlarm.Data;

namespace testAlarm
{
    class Treatment
    {
        public static void DataTreatment(DataTable dt, DataGridView dg)
        {
            Base obj = new Base();

            while ((Data.Collections.DataStorage.Count > 2) &&
                  (Data.Collections.DataStorage.ElementAt(0) != 0x55) ||
                  (Data.Collections.DataStorage.ElementAt(1) != 0x55) ||
                  (Data.Collections.DataStorage.ElementAt(2) != 0xAA)
                ) Data.Collections.DataStorage.Dequeue();
            int BytesNbr = Data.Collections.DataStorage.Count;    // Fix value to avoid changes in for loop

            for (int i = 0; i < BytesNbr; i++)
            {

                if (Data.Collections.DataStorage.Count > 12)
                {
                    //on evite la trame de debut
                    for (int j = 0; j < 3; j++)
                    {
                        Data.Collections.DataStorage.Dequeue();
                    }

                    obj.Serial = Data.Collections.DataStorage.Dequeue();
                    obj.Serial <<= 8;
                    obj.Serial += Data.Collections.DataStorage.Dequeue();

                    obj.Id = Data.Collections.DataStorage.Dequeue();
                    obj.Type = Data.Collections.DataStorage.Dequeue();

                    obj.Data = Data.Collections.DataStorage.Dequeue();
                    obj.Data <<= 8;
                    obj.Data += Data.Collections.DataStorage.Dequeue();


                    obj.CheckSum = Data.Collections.DataStorage.Dequeue();

                    //on evite la trame de fin
                    for (int j = 0; j < 3; j++)
                    {
                        Data.Collections.DataStorage.Dequeue();
                    }
                }
            }
            ObjToList(obj, dt, dg);
        }

        private static void ObjToList(Base obj, DataTable dt, DataGridView dg)
        {
            bool hasSameId = false;

            if (Data.Collections.DataObjectList.Count >= 1)//si la liste contient au moins 1 element
            {
                //si l'id existe deja on met a jour les donnees
                DataRow dr = dt.Select($"ID={obj.Id}").FirstOrDefault();
                if (dr != null)
                {
                    hasSameId = true;
                    dr["Data"] = obj.Data;
                    dr["CheckSum"] = obj.CheckSum;
                }
            }
           
            if (!Data.Collections.IdList.Contains(obj.Id))
            {
                Data.Collections.DataObjectList.Add(obj);
                Data.Collections.IdList.Add(obj.Id);

                //mésure
                MeasureData.GetInstance.SetComboBoxConfigIdMeasure(obj.Id);
                Measure obj_measure = new Measure(obj.Id, obj.Type, obj.Data);
                Tables.DataFromRawData.Rows.Add(new object[] {obj_measure.Id, obj_measure.ConfigStatus, obj_measure.Type(), "-","-","-" });
                Data.Collections.MeasureList.Add(obj_measure);
                MeasureData.GetInstance.getGrid().DataSource = Tables.DataFromRawData;


              
            }
            else if(Data.Collections.IdList.Contains(obj.Id) && Data.Collections.ConfigMeasureIdDict.ContainsKey(obj.Id))//si id configure
            {
                DataRow dr = Tables.DataFromRawData.Select($"ID={obj.Id}").FirstOrDefault();
                if (dr != null)
                {
                    List<int> minMax = Data.Collections.ConfigMeasureIdDict[obj.Id];
                    
                 
                    dr["Data"] = Math.Round((obj.Data/65535.0)*((minMax[1]+minMax[0])-minMax[0]), 2); //2 decimal apres la virgule (math.round)
                   
                }
            }

            //On ajoute une ligne si l'id est nouveau
            if (hasSameId == false)
            {
                dt.Rows.Add(new object[] { obj.Serial, obj.Id, obj.Type, obj.Data, obj.CheckSum });
                dg.DataSource = dt;
            }
        }
    }
}
