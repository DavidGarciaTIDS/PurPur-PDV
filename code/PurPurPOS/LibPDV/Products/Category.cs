using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibPDV.App;

namespace LibPDV.Products
{
    public class Category : CRUD
    {
        public int catId;
        public List<string> Subcategories = new List<string>();

        public Category() : base("categories", new List<string>() {"id","name", "description"})
        {
            
        
        }

    }
}
