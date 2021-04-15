using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibPDV.App;

namespace LibPDV.Products
{
    class Subcategory : CRUD
    {

        public Subcategory() : base("subcategories", new List<string>() { "id", "name", "description","category_id" })
        {


        }
    }
}
