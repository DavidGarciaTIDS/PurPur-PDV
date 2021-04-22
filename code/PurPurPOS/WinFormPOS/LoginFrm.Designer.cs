
namespace WinFormPOS
{
    partial class LoginFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbClose = new System.Windows.Forms.Label();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pBLogo = new FontAwesome.Sharp.IconPictureBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Lbtest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbClose
            // 
            this.LbClose.AutoSize = true;
            this.LbClose.Location = new System.Drawing.Point(260, 9);
            this.LbClose.Name = "LbClose";
            this.LbClose.Size = new System.Drawing.Size(14, 15);
            this.LbClose.TabIndex = 0;
            this.LbClose.Text = "X";
            this.LbClose.Click += new System.EventHandler(this.LbClose_Click);
            this.LbClose.MouseLeave += new System.EventHandler(this.LbClose_MouseLeave);
            this.LbClose.MouseHover += new System.EventHandler(this.LbClose_MouseHover);
            // 
            // tBEmail
            // 
            this.tBEmail.Location = new System.Drawing.Point(59, 191);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(177, 23);
            this.tBEmail.TabIndex = 2;
            // 
            // tBPwd
            // 
            this.tBPwd.Location = new System.Drawing.Point(59, 265);
            this.tBPwd.Name = "tBPwd";
            this.tBPwd.Size = new System.Drawing.Size(177, 23);
            this.tBPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(151, 320);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(85, 23);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(122, 291);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvide la contraseña";
            // 
            // pBLogo
            // 
            this.pBLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pBLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pBLogo.IconChar = FontAwesome.Sharp.IconChar.Terminal;
            this.pBLogo.IconColor = System.Drawing.SystemColors.ControlText;
            this.pBLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pBLogo.IconSize = 96;
            this.pBLogo.Location = new System.Drawing.Point(82, 11);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(96, 96);
            this.pBLogo.TabIndex = 8;
            this.pBLogo.TabStop = false;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogoPanel.Controls.Add(this.pBLogo);
            this.LogoPanel.Location = new System.Drawing.Point(12, 27);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(275, 117);
            this.LogoPanel.TabIndex = 9;
            // 
            // Lbtest
            // 
            this.Lbtest.AutoSize = true;
            this.Lbtest.Location = new System.Drawing.Point(12, 352);
            this.Lbtest.Name = "Lbtest";
            this.Lbtest.Size = new System.Drawing.Size(78, 15);
            this.Lbtest.TabIndex = 10;
            this.Lbtest.Text = "LOGGED OUT";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(299, 411);
            this.Controls.Add(this.Lbtest);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBPwd);
            this.Controls.Add(this.tBEmail);
            this.Controls.Add(this.LbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.LogoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbClose;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconPictureBox pBLogo;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label Lbtest;
    }
}