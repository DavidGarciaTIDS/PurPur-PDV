using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBD;
using LibPDV.App;

namespace LibPDV.Products
{
    public class Subcategory : CRUD
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int catId { get; set; }
        public string catName { get; set; }
        public static List<Category> Categories = new List<Category>();
        List<DataCollection> data;

        private Category category = new Category();
        public Subcategory() : base("subcategories", new List<string>() { "id", "name", "description", "category_id" })
        {

        }
        public bool Create(string name, string description, int catID)
        {
            data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("category_id", Types.INT, catID));

            bool res = base.Create(data);

            if (!res)
            {
                this.ERROR = BD.ERROR;
            }
            return res;

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
        public bool Update(int id, string name, string description, int catID)
        {
            data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("cat_id", Types.INT, catID));

            return base.Update(data, id);
        }
        public bool Delete(int id)
        {
            return base.Delete(id);
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
        public void FillCategories(List<Category> CatList)
        {
            Categories = CatList;
        }
        public List<Subcategory> DataToCateList(List<List<DataCollection>> DC)
        {
            List<Subcategory> subcatList = new List<Subcategory>();
            Subcategory subcat = new Subcategory();

            foreach (List<DataCollection> item in DC)
            {
                subcat = new Subcategory();
                foreach (DataCollection data in item)
                {
                    switch (data.Name)
                    {
                        case "id":
                            subcat.id = int.Parse(data.Value.ToString());
                            break;
                        case "name":
                            subcat.name = data.Value.ToString().Replace("'", "");
                            break;
                        case "description":
                            subcat.description = data.Value.ToString().Replace("'", "");
                            break;
                        case "category_id":
                            subcat.catId = int.Parse(data.Value.ToString());
                            subcat.catName = category.CategFromID(Categories, subcat.catId);
                            break;
                        default:
                            break;
                    }
                }
                subcatList.Add(subcat);
            }
            return subcatList;
        }
        public string[] ListToArray(List<Subcategory> list, string property)
        {
            string[] objList = new string[list.Count];
            int i = 0;
            foreach (Subcategory item in list)
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
        public string CategFromSubcatName(List<Subcategory> ListS, string SubcatName)
        {
            string res = "";
            foreach (Subcategory subcateg in ListS)
            {
                if (subcateg.name == $"'{SubcatName}'")
                {
                    res = subcateg.catName.Replace("'", "");
                }
            }
            return res;
        }
        public string SubcategFromID(List<Subcategory> ListS, int id)
        {
            string res = "";

            foreach (Subcategory subcateg in ListS)
            {
                if (subcateg.id == id)
                {
                    res = subcateg.name.Replace("'", "");
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
                case "catname":
                    return "Categoria";

                default:
                    return "";
            }
        }
    }
}
