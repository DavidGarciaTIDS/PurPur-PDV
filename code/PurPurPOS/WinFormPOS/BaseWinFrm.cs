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
            lbUsName.Text = LoginFrm.currentUser.fullName().Replace("'","");
            lbUserType.Text = LoginFrm.currentUser.UsLv.ToString().Replace("'", "");
            
            pDisplay.Controls.Add(pUserMenu);
            pUserMenu.Visible = false;
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
                    //Category
                    myFrm = new CategoryFrm();
                    myFrm.TopLevel = false;
                    myFrm.AutoScroll = true;
                    this.pDisplay.Controls.Add(myFrm);
                    myFrm.Show();
                    iBtnCaja.BackColor = Color.FromArgb(150, 150, 187);
                    break;

                case 4:
                    //Category
                    myFrm = new UsersFrm();
                    myFrm.TopLevel = false;
                    myFrm.AutoScroll = true;
                    this.pDisplay.Controls.Add(myFrm);
                    myFrm.Show();
                    iBtnCaja.BackColor = Color.FromArgb(150, 150, 187);
                    break;

                case 5:
                    //Logs
                    myFrm = new LogsFrm();
                    myFrm.TopLevel = false;
                    myFrm.AutoScroll = true;
                    this.pDisplay.Controls.Add(myFrm);
                    myFrm.Show();
                    iBtnCaja.BackColor = Color.FromArgb(150, 150, 187);
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

        private void picBUser_Click(object sender, EventArgs e)
        {
            if (pUserMenu.Visible == false)
            {
                pUserMenu.Location.Offset(pDisplay.Width - pUserMenu.Width, 0);
                this.pDisplay.Controls.Add(pUserMenu);
                pUserMenu.Show();
            }
            else
            {
                this.pDisplay.Controls.Remove(pUserMenu);
                pUserMenu.Visible = false;
            }
        }

        private void iBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iBtnCategory_Click(object sender, EventArgs e)
        {
            SideButtons(3);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            SideButtons(4);
        }
    }
}
