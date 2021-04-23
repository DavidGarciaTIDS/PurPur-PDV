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
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string logo { get; set; }
        DataAdapter adap = new DataAdapter();
        List<DataCollection> data;
        

        public Brands() : base("brands", new List<string>() { "id","name", "description", "logo" })
        {
        }

        public List<List<DataCollection>> Read(List<string> fields, string tabla2, string[] onfields, List<SearchAdapter> search)
        {
            return base.Read(fields, tabla2, new List<string> { }, new List<SearchCollection> { });
        }

        public List<List<DataCollection>> Read(List<string> field, string onfield, List<SearchAdapter> Search)
        {
            List<SearchCollection> searchlist = new List<SearchCollection>();
            foreach (SearchAdapter obj in Search)
            {
                searchlist.Add(obj.adaptToCollect());
            }
            return base.Read(field, searchlist);
        }
        public List<List<DataCollection>> Index(string ColumNameOrder, bool truDesc, List<string> Columns)
        {
            OrderBy order;
            if (truDesc)
                order = new OrderBy(ColumNameOrder, Order.DESC);
            else
                order = new OrderBy(ColumNameOrder, Order.ASC);
            return base.index(order, Columns);
        }
        public string[] ListToArray(List<Brands> list, string property)
        {
            string[] objList = new string[list.Count];
            int i = 0;
            foreach (Brands item in list)
            {
                switch (property)
                {
                    case "id":
                        objList[i] = item.id.ToString();
                        break;
                    case "name":
                        objList[i] = item.name.ToString();
                        break;

                    default:
                        break;
                }
            }

            return objList;
        }
        public List<Brands> DataToBrandList(List<List<DataCollection>> DC)
        {
            List<Brands> brandList = new List<Brands>();
            Brands brand = new Brands();

            foreach (List<DataCollection> item in DC)
            {
                brand = new Brands();
                foreach (DataCollection data in item)
                {
                    switch (data.Name)
                    {
                        case "id":
                            brand.id = int.Parse(data.Value.ToString());
                            break;
                        case "name":
                            brand.name = data.Value.ToString().Replace("'","");
                            break;
                        case "description":
                            brand.description = data.Value.ToString().Replace("'", "");
                            break;
                        case "logo":
                            brand.logo = data.Value.ToString();
                            break;
                        default:
                            break;
                    }
                }
                brandList.Add(brand);
            }
            return brandList;
        }
        public string BrandFromID(List<Brands> ListC, int id)
        {
            string res = "";

            foreach (Brands item in ListC)
            {
                if (item.id == id)
                {
                    res = item.name;
                }
            }

            return res;
        }
    }
}
