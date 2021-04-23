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
        static Category categ = new Category();
        static Subcategory subcat = new Subcategory();
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
            if (dgvCat.SelectedRows[0] != null)
            {
                categ = dgvCat.SelectedRows[0].DataBoundItem as Category;
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubcat();
        }

        private void dgvCat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditCatRow();

        }

        private void iBEditCat_Click(object sender, EventArgs e)
        {
            if (dgvCat.SelectedRows[0] != null)
            {
                EditCatRow();

            }
        }
        private void EditCatRow()
        {
            categ = dgvCat.SelectedRows[0].DataBoundItem as Category;
            cbCategory.SelectedIndex = cbCategory.FindString(categ.name);
            tBCatDescription.Text = (dgvCat.SelectedRows[0].DataBoundItem as Category).description;
            FillSubcat();
        }

        private void iBGuardarCat_Click(object sender, EventArgs e)
        {
            if (categ!=null)
            {
                categ.Update(categ.id,categ.name,categ.description);
            }
        }

        private void iBAddCat_Click(object sender, EventArgs e)
        {
            categ.Create(cbCategory.Text,tBCatDescription.Text);
        }

        private void iBEditSubcat_Click(object sender, EventArgs e)
        {
            EditSubcatRow();
        }

        private void dgvSubcat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSubcatRow();
        }
        private void EditSubcatRow() 
        {
            if (dgvSubcat.SelectedRows[0] != null)
            {
                subcat = dgvSubcat.SelectedRows[0].DataBoundItem as Subcategory;
                cbSubcategory.SelectedIndex = cbSubcategory.FindString(subcat.name);
                tbSubcatDescription.Text = subcat.description;
            }
            
        
        }

        private void iBAddSubcat_Click(object sender, EventArgs e)
        {
            subcat.Create(cbSubcategory.Text,tbSubcatDescription.Text,categ.id);
        }
    }
}
