using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPDV.Users;
using LibPDV.App;

namespace WinFormPOS
{
    public partial class LoginFrm : Form
    {
        public SearchAdapter Sadapt;
        public DataAdapter Dadapt;
        public static Users currentUser = new Users(); 


        public LoginFrm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbClose_MouseHover(object sender, EventArgs e)
        {
            LbClose.BackColor = Color.Red;
        }

        private void LbClose_MouseLeave(object sender, EventArgs e)
        {
            LbClose.BackColor = Color.Transparent;
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            pBLogo.Location = new System.Drawing.Point(LogoPanel.Width / 3, 0);
            LbClose.Location = new System.Drawing.Point(this.Width - 25, 10);
            tBEmail.Text = "DevTest@test.com";
            tBPwd.Text = "Dev123";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Users LogUser = new Users();
            currentUser=LogUser.UserLogin(tBEmail.Text, tBPwd.Text);


            if (currentUser!=null)
            {
                Lbtest.Text = "LOGGED IN";
                this.Visible = false;
                BaseWinFrm Logged = new BaseWinFrm();
                Logged.Show();
            }
            else
            {
                MessageBox.Show($"El usuario: {tBEmail.Text} no existe o de encuentra deshabilitado");
            }
        }
    }
}
