using LibPDV.App;
using LibBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibPDV.Products
{
    public class Products : CRUD
    {

        public Products() : base("products", new List<string>() { "name", "description", "price", "bar_code", "brand_id", "subcategory_id", "image", "measure_unit", "sku" })
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string BarCode { get; set; }
        public int brand { get; set; }
        public string brandName { get; set; }
        public int subcategory { get; set; }
        public string subcategoryName { get; set; }
        public string image { get; set; }
        public MeasureUnits measure_unit { get; set; }
        public string sku { get; set; }
        public static List<Subcategory> Subcategories = new List<Subcategory>();
        public static List<Brands> Brands = new List<Brands>();

        //Privates Variables

        private DataAdapter adapt = new DataAdapter();
        private List<DataCollection> data;
        private SearchAdapter Sadapt = new SearchAdapter();
        private Brands ProdBrands = new Brands();
        private Subcategory ProdSubcat = new Subcategory();

        public bool Create(string name, string description, double price, string barCode, int brandId, int subCategoryId, MeasureUnits measure_unit, string sku)
        {
            data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("price", Types.DOUBLE, price));
            data.Add(new DataCollection("bar_code", Types.INT, barCode));
            data.Add(new DataCollection("brand_Id", Types.INT, brandId));
            data.Add(new DataCollection("subcategory_Id", Types.INT, subCategoryId));
            data.Add(new DataCollection("measure_unit", Types.VARCHAR, measure_unit));
            data.Add(new DataCollection("sku", Types.VARCHAR, sku));
            bool res = base.Create(data);

            if (!res)
            {
                this.ERROR = BD.ERROR;
            }
            return res;

        }
        public List<List<DataCollection>> Read(List<string> fields, string tabla2, List<string> onfields, List<SearchAdapter> search)
        {
            List<SearchCollection> ColList = new List<SearchCollection>();
            foreach (SearchAdapter item in search)
            {
                ColList.Add(item.adaptToCollect());
            }
            return base.Read(fields, tabla2, onfields, ColList);
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
        public bool Update(int id, string name, string description, double price, string barCode, int brandId, int subCategoryId, MeasureUnits measure_unit, string sku)
        {
            data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("price", Types.DOUBLE, price));
            data.Add(new DataCollection("bar_code", Types.INT, barCode));
            data.Add(new DataCollection("brand_Id", Types.INT, brandId));
            data.Add(new DataCollection("subcategory_Id", Types.INT, subCategoryId));
            data.Add(new DataCollection("measure_unit", Types.VARCHAR, measure_unit));
            data.Add(new DataCollection("sku", Types.VARCHAR, sku));


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

        public void FillSubcat(List<Subcategory> SubList) 
        {
            Subcategories = SubList;
        }
        public void FillBrands(List<Brands> BrandList) 
        {
            Brands = BrandList;
        }

        public List<Products> DataToProdList(List<List<DataCollection>> DC)
        {
            List<Products> ProdList = new List<Products>();
            Products prod;

            foreach (List<DataCollection> item in DC)
            {
                prod = new Products();
                foreach (DataCollection data in item)
                {
                    switch (data.Name)
                    {
                        case "id":
                            prod.Id = int.Parse(data.Value.ToString());
                            break;
                        case "name":
                            prod.Name = data.Value.ToString().Replace("'", "");
                            break;
                        case "description":
                            prod.Description = data.Value.ToString().Replace("'", "");
                            break;
                        case "price":
                            prod.Price = Double.Parse(data.Value.ToString().Replace("'",""));
                            break;
                        case "bar_code":
                            prod.BarCode = data.Value.ToString().Replace("'", "");
                            break;
                        case "brand_id":
                            prod.brand = int.Parse(data.Value.ToString());
                            prod.brandName = ProdBrands.BrandFromID(Brands,prod.brand).Replace("'", "");
                            break;
                        case "subcategory_id":
                            prod.subcategory = int.Parse(data.Value.ToString());
                            prod.subcategoryName = ProdSubcat.SubcategFromID(Subcategories,prod.subcategory).Replace("'", "");
                            break;
                        case "image":
                            prod.image = data.Value.ToString().Replace("'", "");
                            break;
                        case "measure_unit":
                            prod.measure_unit = (MeasureUnits)Enum.Parse(typeof(MeasureUnits), data.Value.ToString().Replace("'", ""));
                            break;
                        case "sku":
                            prod.sku = data.Value.ToString().Replace("'", "");
                            break;
                        default:
                            break;
                    }
                }
                ProdList.Add(prod);
            }
            return ProdList;
        }

        public string[] ListToArray(List<Products> list, string property)
        {
            string[] objList = new string[list.Count];
            int i = 0;
            foreach (Products item in list)
            {
                switch (property)
                {
                    case "id":
                        objList[i] = item.Id.ToString();
                        break;
                    case "name":
                        objList[i] = item.Name.ToString();
                        break;

                    default:
                        break;
                }
            }

            return objList;
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
                case "price":
                    return "Precio";
                case "bar_code":
                    return "Código de Barras";
                case "subcategoryname":
                    return "Subcategoria";
                case "brandname":
                    return "Marca";
                case "image":
                    return "Imagen";
                case "measure_unit":
                    return "Unidad De Medida";
                case "sku":
                    return "SKU";

                default:
                    return "";
            }
        }
    }

    public enum ProdColums
    {
        id,
        name,
        description,
        price,
        bar_code,
        brand_id,
        subcategory_id,
        image,
        measure_unit,
        sku

    }
}
