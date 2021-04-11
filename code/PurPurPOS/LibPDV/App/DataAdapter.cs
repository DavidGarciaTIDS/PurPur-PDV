using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBD;

namespace LibPDV.App
{
    public class DataAdapter
    {
        public string Name { get; set; }
        public Types FieldType { get; set; }
        public object Value { get; set; }

        public DataAdapter(DataCollection data) 
        {
            this.Name = data.Name;
            this.FieldType = data.FieldType;
            this.Value = data.Value;
        }
    }


}
