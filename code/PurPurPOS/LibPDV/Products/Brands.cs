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
        DataAdapter adap = new DataAdapter();
        List<DataCollection> data;
        

        public Brands() : base("brands", new List<string>() { "name", "description", "logo" })
        {
        }

        public string[] Index(string ColumNameOrder, bool truDesc)
        {
            //bool res = true;
            List<string> list;
            OrderBy order;
            if (truDesc)
                order = new OrderBy(ColumNameOrder, Order.DESC);
            else
                order = new OrderBy(ColumNameOrder, Order.ASC);

            list=adap.DataColToList(base.index(order),"name");

            return list.ToArray();
        }
    }
}
