
namespace WinFormPOS
{
    partial class CategoryFrm
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
            this.pCategory = new System.Windows.Forms.Panel();
            this.pButtons = new System.Windows.Forms.Panel();
            this.iBAddCat = new FontAwesome.Sharp.IconButton();
            this.Cat = new FontAwesome.Sharp.IconButton();
            this.iBEditCat = new FontAwesome.Sharp.IconButton();
            this.iBGuardarCat = new FontAwesome.Sharp.IconButton();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.LbDescCat = new System.Windows.Forms.Label();
            this.LbCateg = new System.Windows.Forms.Label();
            this.tBCatDescription = new System.Windows.Forms.TextBox();
            this.pSubcategory = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iBAddSubcat = new FontAwesome.Sharp.IconButton();
            this.iBRemoveSubcat = new FontAwesome.Sharp.IconButton();
            this.iBEditSubcat = new FontAwesome.Sharp.IconButton();
            this.iBGuardarSubcate = new FontAwesome.Sharp.IconButton();
            this.cbSubcategory = new System.Windows.Forms.ComboBox();
            this.dgvSubcat = new System.Windows.Forms.DataGridView();
            this.tbSubcatDescription = new System.Windows.Forms.TextBox();
            this.LbDescSub = new System.Windows.Forms.Label();
            this.LbSubcat = new System.Windows.Forms.Label();
            this.pCatSubcat = new System.Windows.Forms.Panel();
            this.pCategory.SuspendLayout();
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.pSubcategory.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcat)).BeginInit();
            this.pCatSubcat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCategory
            // 
            this.pCategory.AutoSize = true;
            this.pCategory.Controls.Add(this.pButtons);
            this.pCategory.Controls.Add(this.cbCategory);
            this.pCategory.Controls.Add(this.dgvCat);
            this.pCategory.Controls.Add(this.LbDescCat);
            this.pCategory.Controls.Add(this.LbCateg);
            this.pCategory.Controls.Add(this.tBCatDescription);
            this.pCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCategory.Location = new System.Drawing.Point(0, 0);
            this.pCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pCategory.MinimumSize = new System.Drawing.Size(630, 400);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(630, 668);
            this.pCategory.TabIndex = 2;
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.iBAddCat);
            this.pButtons.Controls.Add(this.Cat);
            this.pButtons.Controls.Add(this.iBEditCat);
            this.pButtons.Controls.Add(this.iBGuardarCat);
            this.pButtons.Location = new System.Drawing.Point(13, 162);
            this.pButtons.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(603, 84);
            this.pButtons.TabIndex = 36;
            // 
            // iBAddCat
            // 
            this.iBAddCat.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBAddCat.IconColor = System.Drawing.Color.Black;
            this.iBAddCat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBAddCat.IconSize = 32;
            this.iBAddCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBAddCat.Location = new System.Drawing.Point(422, 19);
            this.iBAddCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBAddCat.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBAddCat.Name = "iBAddCat";
            this.iBAddCat.Size = new System.Drawing.Size(129, 32);
            this.iBAddCat.TabIndex = 19;
            this.iBAddCat.Text = "Añadir";
            this.iBAddCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBAddCat.UseVisualStyleBackColor = true;
            this.iBAddCat.Click += new System.EventHandler(this.iBAddCat_Click);
            // 
            // Cat
            // 
            this.Cat.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.Cat.IconColor = System.Drawing.Color.Black;
            this.Cat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Cat.IconSize = 32;
            this.Cat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cat.Location = new System.Drawing.Point(288, 19);
            this.Cat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cat.MinimumSize = new System.Drawing.Size(129, 32);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(129, 32);
            this.Cat.TabIndex = 20;
            this.Cat.Text = "Borrar";
            this.Cat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cat.UseVisualStyleBackColor = true;
            // 
            // iBEditCat
            // 
            this.iBEditCat.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBEditCat.IconColor = System.Drawing.Color.Black;
            this.iBEditCat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBEditCat.IconSize = 32;
            this.iBEditCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBEditCat.Location = new System.Drawing.Point(19, 19);
            this.iBEditCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBEditCat.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBEditCat.Name = "iBEditCat";
            this.iBEditCat.Size = new System.Drawing.Size(129, 32);
            this.iBEditCat.TabIndex = 21;
            this.iBEditCat.Text = "Editar";
            this.iBEditCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBEditCat.UseVisualStyleBackColor = true;
            this.iBEditCat.Click += new System.EventHandler(this.iBEditCat_Click);
            // 
            // iBGuardarCat
            // 
            this.iBGuardarCat.Enabled = false;
            this.iBGuardarCat.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iBGuardarCat.IconColor = System.Drawing.Color.Black;
            this.iBGuardarCat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBGuardarCat.IconSize = 32;
            this.iBGuardarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBGuardarCat.Location = new System.Drawing.Point(153, 19);
            this.iBGuardarCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBGuardarCat.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBGuardarCat.Name = "iBGuardarCat";
            this.iBGuardarCat.Size = new System.Drawing.Size(129, 32);
            this.iBGuardarCat.TabIndex = 22;
            this.iBGuardarCat.Text = "Guardar";
            this.iBGuardarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBGuardarCat.UseVisualStyleBackColor = true;
            this.iBGuardarCat.Click += new System.EventHandler(this.iBGuardarCat_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(39, 49);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(221, 35);
            this.cbCategory.TabIndex = 7;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // dgvCat
            // 
            this.dgvCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCat.Location = new System.Drawing.Point(41, 248);
            this.dgvCat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvCat.MinimumSize = new System.Drawing.Size(545, 360);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.ReadOnly = true;
            this.dgvCat.RowHeadersVisible = false;
            this.dgvCat.RowTemplate.Height = 25;
            this.dgvCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCat.Size = new System.Drawing.Size(545, 360);
            this.dgvCat.TabIndex = 6;
            this.dgvCat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCat_CellDoubleClick);
            this.dgvCat.SelectionChanged += new System.EventHandler(this.dgvCat_SelectionChanged);
            // 
            // LbDescCat
            // 
            this.LbDescCat.AutoSize = true;
            this.LbDescCat.Location = new System.Drawing.Point(304, 19);
            this.LbDescCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbDescCat.Name = "LbDescCat";
            this.LbDescCat.Size = new System.Drawing.Size(101, 27);
            this.LbDescCat.TabIndex = 5;
            this.LbDescCat.Text = "Descripción";
            // 
            // LbCateg
            // 
            this.LbCateg.AutoSize = true;
            this.LbCateg.Location = new System.Drawing.Point(39, 19);
            this.LbCateg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbCateg.Name = "LbCateg";
            this.LbCateg.Size = new System.Drawing.Size(86, 27);
            this.LbCateg.TabIndex = 4;
            this.LbCateg.Text = "Categoria";
            // 
            // tBCatDescription
            // 
            this.tBCatDescription.Location = new System.Drawing.Point(304, 47);
            this.tBCatDescription.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tBCatDescription.Multiline = true;
            this.tBCatDescription.Name = "tBCatDescription";
            this.tBCatDescription.Size = new System.Drawing.Size(282, 108);
            this.tBCatDescription.TabIndex = 2;
            // 
            // pSubcategory
            // 
            this.pSubcategory.AutoSize = true;
            this.pSubcategory.Controls.Add(this.panel1);
            this.pSubcategory.Controls.Add(this.cbSubcategory);
            this.pSubcategory.Controls.Add(this.dgvSubcat);
            this.pSubcategory.Controls.Add(this.tbSubcatDescription);
            this.pSubcategory.Controls.Add(this.LbDescSub);
            this.pSubcategory.Controls.Add(this.LbSubcat);
            this.pSubcategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSubcategory.Location = new System.Drawing.Point(630, 0);
            this.pSubcategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pSubcategory.MinimumSize = new System.Drawing.Size(630, 400);
            this.pSubcategory.Name = "pSubcategory";
            this.pSubcategory.Size = new System.Drawing.Size(630, 668);
            this.pSubcategory.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iBAddSubcat);
            this.panel1.Controls.Add(this.iBRemoveSubcat);
            this.panel1.Controls.Add(this.iBEditSubcat);
            this.panel1.Controls.Add(this.iBGuardarSubcate);
            this.panel1.Location = new System.Drawing.Point(14, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 84);
            this.panel1.TabIndex = 37;
            // 
            // iBAddSubcat
            // 
            this.iBAddSubcat.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBAddSubcat.IconColor = System.Drawing.Color.Black;
            this.iBAddSubcat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBAddSubcat.IconSize = 32;
            this.iBAddSubcat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBAddSubcat.Location = new System.Drawing.Point(422, 19);
            this.iBAddSubcat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBAddSubcat.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBAddSubcat.Name = "iBAddSubcat";
            this.iBAddSubcat.Size = new System.Drawing.Size(129, 32);
            this.iBAddSubcat.TabIndex = 19;
            this.iBAddSubcat.Text = "Añadir";
            this.iBAddSubcat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBAddSubcat.UseVisualStyleBackColor = true;
            this.iBAddSubcat.Click += new System.EventHandler(this.iBAddSubcat_Click);
            // 
            // iBRemoveSubcat
            // 
            this.iBRemoveSubcat.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iBRemoveSubcat.IconColor = System.Drawing.Color.Black;
            this.iBRemoveSubcat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBRemoveSubcat.IconSize = 32;
            this.iBRemoveSubcat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBRemoveSubcat.Location = new System.Drawing.Point(288, 19);
            this.iBRemoveSubcat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBRemoveSubcat.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBRemoveSubcat.Name = "iBRemoveSubcat";
            this.iBRemoveSubcat.Size = new System.Drawing.Size(129, 32);
            this.iBRemoveSubcat.TabIndex = 20;
            this.iBRemoveSubcat.Text = "Borrar";
            this.iBRemoveSubcat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBRemoveSubcat.UseVisualStyleBackColor = true;
            // 
            // iBEditSubcat
            // 
            this.iBEditSubcat.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBEditSubcat.IconColor = System.Drawing.Color.Black;
            this.iBEditSubcat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBEditSubcat.IconSize = 32;
            this.iBEditSubcat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBEditSubcat.Location = new System.Drawing.Point(19, 19);
            this.iBEditSubcat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBEditSubcat.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBEditSubcat.Name = "iBEditSubcat";
            this.iBEditSubcat.Size = new System.Drawing.Size(129, 32);
            this.iBEditSubcat.TabIndex = 21;
            this.iBEditSubcat.Text = "Editar";
            this.iBEditSubcat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBEditSubcat.UseVisualStyleBackColor = true;
            this.iBEditSubcat.Click += new System.EventHandler(this.iBEditSubcat_Click);
            // 
            // iBGuardarSubcate
            // 
            this.iBGuardarSubcate.Enabled = false;
            this.iBGuardarSubcate.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iBGuardarSubcate.IconColor = System.Drawing.Color.Black;
            this.iBGuardarSubcate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBGuardarSubcate.IconSize = 32;
            this.iBGuardarSubcate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBGuardarSubcate.Location = new System.Drawing.Point(153, 19);
            this.iBGuardarSubcate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBGuardarSubcate.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBGuardarSubcate.Name = "iBGuardarSubcate";
            this.iBGuardarSubcate.Size = new System.Drawing.Size(129, 32);
            this.iBGuardarSubcate.TabIndex = 22;
            this.iBGuardarSubcate.Text = "Guardar";
            this.iBGuardarSubcate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBGuardarSubcate.UseVisualStyleBackColor = true;
            // 
            // cbSubcategory
            // 
            this.cbSubcategory.Enabled = false;
            this.cbSubcategory.FormattingEnabled = true;
            this.cbSubcategory.Location = new System.Drawing.Point(34, 49);
            this.cbSubcategory.Name = "cbSubcategory";
            this.cbSubcategory.Size = new System.Drawing.Size(250, 35);
            this.cbSubcategory.TabIndex = 12;
            // 
            // dgvSubcat
            // 
            this.dgvSubcat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubcat.Enabled = false;
            this.dgvSubcat.Location = new System.Drawing.Point(34, 248);
            this.dgvSubcat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvSubcat.MinimumSize = new System.Drawing.Size(545, 360);
            this.dgvSubcat.Name = "dgvSubcat";
            this.dgvSubcat.ReadOnly = true;
            this.dgvSubcat.RowHeadersVisible = false;
            this.dgvSubcat.RowTemplate.Height = 25;
            this.dgvSubcat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubcat.Size = new System.Drawing.Size(546, 360);
            this.dgvSubcat.TabIndex = 11;
            this.dgvSubcat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubcat_CellDoubleClick);
            // 
            // tbSubcatDescription
            // 
            this.tbSubcatDescription.Enabled = false;
            this.tbSubcatDescription.Location = new System.Drawing.Point(309, 47);
            this.tbSubcatDescription.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSubcatDescription.Multiline = true;
            this.tbSubcatDescription.Name = "tbSubcatDescription";
            this.tbSubcatDescription.Size = new System.Drawing.Size(271, 108);
            this.tbSubcatDescription.TabIndex = 8;
            // 
            // LbDescSub
            // 
            this.LbDescSub.AutoSize = true;
            this.LbDescSub.Location = new System.Drawing.Point(309, 19);
            this.LbDescSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbDescSub.Name = "LbDescSub";
            this.LbDescSub.Size = new System.Drawing.Size(101, 27);
            this.LbDescSub.TabIndex = 10;
            this.LbDescSub.Text = "Descripción";
            // 
            // LbSubcat
            // 
            this.LbSubcat.AutoSize = true;
            this.LbSubcat.Location = new System.Drawing.Point(34, 19);
            this.LbSubcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSubcat.Name = "LbSubcat";
            this.LbSubcat.Size = new System.Drawing.Size(112, 27);
            this.LbSubcat.TabIndex = 9;
            this.LbSubcat.Text = "Subcategoria";
            // 
            // pCatSubcat
            // 
            this.pCatSubcat.Controls.Add(this.pSubcategory);
            this.pCatSubcat.Controls.Add(this.pCategory);
            this.pCatSubcat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCatSubcat.Location = new System.Drawing.Point(0, 0);
            this.pCatSubcat.Name = "pCatSubcat";
            this.pCatSubcat.Size = new System.Drawing.Size(1260, 668);
            this.pCatSubcat.TabIndex = 5;
            // 
            // CategoryFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1260, 668);
            this.Controls.Add(this.pCatSubcat);
            this.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(1260, 668);
            this.Name = "CategoryFrm";
            this.Text = "CategoryFrm";
            this.Load += new System.EventHandler(this.CategoryFrm_Load);
            this.pCategory.ResumeLayout(false);
            this.pCategory.PerformLayout();
            this.pButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.pSubcategory.ResumeLayout(false);
            this.pSubcategory.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcat)).EndInit();
            this.pCatSubcat.ResumeLayout(false);
            this.pCatSubcat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCategory;
        private System.Windows.Forms.Panel pSubcategory;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.Label LbDescCat;
        private System.Windows.Forms.Label LbCateg;
        private System.Windows.Forms.TextBox tBCatDescription;
        private System.Windows.Forms.DataGridView dgvSubcat;
        private System.Windows.Forms.TextBox tbSubcatDescription;
        private System.Windows.Forms.Label LbDescSub;
        private System.Windows.Forms.Label LbSubcat;
        private System.Windows.Forms.Panel pCatSubcat;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSubcategory;
        private System.Windows.Forms.Panel pButtons;
        private FontAwesome.Sharp.IconButton iBAddCat;
        private FontAwesome.Sharp.IconButton Cat;
        private FontAwesome.Sharp.IconButton iBEditCat;
        private FontAwesome.Sharp.IconButton iBGuardarCat;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iBAddSubcat;
        private FontAwesome.Sharp.IconButton iBRemoveSubcat;
        private FontAwesome.Sharp.IconButton iBEditSubcat;
        private FontAwesome.Sharp.IconButton iBGuardarSubcate;
    }
}