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

namespace WinFormPOS
{
    public partial class BaseWinFrm : Form
    {
        int currentModule=0;
        public BaseWinFrm()
        {
            InitializeComponent();
        }

        private void BaseWinFrm_Load(object sender, EventArgs e)
        {

        }

        private void SideButtons(int clicked) {

            Form myFrm;
            this.pDisplay.Controls.Clear();

            switch (clicked)
            {
                case 1:
                    //caja
                    myFrm = new CajaFrm();
                    myFrm.TopLevel = false;
                    myFrm.AutoScroll = true;
                    this.pDisplay.Controls.Add(myFrm);
                    myFrm.Show();
                    iBtnCaja.BackColor= Color.FromArgb(150,150,187);

                    break;

                case 2:
                    //Products
                    myFrm = new ProductsFrm();
                    myFrm.TopLevel = false;
                    myFrm.AutoScroll = true;
                    this.pDisplay.Controls.Add(myFrm);
                    myFrm.Show();
                    iBtnProducts.BackColor = Color.FromArgb(150, 150, 187);
                    break;

                case 3:
                    //caja
                    myFrm = new CategoryFrm();
                    myFrm.TopLevel = false;
                    myFrm.AutoScroll = true;
                    this.pDisplay.Controls.Add(myFrm);
                    myFrm.Show();
                    iBtnCaja.BackColor = Color.FromArgb(150, 150, 187);
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                default:
                    break;
            }

            currentModule = clicked;

        }

        private void iBtnCaja_Click(object sender, EventArgs e)
        {
            SideButtons(1);
        }

        private void iBtnProducts_Click(object sender, EventArgs e)
        {
            SideButtons(2);
        }
    }
}
