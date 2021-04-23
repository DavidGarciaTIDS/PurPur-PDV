
namespace WinFormPOS
{
    partial class ProductsFrm
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
            this.dGVProducts = new System.Windows.Forms.DataGridView();
            this.iPProduct = new FontAwesome.Sharp.IconPictureBox();
            this.iBAdd = new FontAwesome.Sharp.IconButton();
            this.iBRemove = new FontAwesome.Sharp.IconButton();
            this.iBEdit = new FontAwesome.Sharp.IconButton();
            this.iBGuardar = new FontAwesome.Sharp.IconButton();
            this.pProduct = new System.Windows.Forms.Panel();
            this.pGrid = new System.Windows.Forms.Panel();
            this.pButtons = new System.Windows.Forms.Panel();
            this.pForm = new System.Windows.Forms.Panel();
            this.cbMetricUnit = new System.Windows.Forms.ComboBox();
            this.lbMetricUnit = new System.Windows.Forms.Label();
            this.iBUpload = new FontAwesome.Sharp.IconButton();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDescProd = new System.Windows.Forms.TextBox();
            this.LbSubcat = new System.Windows.Forms.Label();
            this.LbNameProd = new System.Windows.Forms.Label();
            this.cbSubcat = new System.Windows.Forms.ComboBox();
            this.tBNameProd = new System.Windows.Forms.TextBox();
            this.LbDescription = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCateg = new System.Windows.Forms.ComboBox();
            this.LbMarca = new System.Windows.Forms.Label();
            this.LbCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPProduct)).BeginInit();
            this.pProduct.SuspendLayout();
            this.pGrid.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.pForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVProducts
            // 
            this.dGVProducts.AllowUserToAddRows = false;
            this.dGVProducts.AllowUserToDeleteRows = false;
            this.dGVProducts.AllowUserToOrderColumns = true;
            this.dGVProducts.AllowUserToResizeRows = false;
            this.dGVProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(142)))));
            this.dGVProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVProducts.ColumnHeadersHeight = 35;
            this.dGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGVProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGVProducts.GridColor = System.Drawing.SystemColors.Control;
            this.dGVProducts.Location = new System.Drawing.Point(0, 52);
            this.dGVProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVProducts.MultiSelect = false;
            this.dGVProducts.Name = "dGVProducts";
            this.dGVProducts.ReadOnly = true;
            this.dGVProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVProducts.RowHeadersVisible = false;
            this.dGVProducts.RowTemplate.Height = 25;
            this.dGVProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVProducts.Size = new System.Drawing.Size(1260, 414);
            this.dGVProducts.TabIndex = 15;
            this.dGVProducts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProducts_CellContentDoubleClick);
            // 
            // iPProduct
            // 
            this.iPProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iPProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.iPProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iPProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPProduct.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iPProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPProduct.IconSize = 100;
            this.iPProduct.Location = new System.Drawing.Point(12, 21);
            this.iPProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iPProduct.Name = "iPProduct";
            this.iPProduct.Size = new System.Drawing.Size(100, 100);
            this.iPProduct.TabIndex = 18;
            this.iPProduct.TabStop = false;
            this.iPProduct.BackgroundImageChanged += new System.EventHandler(this.iPProduct_BackgroundImageChanged);
            // 
            // iBAdd
            // 
            this.iBAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBAdd.IconColor = System.Drawing.Color.Black;
            this.iBAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBAdd.IconSize = 32;
            this.iBAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBAdd.Location = new System.Drawing.Point(1041, 8);
            this.iBAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBAdd.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBAdd.Name = "iBAdd";
            this.iBAdd.Size = new System.Drawing.Size(129, 32);
            this.iBAdd.TabIndex = 19;
            this.iBAdd.Text = "Añadir";
            this.iBAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBAdd.UseVisualStyleBackColor = true;
            this.iBAdd.Click += new System.EventHandler(this.iBAdd_Click);
            // 
            // iBRemove
            // 
            this.iBRemove.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iBRemove.IconColor = System.Drawing.Color.Black;
            this.iBRemove.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBRemove.IconSize = 32;
            this.iBRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBRemove.Location = new System.Drawing.Point(907, 8);
            this.iBRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBRemove.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBRemove.Name = "iBRemove";
            this.iBRemove.Size = new System.Drawing.Size(129, 32);
            this.iBRemove.TabIndex = 20;
            this.iBRemove.Text = "Borrar";
            this.iBRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBRemove.UseVisualStyleBackColor = true;
            this.iBRemove.Click += new System.EventHandler(this.iBRemove_Click);
            // 
            // iBEdit
            // 
            this.iBEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBEdit.IconColor = System.Drawing.Color.Black;
            this.iBEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBEdit.IconSize = 32;
            this.iBEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBEdit.Location = new System.Drawing.Point(638, 8);
            this.iBEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBEdit.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBEdit.Name = "iBEdit";
            this.iBEdit.Size = new System.Drawing.Size(129, 32);
            this.iBEdit.TabIndex = 21;
            this.iBEdit.Text = "Editar";
            this.iBEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBEdit.UseVisualStyleBackColor = true;
            // 
            // iBGuardar
            // 
            this.iBGuardar.Enabled = false;
            this.iBGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iBGuardar.IconColor = System.Drawing.Color.Black;
            this.iBGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBGuardar.IconSize = 32;
            this.iBGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBGuardar.Location = new System.Drawing.Point(772, 8);
            this.iBGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBGuardar.MinimumSize = new System.Drawing.Size(129, 32);
            this.iBGuardar.Name = "iBGuardar";
            this.iBGuardar.Size = new System.Drawing.Size(129, 32);
            this.iBGuardar.TabIndex = 22;
            this.iBGuardar.Text = "Guardar";
            this.iBGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBGuardar.UseVisualStyleBackColor = true;
            // 
            // pProduct
            // 
            this.pProduct.Controls.Add(this.pGrid);
            this.pProduct.Controls.Add(this.pForm);
            this.pProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pProduct.Location = new System.Drawing.Point(0, 0);
            this.pProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pProduct.MaximumSize = new System.Drawing.Size(1800, 900);
            this.pProduct.MinimumSize = new System.Drawing.Size(1260, 668);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(1260, 668);
            this.pProduct.TabIndex = 23;
            // 
            // pGrid
            // 
            this.pGrid.Controls.Add(this.pButtons);
            this.pGrid.Controls.Add(this.dGVProducts);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(0, 202);
            this.pGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(1260, 466);
            this.pGrid.TabIndex = 34;
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.iBAdd);
            this.pButtons.Controls.Add(this.iBRemove);
            this.pButtons.Controls.Add(this.iBEdit);
            this.pButtons.Controls.Add(this.iBGuardar);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pButtons.Location = new System.Drawing.Point(0, 0);
            this.pButtons.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(1260, 44);
            this.pButtons.TabIndex = 35;
            // 
            // pForm
            // 
            this.pForm.Controls.Add(this.cbMetricUnit);
            this.pForm.Controls.Add(this.lbMetricUnit);
            this.pForm.Controls.Add(this.iBUpload);
            this.pForm.Controls.Add(this.tbBarCode);
            this.pForm.Controls.Add(this.tbPrice);
            this.pForm.Controls.Add(this.tbDescProd);
            this.pForm.Controls.Add(this.LbSubcat);
            this.pForm.Controls.Add(this.iPProduct);
            this.pForm.Controls.Add(this.LbNameProd);
            this.pForm.Controls.Add(this.cbSubcat);
            this.pForm.Controls.Add(this.tBNameProd);
            this.pForm.Controls.Add(this.LbDescription);
            this.pForm.Controls.Add(this.cbBrand);
            this.pForm.Controls.Add(this.label2);
            this.pForm.Controls.Add(this.cbCateg);
            this.pForm.Controls.Add(this.LbMarca);
            this.pForm.Controls.Add(this.LbCategory);
            this.pForm.Controls.Add(this.label1);
            this.pForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pForm.Location = new System.Drawing.Point(0, 0);
            this.pForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(1260, 202);
            this.pForm.TabIndex = 33;
            // 
            // cbMetricUnit
            // 
            this.cbMetricUnit.FormattingEnabled = true;
            this.cbMetricUnit.Location = new System.Drawing.Point(666, 137);
            this.cbMetricUnit.Name = "cbMetricUnit";
            this.cbMetricUnit.Size = new System.Drawing.Size(166, 40);
            this.cbMetricUnit.TabIndex = 35;
            // 
            // lbMetricUnit
            // 
            this.lbMetricUnit.AutoSize = true;
            this.lbMetricUnit.Location = new System.Drawing.Point(665, 101);
            this.lbMetricUnit.Name = "lbMetricUnit";
            this.lbMetricUnit.Size = new System.Drawing.Size(157, 32);
            this.lbMetricUnit.TabIndex = 34;
            this.lbMetricUnit.Text = "Unidad de Medida";
            // 
            // iBUpload
            // 
            this.iBUpload.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBUpload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iBUpload.IconColor = System.Drawing.Color.Black;
            this.iBUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBUpload.IconSize = 24;
            this.iBUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBUpload.Location = new System.Drawing.Point(12, 135);
            this.iBUpload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.iBUpload.Name = "iBUpload";
            this.iBUpload.Size = new System.Drawing.Size(100, 32);
            this.iBUpload.TabIndex = 33;
            this.iBUpload.Text = "Subir";
            this.iBUpload.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iBUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBUpload.UseVisualStyleBackColor = true;
            // 
            // tbBarCode
            // 
            this.tbBarCode.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBarCode.Location = new System.Drawing.Point(719, 55);
            this.tbBarCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBarCode.MaxLength = 15;
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(152, 40);
            this.tbBarCode.TabIndex = 0;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPrice.Location = new System.Drawing.Point(447, 55);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(110, 40);
            this.tbPrice.TabIndex = 27;
            // 
            // tbDescProd
            // 
            this.tbDescProd.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescProd.Location = new System.Drawing.Point(877, 55);
            this.tbDescProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescProd.Multiline = true;
            this.tbDescProd.Name = "tbDescProd";
            this.tbDescProd.Size = new System.Drawing.Size(293, 121);
            this.tbDescProd.TabIndex = 21;
            // 
            // LbSubcat
            // 
            this.LbSubcat.AutoSize = true;
            this.LbSubcat.BackColor = System.Drawing.Color.Transparent;
            this.LbSubcat.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSubcat.Location = new System.Drawing.Point(391, 101);
            this.LbSubcat.Name = "LbSubcat";
            this.LbSubcat.Size = new System.Drawing.Size(120, 32);
            this.LbSubcat.TabIndex = 32;
            this.LbSubcat.Text = "Subcategoria:";
            // 
            // LbNameProd
            // 
            this.LbNameProd.AutoSize = true;
            this.LbNameProd.BackColor = System.Drawing.Color.Transparent;
            this.LbNameProd.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNameProd.Location = new System.Drawing.Point(132, 21);
            this.LbNameProd.Name = "LbNameProd";
            this.LbNameProd.Size = new System.Drawing.Size(184, 32);
            this.LbNameProd.TabIndex = 19;
            this.LbNameProd.Text = "Nombre de Producto:";
            // 
            // cbSubcat
            // 
            this.cbSubcat.Enabled = false;
            this.cbSubcat.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSubcat.FormattingEnabled = true;
            this.cbSubcat.Location = new System.Drawing.Point(391, 135);
            this.cbSubcat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubcat.Name = "cbSubcat";
            this.cbSubcat.Size = new System.Drawing.Size(268, 40);
            this.cbSubcat.TabIndex = 31;
            // 
            // tBNameProd
            // 
            this.tBNameProd.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBNameProd.Location = new System.Drawing.Point(132, 55);
            this.tBNameProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBNameProd.Name = "tBNameProd";
            this.tBNameProd.Size = new System.Drawing.Size(295, 40);
            this.tBNameProd.TabIndex = 20;
            // 
            // LbDescription
            // 
            this.LbDescription.AutoSize = true;
            this.LbDescription.BackColor = System.Drawing.Color.Transparent;
            this.LbDescription.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDescription.Location = new System.Drawing.Point(877, 21);
            this.LbDescription.Name = "LbDescription";
            this.LbDescription.Size = new System.Drawing.Size(109, 32);
            this.LbDescription.TabIndex = 22;
            this.LbDescription.Text = "Descripcion:";
            // 
            // cbBrand
            // 
            this.cbBrand.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(563, 55);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(150, 40);
            this.cbBrand.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(719, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 30;
            this.label2.Text = "Codigo de Barras:";
            // 
            // cbCateg
            // 
            this.cbCateg.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCateg.FormattingEnabled = true;
            this.cbCateg.Location = new System.Drawing.Point(132, 135);
            this.cbCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCateg.Name = "cbCateg";
            this.cbCateg.Size = new System.Drawing.Size(244, 40);
            this.cbCateg.TabIndex = 24;
            this.cbCateg.SelectedIndexChanged += new System.EventHandler(this.cbCateg_SelectedIndexChanged);
            this.cbCateg.SelectedValueChanged += new System.EventHandler(this.cbCateg_SelectedValueChanged);
            // 
            // LbMarca
            // 
            this.LbMarca.AutoSize = true;
            this.LbMarca.BackColor = System.Drawing.Color.Transparent;
            this.LbMarca.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbMarca.Location = new System.Drawing.Point(563, 21);
            this.LbMarca.Name = "LbMarca";
            this.LbMarca.Size = new System.Drawing.Size(67, 32);
            this.LbMarca.TabIndex = 25;
            this.LbMarca.Text = "Marca:";
            // 
            // LbCategory
            // 
            this.LbCategory.AutoSize = true;
            this.LbCategory.BackColor = System.Drawing.Color.Transparent;
            this.LbCategory.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCategory.Location = new System.Drawing.Point(132, 101);
            this.LbCategory.Name = "LbCategory";
            this.LbCategory.Size = new System.Drawing.Size(93, 32);
            this.LbCategory.TabIndex = 26;
            this.LbCategory.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(447, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Precio:";
            // 
            // ProductsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1260, 668);
            this.Controls.Add(this.pProduct);
            this.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(1260, 668);
            this.Name = "ProductsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductsFrm";
            this.Load += new System.EventHandler(this.ProductsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPProduct)).EndInit();
            this.pProduct.ResumeLayout(false);
            this.pGrid.ResumeLayout(false);
            this.pButtons.ResumeLayout(false);
            this.pForm.ResumeLayout(false);
            this.pForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVProducts;
        private FontAwesome.Sharp.IconPictureBox iPProduct;
        private FontAwesome.Sharp.IconButton iBAdd;
        private FontAwesome.Sharp.IconButton iBRemove;
        private FontAwesome.Sharp.IconButton iBEdit;
        private FontAwesome.Sharp.IconButton iBGuardar;
        private System.Windows.Forms.Panel pProduct;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.TextBox tbDescProd;
        private System.Windows.Forms.Label LbSubcat;
        private System.Windows.Forms.Label LbNameProd;
        private System.Windows.Forms.ComboBox cbSubcat;
        private System.Windows.Forms.TextBox tBNameProd;
        private System.Windows.Forms.Label LbDescription;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCateg;
        private System.Windows.Forms.Label LbMarca;
        private System.Windows.Forms.TextBox tbBarCode;
        private System.Windows.Forms.Label LbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private FontAwesome.Sharp.IconButton iBUpload;
        private System.Windows.Forms.ComboBox cbMetricUnit;
        private System.Windows.Forms.Label lbMetricUnit;
    }


}