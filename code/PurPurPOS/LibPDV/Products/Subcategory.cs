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

        public Subcategory() : base("subcategories", new List<string>() { "id", "name", "description","category_id" })
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


    }
}
