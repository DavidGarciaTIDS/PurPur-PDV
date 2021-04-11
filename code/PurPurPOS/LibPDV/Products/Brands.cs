using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibPDV.App;
using LibBD;

namespace LibPDV.Products
{
    public class Brands : CRUD
    {
        public string name { get; set; }
        public string description { get; set; }
        public string logo { get; set; }
        List<DataCollection> data;
        

        public Brands() : base("brands", new List<string>() { "name", "description", "logo" })
        {
        }

        public string[] Index(string ColumNameOrder, bool truDesc)
        {
            //bool res = true;
            string[] tabla;
            List<string> list = new List<string>();
            OrderBy order;
            if (truDesc)
                order = new OrderBy(ColumNameOrder, Order.DESC);
            else
                order = new OrderBy(ColumNameOrder, Order.ASC);

            List<List<DataCollection>> listaObj;
            listaObj = base.index(order);
            
            foreach (List<DataCollection> lista in listaObj)
            {
                
                foreach (DataCollection obj in lista)
                {
                    if (obj.Name=="name")
                    {
                     list.Add(obj.Value.ToString().Replace("'", ""));
                    }
                }

            }
            tabla = list.ToArray();
            return tabla;
        }
    }
}
