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

        DataTable temp = new DataTable();
        private static Products prod = new Products();
        Brands brand = new Brands();
        Category categ = new Category();
        Subcategory subcat = new Subcategory();
        List<Subcategory> SubCatList = new List<Subcategory>();
        public ProductsFrm()
        {
            InitializeComponent();
        }

        private void ProductsFrm_Load(object sender, EventArgs e)
        {
            FillLists();
            FillComboBox();
            //LoadGrid();
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
                (MeasureUnits)Enum.Parse(typeof(MeasureUnits), cbMetricUnit.SelectedItem.ToString()), ""))
            {
                FillLists();
                MessageBox.Show("Se registro");
            }
            else
            {
                MessageBox.Show("No se registro el prod " + prod.ERROR);
            }
        }

        private void iBRemove_Click(object sender, EventArgs e)
        {
            prod = dGVProducts.SelectedRows[0].DataBoundItem as Products;
            if (prod != null)
            {
                prod.Delete(prod.Id);

            }
        }

        private void cbCateg_SelectedValueChanged(object sender, EventArgs e)
        { }

        private void LoadGrid()
        {
            //ID Image Products Description Price Category Subcategory Barcode
            dGVProducts.Columns.Clear();

            dGVProducts.DataSource = BaseWinFrm.ListProducts;

            foreach (DataGridViewColumn item in dGVProducts.Columns)
            {
                string newName = prod.NameColums(item.Name);
                if (newName == "" || newName.ToLower() == "id" || newName.ToLower() == "imagen" || newName.ToLower() == "error")
                    item.Visible = false;
                else
                    item.HeaderText = newName;
            }

        }

        private void dGVProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProdToEdit();
        }
        public void FillLists()
        {
            BaseWinFrm.ListCategory = categ.DataToCateList(categ.Index("id", false, new List<string> { "*" }));
            BaseWinFrm.ListSubcategory = subcat.DataToCateList(subcat.Index("id", false, new List<string> { "*" }));
            subcat.FillCategories(BaseWinFrm.ListCategory);
            BaseWinFrm.ListBrand = brand.DataToBrandList(brand.Index("id", false, new List<string> { "*" }));
            prod.FillBrands(BaseWinFrm.ListBrand);
            prod.FillSubcat(BaseWinFrm.ListSubcategory);
            BaseWinFrm.ListProducts = prod.DataToProdList(prod.Index("id", false, new List<string> { "*" }));

            LoadGrid();
        }
        public void FillComboBox()
        {
            cbBrand.DataSource = BaseWinFrm.ListBrand;
            cbBrand.DisplayMember = "name";
            cbCateg.DataSource = BaseWinFrm.ListCategory;
            cbCateg.DisplayMember = "name";
        }
        private void fillSubComBox(int categId)
        {
            SubCatList = new List<Subcategory>();

            foreach (Subcategory item in BaseWinFrm.ListSubcategory)
            {
                if (item.catId == categId)
                {
                    SubCatList.Add(item);
                }
            }
            cbSubcat.DataSource = SubCatList;
            cbSubcat.DisplayMember = "name";
        }

        private void cbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

            Category tempCat = new Category();
            tempCat = BaseWinFrm.ListCategory.Find(x => x.name.Replace("'", "") == cbCateg.Text);


            if (cbSubcat.Enabled == false)
            {
                if (tempCat != null)
                {
                    cbSubcat.Enabled = true;
                    fillSubComBox(tempCat.id);

                }
            }
        }

        private void iBEdit_Click(object sender, EventArgs e)
        {
            SelectProdToEdit();
        }
        private void SelectProdToEdit()
        {

            iBGuardar.Enabled = true;
            iBRemove.Enabled = true;

            prod = dGVProducts.SelectedRows[0].DataBoundItem as Products;

            Subcategory tempSubcat = new Subcategory();
            tempSubcat = BaseWinFrm.ListSubcategory.Find(x => x.id == prod.subcategory);
            Category tempCat = new Category();
            tempCat = BaseWinFrm.ListCategory.Find(x => x.id == tempSubcat.catId);
            tBNameProd.Text = prod.Name;
            tbBarCode.Text = prod.BarCode;
            tbDescProd.Text = prod.Description;
            tbPrice.Text = prod.Price.ToString();
            cbBrand.SelectedIndex = cbBrand.FindString(prod.brandName);
            cbCateg.SelectedIndex = cbCateg.FindString(tempCat.name.Replace("'", ""));
            cbSubcat.SelectedIndex = cbSubcat.FindString(prod.subcategoryName);
            cbMetricUnit.SelectedIndex = cbMetricUnit.FindString(prod.measure_unit.ToString());

        }

        private void iBGuardar_Click(object sender, EventArgs e)
        {
            prod.Name = tBNameProd.Text;
            prod.BarCode = tbBarCode.Text;
            prod.Description = tbDescProd.Text;
            prod.Price = Double.Parse(tbPrice.Text);
            prod.brand = BaseWinFrm.ListBrand.Find(x => x.name == cbBrand.Text).id;
            prod.subcategory = BaseWinFrm.ListSubcategory.Find(x => x.name == cbSubcat.Text).id;
            prod.measure_unit = (MeasureUnits)Enum.Parse(typeof(MeasureUnits), cbMetricUnit.Text);


            if (prod.Update(prod.Id, prod.Name, prod.Description, prod.Price, prod.BarCode, prod.brand, prod.subcategory, prod.measure_unit, prod.sku))
            {
                MessageBox.Show("se actualizo correctamente");

                FillLists();
                FillComboBox();
            }
            iBGuardar.Enabled = false;
        }
    }
}
