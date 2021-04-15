
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BrandImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbDescCat = new System.Windows.Forms.Label();
            this.LbCateg = new System.Windows.Forms.Label();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.tBCategory = new System.Windows.Forms.TextBox();
            this.pSubcategory = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LbDescSub = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LbSubcat = new System.Windows.Forms.Label();
            this.pCatSubcat = new System.Windows.Forms.Panel();
            this.pCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pSubcategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pCatSubcat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCategory
            // 
            this.pCategory.AutoSize = true;
            this.pCategory.Controls.Add(this.dataGridView1);
            this.pCategory.Controls.Add(this.LbDescCat);
            this.pCategory.Controls.Add(this.LbCateg);
            this.pCategory.Controls.Add(this.tBDescription);
            this.pCategory.Controls.Add(this.tBCategory);
            this.pCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCategory.Location = new System.Drawing.Point(0, 0);
            this.pCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pCategory.MinimumSize = new System.Drawing.Size(570, 400);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(570, 531);
            this.pCategory.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrandImage,
            this.BrandName,
            this.BrandDesc});
            this.dataGridView1.Location = new System.Drawing.Point(11, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(545, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(545, 360);
            this.dataGridView1.TabIndex = 6;
            // 
            // BrandImage
            // 
            this.BrandImage.HeaderText = "Image";
            this.BrandImage.Name = "BrandImage";
            this.BrandImage.ReadOnly = true;
            // 
            // BrandName
            // 
            this.BrandName.HeaderText = "Categoria";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 150;
            // 
            // BrandDesc
            // 
            this.BrandDesc.HeaderText = "Descripción";
            this.BrandDesc.Name = "BrandDesc";
            this.BrandDesc.ReadOnly = true;
            this.BrandDesc.Width = 250;
            // 
            // LbDescCat
            // 
            this.LbDescCat.AutoSize = true;
            this.LbDescCat.Location = new System.Drawing.Point(188, 20);
            this.LbDescCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbDescCat.Name = "LbDescCat";
            this.LbDescCat.Size = new System.Drawing.Size(69, 15);
            this.LbDescCat.TabIndex = 5;
            this.LbDescCat.Text = "Descripción";
            // 
            // LbCateg
            // 
            this.LbCateg.AutoSize = true;
            this.LbCateg.Location = new System.Drawing.Point(11, 20);
            this.LbCateg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbCateg.Name = "LbCateg";
            this.LbCateg.Size = new System.Drawing.Size(58, 15);
            this.LbCateg.TabIndex = 4;
            this.LbCateg.Text = "Categoria";
            // 
            // tBDescription
            // 
            this.tBDescription.Location = new System.Drawing.Point(188, 37);
            this.tBDescription.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(171, 69);
            this.tBDescription.TabIndex = 2;
            // 
            // tBCategory
            // 
            this.tBCategory.Location = new System.Drawing.Point(11, 39);
            this.tBCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tBCategory.Name = "tBCategory";
            this.tBCategory.Size = new System.Drawing.Size(175, 23);
            this.tBCategory.TabIndex = 1;
            // 
            // pSubcategory
            // 
            this.pSubcategory.AutoSize = true;
            this.pSubcategory.Controls.Add(this.dataGridView2);
            this.pSubcategory.Controls.Add(this.textBox1);
            this.pSubcategory.Controls.Add(this.LbDescSub);
            this.pSubcategory.Controls.Add(this.textBox2);
            this.pSubcategory.Controls.Add(this.LbSubcat);
            this.pSubcategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSubcategory.Location = new System.Drawing.Point(570, 0);
            this.pSubcategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pSubcategory.MinimumSize = new System.Drawing.Size(570, 400);
            this.pSubcategory.Name = "pSubcategory";
            this.pSubcategory.Size = new System.Drawing.Size(570, 531);
            this.pSubcategory.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(12, 117);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView2.MinimumSize = new System.Drawing.Size(545, 360);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(546, 360);
            this.dataGridView2.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Image";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Subcategoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 69);
            this.textBox1.TabIndex = 8;
            // 
            // LbDescSub
            // 
            this.LbDescSub.AutoSize = true;
            this.LbDescSub.Location = new System.Drawing.Point(189, 20);
            this.LbDescSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbDescSub.Name = "LbDescSub";
            this.LbDescSub.Size = new System.Drawing.Size(69, 15);
            this.LbDescSub.TabIndex = 10;
            this.LbDescSub.Text = "Descripción";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 23);
            this.textBox2.TabIndex = 7;
            // 
            // LbSubcat
            // 
            this.LbSubcat.AutoSize = true;
            this.LbSubcat.Location = new System.Drawing.Point(12, 20);
            this.LbSubcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSubcat.Name = "LbSubcat";
            this.LbSubcat.Size = new System.Drawing.Size(76, 15);
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
            this.pCatSubcat.Size = new System.Drawing.Size(1147, 531);
            this.pCatSubcat.TabIndex = 5;
            // 
            // CategoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 531);
            this.Controls.Add(this.pCatSubcat);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "CategoryFrm";
            this.Text = "CategoryFrm";
            this.pCategory.ResumeLayout(false);
            this.pCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pSubcategory.ResumeLayout(false);
            this.pSubcategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pCatSubcat.ResumeLayout(false);
            this.pCatSubcat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCategory;
        private System.Windows.Forms.Panel pSubcategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LbDescCat;
        private System.Windows.Forms.Label LbCateg;
        private System.Windows.Forms.TextBox tBDescription;
        private System.Windows.Forms.TextBox tBCategory;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LbDescSub;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LbSubcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel pCatSubcat;
    
    }
}