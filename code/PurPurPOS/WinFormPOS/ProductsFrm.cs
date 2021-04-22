using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPDV.Products;
using LibPDV.App;

namespace WinFormPOS
{
    public partial class ProductsFrm : Form
    {
        DataAdapter adapt = new DataAdapter();
        SearchAdapter Sadapt = new SearchAdapter();
        List<SearchAdapter> SList = new List<SearchAdapter>();
        DataTable temp= new DataTable();
        Products prod = new Products();
        Brands brand = new Brands();
        Category categ = new Category();
        Subcategory subcat = new Subcategory();
        public ProductsFrm()
        {
            InitializeComponent();
        }

        private void ProductsFrm_Load(object sender, EventArgs e)
        {
            SList.Add(Sadapt=new SearchAdapter());
            cbMetricUnit.Items.AddRange((object[])Enum.GetNames(typeof(MeasureUnits)));
            cbBrand.Items.AddRange(adapt.DataColToList(brand.Read(new List<string> { "name" }, "name", SList), "name").ToArray());
            cbCateg.Items.AddRange(adapt.DataColToList(categ.Read(new List<string> { "name" }, "name", SList), "name").ToArray());
            LoadGrid();
        }

        private void iPProduct_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (iPProduct.BackgroundImage != null)
            {
                iPProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            }
            else
            {
                iPProduct.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            }
        }

        private void iBAdd_Click(object sender, EventArgs e)
        {

            if (prod.Create(tBNameProd.Text, tbDescProd.Text, Double.Parse(tbPrice.Text), tbBarCode.Text, 
                int.Parse(cbBrand.SelectedItem.ToString()), int.Parse(cbSubcat.SelectedItem.ToString()), 
                (MeasureUnits)Enum.Parse(typeof(MeasureUnits),cbMetricUnit.SelectedItem.ToString()), ""))
            {
                MessageBox.Show("Se registro");
            }
            else
            {
                MessageBox.Show("No se registro el prod " + prod.ERROR);
            }
        }

        private void iBRemove_Click(object sender, EventArgs e)
        {

        }

        private void cbCateg_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSubcat.Enabled==false)
            {
                cbSubcat.Enabled = true;
            }
            Sadapt=new SearchAdapter("category_id",LibBD.CriteriaOperator.EQUALS,cbCateg.SelectedIndex+1,false,LibBD.LogicOperator.NOTHING);
            SList = new List<SearchAdapter>();
            SList.Add(Sadapt);
            cbSubcat.Items.AddRange(adapt.DataColToList(subcat.Read(new List<string> { "name" }, "name", SList), "name").ToArray());
        }

        private void LoadGrid() 
        {
            DataTable temp = adapt.DataColToDataTable(prod.Index("id",false,new List<string>{"*"}));
            dGVProducts.Columns.Clear();
            
            dGVProducts.DataSource = temp;
            dGVProducts.Columns[0].Visible = false;
        }
    }
}
