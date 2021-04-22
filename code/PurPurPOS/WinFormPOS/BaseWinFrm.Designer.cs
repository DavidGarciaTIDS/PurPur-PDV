﻿
namespace WinFormPOS
{
    partial class BaseWinFrm
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
            this.pHeader = new System.Windows.Forms.Panel();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbModule = new System.Windows.Forms.Label();
            this.pUser = new System.Windows.Forms.Panel();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbUsName = new System.Windows.Forms.Label();
            this.lbUserType = new System.Windows.Forms.Label();
            this.picBUser = new System.Windows.Forms.PictureBox();
            this.pLogo = new System.Windows.Forms.Panel();
            this.picBLogo = new System.Windows.Forms.PictureBox();
            this.pSide = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iBtnCategory = new FontAwesome.Sharp.IconButton();
            this.iBtnProducts = new FontAwesome.Sharp.IconButton();
            this.iBtnCaja = new FontAwesome.Sharp.IconButton();
            this.pDisplay = new System.Windows.Forms.Panel();
            this.pUserMenu = new System.Windows.Forms.Panel();
            this.iBtnSalir = new FontAwesome.Sharp.IconButton();
            this.pHeader.SuspendLayout();
            this.pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBUser)).BeginInit();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBLogo)).BeginInit();
            this.pSide.SuspendLayout();
            this.pUserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.pHeader.Controls.Add(this.lbWarning);
            this.pHeader.Controls.Add(this.lbModule);
            this.pHeader.Controls.Add(this.pUser);
            this.pHeader.Controls.Add(this.pLogo);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1360, 100);
            this.pHeader.TabIndex = 0;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(136)))), ((int)(((byte)(30)))));
            this.lbWarning.Location = new System.Drawing.Point(106, 9);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(240, 32);
            this.lbWarning.TabIndex = 5;
            this.lbWarning.Text = "Warning: Error x ocurrido";
            this.lbWarning.Visible = false;
            // 
            // lbModule
            // 
            this.lbModule.AutoSize = true;
            this.lbModule.Location = new System.Drawing.Point(106, 65);
            this.lbModule.Name = "lbModule";
            this.lbModule.Size = new System.Drawing.Size(127, 32);
            this.lbModule.TabIndex = 4;
            this.lbModule.Text = "Modulo Base";
            // 
            // pUser
            // 
            this.pUser.Controls.Add(this.pUserMenu);
            this.pUser.Controls.Add(this.lbTurn);
            this.pUser.Controls.Add(this.lbUsName);
            this.pUser.Controls.Add(this.lbUserType);
            this.pUser.Controls.Add(this.picBUser);
            this.pUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pUser.Location = new System.Drawing.Point(1010, 0);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(350, 100);
            this.pUser.TabIndex = 3;
            // 
            // lbTurn
            // 
            this.lbTurn.Location = new System.Drawing.Point(0, 68);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(250, 32);
            this.lbTurn.TabIndex = 3;
            this.lbTurn.Text = "Turno";
            this.lbTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsName
            // 
            this.lbUsName.Location = new System.Drawing.Point(0, 32);
            this.lbUsName.Name = "lbUsName";
            this.lbUsName.Size = new System.Drawing.Size(250, 32);
            this.lbUsName.TabIndex = 2;
            this.lbUsName.Text = "Nombre Apellido";
            this.lbUsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserType
            // 
            this.lbUserType.Location = new System.Drawing.Point(0, 0);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(250, 32);
            this.lbUserType.TabIndex = 1;
            this.lbUserType.Text = "TipoUsuario";
            this.lbUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBUser
            // 
            this.picBUser.BackColor = System.Drawing.Color.Transparent;
            this.picBUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBUser.Image = global::WinFormPOS.Properties.Resources.canvas;
            this.picBUser.Location = new System.Drawing.Point(250, 0);
            this.picBUser.Name = "picBUser";
            this.picBUser.Size = new System.Drawing.Size(100, 100);
            this.picBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBUser.TabIndex = 0;
            this.picBUser.TabStop = false;
            this.picBUser.Click += new System.EventHandler(this.picBUser_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.picBLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(100, 100);
            this.pLogo.TabIndex = 2;
            // 
            // picBLogo
            // 
            this.picBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBLogo.Image = global::WinFormPOS.Properties.Resources._64_logo;
            this.picBLogo.Location = new System.Drawing.Point(0, 0);
            this.picBLogo.Name = "picBLogo";
            this.picBLogo.Size = new System.Drawing.Size(100, 100);
            this.picBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBLogo.TabIndex = 0;
            this.picBLogo.TabStop = false;
            // 
            // pSide
            // 
            this.pSide.Controls.Add(this.iconButton4);
            this.pSide.Controls.Add(this.iconButton3);
            this.pSide.Controls.Add(this.iBtnCategory);
            this.pSide.Controls.Add(this.iBtnProducts);
            this.pSide.Controls.Add(this.iBtnCaja);
            this.pSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSide.Location = new System.Drawing.Point(0, 100);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(100, 668);
            this.pSide.TabIndex = 1;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Registered;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(0, 344);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(100, 80);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Log";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(0, 258);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(100, 80);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Usuarios";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iBtnCategory
            // 
            this.iBtnCategory.BackColor = System.Drawing.Color.Transparent;
            this.iBtnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnCategory.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iBtnCategory.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.iBtnCategory.IconColor = System.Drawing.Color.Black;
            this.iBtnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCategory.Location = new System.Drawing.Point(0, 172);
            this.iBtnCategory.Name = "iBtnCategory";
            this.iBtnCategory.Size = new System.Drawing.Size(100, 80);
            this.iBtnCategory.TabIndex = 2;
            this.iBtnCategory.Text = "Categorias";
            this.iBtnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBtnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnCategory.UseVisualStyleBackColor = false;
            this.iBtnCategory.Click += new System.EventHandler(this.iBtnCategory_Click);
            // 
            // iBtnProducts
            // 
            this.iBtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.iBtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnProducts.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iBtnProducts.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.iBtnProducts.IconColor = System.Drawing.Color.Black;
            this.iBtnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnProducts.Location = new System.Drawing.Point(0, 86);
            this.iBtnProducts.Name = "iBtnProducts";
            this.iBtnProducts.Size = new System.Drawing.Size(100, 80);
            this.iBtnProducts.TabIndex = 1;
            this.iBtnProducts.Text = "Productos";
            this.iBtnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBtnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnProducts.UseVisualStyleBackColor = false;
            this.iBtnProducts.Click += new System.EventHandler(this.iBtnProducts_Click);
            // 
            // iBtnCaja
            // 
            this.iBtnCaja.BackColor = System.Drawing.Color.Transparent;
            this.iBtnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnCaja.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iBtnCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iBtnCaja.IconColor = System.Drawing.Color.Black;
            this.iBtnCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCaja.Location = new System.Drawing.Point(0, 0);
            this.iBtnCaja.Name = "iBtnCaja";
            this.iBtnCaja.Size = new System.Drawing.Size(100, 80);
            this.iBtnCaja.TabIndex = 0;
            this.iBtnCaja.Text = "Caja";
            this.iBtnCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBtnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnCaja.UseVisualStyleBackColor = false;
            this.iBtnCaja.Click += new System.EventHandler(this.iBtnCaja_Click);
            // 
            // pDisplay
            // 
            this.pDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.pDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDisplay.Location = new System.Drawing.Point(100, 100);
            this.pDisplay.Name = "pDisplay";
            this.pDisplay.Size = new System.Drawing.Size(1260, 668);
            this.pDisplay.TabIndex = 3;
            // 
            // pUserMenu
            // 
            this.pUserMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.pUserMenu.Controls.Add(this.iBtnSalir);
            this.pUserMenu.Location = new System.Drawing.Point(206, 50);
            this.pUserMenu.Name = "pUserMenu";
            this.pUserMenu.Size = new System.Drawing.Size(132, 130);
            this.pUserMenu.TabIndex = 0;
            this.pUserMenu.Visible = false;
            // 
            // iBtnSalir
            // 
            this.iBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iBtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnSalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iBtnSalir.IconColor = System.Drawing.Color.Black;
            this.iBtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSalir.IconSize = 32;
            this.iBtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iBtnSalir.Location = new System.Drawing.Point(0, 98);
            this.iBtnSalir.Name = "iBtnSalir";
            this.iBtnSalir.Size = new System.Drawing.Size(132, 32);
            this.iBtnSalir.TabIndex = 1;
            this.iBtnSalir.Text = "Salir";
            this.iBtnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnSalir.UseVisualStyleBackColor = true;
            this.iBtnSalir.Click += new System.EventHandler(this.iBtnSalir_Click);
            // 
            // BaseWinFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pDisplay);
            this.Controls.Add(this.pSide);
            this.Controls.Add(this.pHeader);
            this.Font = new System.Drawing.Font("Dubai Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BaseWinFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseWinFrm_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBUser)).EndInit();
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBLogo)).EndInit();
            this.pSide.ResumeLayout(false);
            this.pUserMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pUser;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbUsName;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.PictureBox picBUser;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox picBLogo;
        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Panel pDisplay;
        private System.Windows.Forms.Panel pUserMenu;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iBtnCategory;
        private FontAwesome.Sharp.IconButton iBtnProducts;
        private FontAwesome.Sharp.IconButton iBtnCaja;
        private FontAwesome.Sharp.IconButton iBtnSalir;
        private System.Windows.Forms.Label lbModule;
        private System.Windows.Forms.Label lbWarning;
    }

        
    
}