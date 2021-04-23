using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibPDV.App;
using LibBD;

namespace LibPDV.Products
{
    public class Category : CRUD
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<string> Subcategories = new List<string>();

        public Category() : base("categories", new List<string>() { "id", "name", "description" })
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



        public string[] ListToArray(List<Category> list, string property)
        {
            string[] objList = new string[list.Count];
            int i = 0;
            foreach (Category item in list)
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


        public List<Category> DataToCateList(List<List<DataCollection>> DC)
        {
            List<Category> CatList = new List<Category>();
            Category category = new Category();

            foreach (List<DataCollection> item in DC)
            {
                category = new Category();
                foreach (DataCollection data in item)
                {
                    switch (data.Name)
                    {
                        case "id":
                            category.id = int.Parse(data.Value.ToString());
                            break;
                        case "name":
                            category.name = data.Value.ToString().Replace("'","");
                            break;
                        case "description":
                            category.description = data.Value.ToString().Replace("'", "");
                            break;
                        default:
                            break;
                    }
                }
                CatList.Add(category);
            }
            return CatList;
        }
        
        public string CategFromID(List<Category> ListC, int id)
        {
            string res="";

            foreach (Category categ in ListC)
            {
                if (categ.id==id)
                {
                   res = categ.name;
                }
            }

            return res;
        }
        public string NameColums(string col)
        {

            switch (col.ToLower())
            {
                case "name":
                    return "Nombre";
                case "id":
                    return "ID";
                case "description":
                    return "Descripción";

                default:
                    return "";
            }
        }
    }
}
