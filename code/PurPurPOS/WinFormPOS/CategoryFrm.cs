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
    public partial class CategoryFrm : Form
    {
        Category categ = new Category();
        Subcategory subcat = new Subcategory();
        List<Subcategory> SubCatList = new List<Subcategory>();
        List<Subcategory> CatList = new List<Subcategory>();


        public CategoryFrm()
        {
            InitializeComponent();
        }

        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            dgvCat.DataSource = BaseWinFrm.ListCategory;
            foreach (DataGridViewColumn item in dgvCat.Columns)
            {
                string newName = categ.NameColums(item.Name);
                if (newName == "" || newName == "ID")
                {
                    item.Visible = false;
                }
                else
                {
                    item.HeaderText = newName;
                }
            }

            cbCategory.DataSource = BaseWinFrm.ListCategory;
            cbCategory.DisplayMember = "name";


        }

        private void FillSubcat()
        {

            if (!dgvSubcat.Enabled)
            {
                dgvSubcat.Enabled = true;
                cbSubcategory.Enabled = true;
                tbSubcatDescription.Enabled = true;
                SubCatList = new List<Subcategory>();
                foreach (Subcategory item in BaseWinFrm.ListSubcategory)
                {
                    if (item.catId == (dgvCat.SelectedRows[0].DataBoundItem as Category).id)
                    {
                        SubCatList.Add(item);
                    }
                }
                dgvSubcat.DataSource = SubCatList;
            }
            foreach (DataGridViewColumn item in dgvSubcat.Columns)
            {
                string newName = subcat.NameColums(item.Name);
                if (newName == "" || newName == "ID")
                {
                    item.Visible = false;
                }
                else
                {
                    item.HeaderText = newName;
                }
            }
            cbSubcategory.DataSource = SubCatList;
            cbSubcategory.DisplayMember = "name";

        }

        private void dgvCat_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubcat();
        }

        private void dgvCat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                categ = dgvCat.SelectedRows[0].DataBoundItem as Category;
                cbCategory.SelectedIndex = cbCategory.FindString(categ.name);
                tBCatDescription.Text = (dgvCat.SelectedRows[0].DataBoundItem as Category).description;
                FillSubcat();
            
        }
    }
}
