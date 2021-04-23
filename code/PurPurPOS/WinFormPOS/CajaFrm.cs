using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPDV.App;
using LibPDV.Products;

namespace WinFormPOS
{
    public partial class CajaFrm : Form
    {
        private Products Prod = new Products();
        private bool SearchPrice = false;
        private DataTable table = new DataTable();
        List<string> ListVarchar = new List<string> { "id", "name", "description", "amount", "price" };
        List<Products> ListProd = new List<Products>();
        SearchAdapter Sadapt;
        DataAdapter Dadapt = new DataAdapter();
        List<SearchAdapter> Slist;
        List<object[]> Ticket = new List<object[]>();
        double subTotal;

        public CajaFrm()
        {
            InitializeComponent();
        }

        private void tbBarCode_Enter(object sender, EventArgs e)
        {

        }

        private void iBtnSearchPrice_Click(object sender, EventArgs e)
        {
            SearchPrice = !SearchPrice;
            if (SearchPrice)
            {
                iBtnSearchPrice.BackColor = Color.FromArgb(46, 131, 217);
                lbStatusBarcode.Text = "Buscar Precio";
            }
            else
            {
                iBtnSearchPrice.BackColor = Color.FromArgb(196, 196, 196);
                lbStatusBarcode.Text = "Escaneando";

            }
        }

        private void tbBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString()[0] == '\r')
            {
                if (tbBarCode.Text.Length > 10 && tbBarCode.Text.Length < 16)
                {
                    Slist = new List<SearchAdapter>();
                    Sadapt = new SearchAdapter("bar_code", LibBD.CriteriaOperator.EQUALS, tbBarCode.Text, true);
                    Slist.Add(Sadapt);
                    ListVarchar = new List<string> { "id", "name", "description", "price" };
                    ListProd = Prod.DataToProdList(Prod.Read(ListVarchar, "name", Slist));
                    foreach (Products item in ListProd)
                    {
                        if (!SearchPrice)
                        {
                            bool contains = false;
                            int idx = 0;

                            foreach (object[] obj in Ticket)
                            {
                                if (obj[0].ToString() == item.Id.ToString())
                                {
                                    contains = true;
                                    break;
                                }
                                idx++;
                            }
                            if (contains)
                            {
                                (Ticket[idx])[3] = (double)NumAmount.Value + (double)(Ticket[idx])[3];
                                (Ticket[idx])[4] = item.Price * (double)(Ticket[idx])[3];

                            }
                            else
                            {
                                Ticket.Add(new object[] { item.Id, item.Name, item.Description, (double)NumAmount.Value, item.Price * (double)NumAmount.Value });
                            }
                            dgvPOS.Rows.Clear();
                            subTotal = 0;
                            foreach (object[] rows in Ticket)
                            {
                                dgvPOS.Rows.Add(rows);
                                subTotal += double.Parse(rows[4].ToString());

                            }
                            lbSubtotalAmount.Text = $"$  {subTotal}";
                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        private void CajaFrm_Load(object sender, EventArgs e)
        {
            List<string> nombresCol = new List<string> { "ID", "Producto", "Descripción", "Cantidad", "Precio", " ", " ", " " };
            ListVarchar = new List<string> { "id", "name", "description", "amount", "price" };
            for (int i = 0; i < ListVarchar.Count; i++)
            {
                if (!dgvPOS.Columns.Contains(ListVarchar[i]))
                    dgvPOS.Columns.Add(ListVarchar[i], nombresCol[i]);
            }
            dgvPOS.Columns["ID"].Visible = false;


        }

        private void tbPayment_TextChanged(object sender, EventArgs e)
        {
            double cambio = 0;
            if (tbPayment.Text!="")
            {
                cambio = Double.Parse(tbPayment.Text) - subTotal;
                lbCambioAmount.Text = $"$  { cambio.ToString()}";
                if (cambio > -1)
                    lbCambioAmount.ForeColor = Color.Black;
                else
                    lbCambioAmount.ForeColor = Color.Red;
            }
        }
    }
}
