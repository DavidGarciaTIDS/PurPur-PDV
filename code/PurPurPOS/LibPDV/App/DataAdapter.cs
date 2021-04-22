using System;
using System.Collections.Generic;
using System.Data;
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

        public DataAdapter() 
        {

        }

        public DataAdapter(DataCollection data)
        {
            this.Name = data.Name;
            this.FieldType = data.FieldType;
            this.Value = data.Value;
        }

        public DataTable DataColToDataTable(List<List<DataCollection>> DC)
        {
            DataTable table = new DataTable();
            foreach (List<DataCollection> lista in DC)
            {
                DataRow row = table.NewRow();
                foreach (DataCollection obj in lista)
                {
                    if (!table.Columns.Contains(NameColums(obj.Name)))
                    {
                        table.Columns.Add(NameColums(obj.Name));
                    }
                    row[NameColums(obj.Name)] = obj.Value.ToString().Replace("'", "");
                }
                table.Rows.Add(row);
            }
            return table;
        }


        public List<string> DataColToList(List<List<DataCollection>> DC, string field) 
        {
            List<string> list = new List<string>();

            foreach (List<DataCollection> item in DC)
            {
                foreach (DataCollection data in item)
                {
                    if (data.Name == field)
                    {
                        list.Add(data.Value.ToString().Replace("'", ""));
                    }
                }
            }
            return list;
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
                case "brand_id":
                    return "Marca";
                case "subcategory_id":
                    return "Subcategoría";
                case "image":
                    return "Imagen";
                case "measure_unit":
                    return "Unidad De Medida";
                case "sku":
                    return "SKU";
                case "logo":
                    return "Logo";
                case "lastname":
                    return "Ap. Paterno";
                case "mothers_lastname":
                    return "Ap. Materno";
                case "street":
                    return "Calle";
                case "house_number":
                    return "No.Casa";
                case "postal_code":
                    return "Codigo Postal";
                case "region_state":
                    return "Region";
                case "type":
                    return "Tipo";
                case "date":
                    return "Fecha";
                case "product_id":
                    return "Producto";
                case "quantity":
                    return "Cantidad";
                case "details":
                    return "Detalles";
                case "cancelled":
                    return "Status";
                case "mac_address":
                    return "Mac Address";
                case "updated_at":
                    return "Actualizado en";

                default:
                    return col;
            }
        }
    }
}
