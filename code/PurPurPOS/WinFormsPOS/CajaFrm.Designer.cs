
namespace WinFormsPOS
{
    partial class CajaFrm
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
            this.pCheckout = new System.Windows.Forms.Panel();
            this.pBottomCheckout = new System.Windows.Forms.Panel();
            this.dgvPOS = new System.Windows.Forms.DataGridView();
            this.pGridCheckout = new System.Windows.Forms.Panel();
            this.pTopCheckout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pTotal = new System.Windows.Forms.TableLayoutPanel();
            this.lbSubtext = new System.Windows.Forms.Label();
            this.lbSubtotalAmount = new System.Windows.Forms.Label();
            this.lbtot = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.pPayChange = new System.Windows.Forms.TableLayoutPanel();
            this.lbCambio = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.lbCambioAmount = new System.Windows.Forms.Label();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.lbStatusBarcode = new System.Windows.Forms.Label();
            this.iBtnCard = new FontAwesome.Sharp.IconButton();
            this.iBtnCash = new FontAwesome.Sharp.IconButton();
            this.pCheckout.SuspendLayout();
            this.pBottomCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).BeginInit();
            this.pGridCheckout.SuspendLayout();
            this.pTopCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pTotal.SuspendLayout();
            this.pPayChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCheckout
            // 
            this.pCheckout.Controls.Add(this.pTopCheckout);
            this.pCheckout.Controls.Add(this.pGridCheckout);
            this.pCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCheckout.Location = new System.Drawing.Point(0, 0);
            this.pCheckout.Name = "pCheckout";
            this.pCheckout.Size = new System.Drawing.Size(1260, 668);
            this.pCheckout.TabIndex = 0;
            // 
            // pBottomCheckout
            // 
            this.pBottomCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pBottomCheckout.Controls.Add(this.iBtnCash);
            this.pBottomCheckout.Controls.Add(this.iBtnCard);
            this.pBottomCheckout.Controls.Add(this.pPayChange);
            this.pBottomCheckout.Controls.Add(this.pTotal);
            this.pBottomCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottomCheckout.Location = new System.Drawing.Point(0, 460);
            this.pBottomCheckout.Name = "pBottomCheckout";
            this.pBottomCheckout.Size = new System.Drawing.Size(1260, 94);
            this.pBottomCheckout.TabIndex = 0;
            // 
            // dgvPOS
            // 
            this.dgvPOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.dgvPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPOS.Location = new System.Drawing.Point(0, 0);
            this.dgvPOS.Name = "dgvPOS";
            this.dgvPOS.Size = new System.Drawing.Size(1260, 460);
            this.dgvPOS.TabIndex = 0;
            // 
            // pGridCheckout
            // 
            this.pGridCheckout.Controls.Add(this.dgvPOS);
            this.pGridCheckout.Controls.Add(this.pBottomCheckout);
            this.pGridCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pGridCheckout.Location = new System.Drawing.Point(0, 114);
            this.pGridCheckout.Margin = new System.Windows.Forms.Padding(10);
            this.pGridCheckout.Name = "pGridCheckout";
            this.pGridCheckout.Size = new System.Drawing.Size(1260, 554);
            this.pGridCheckout.TabIndex = 0;
            // 
            // pTopCheckout
            // 
            this.pTopCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pTopCheckout.Controls.Add(this.lbStatusBarcode);
            this.pTopCheckout.Controls.Add(this.button1);
            this.pTopCheckout.Controls.Add(this.iconButton1);
            this.pTopCheckout.Controls.Add(this.numericUpDown1);
            this.pTopCheckout.Controls.Add(this.tbBarCode);
            this.pTopCheckout.Controls.Add(this.comboBox1);
            this.pTopCheckout.Controls.Add(this.label2);
            this.pTopCheckout.Controls.Add(this.label1);
            this.pTopCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pTopCheckout.Location = new System.Drawing.Point(0, 30);
            this.pTopCheckout.Name = "pTopCheckout";
            this.pTopCheckout.Size = new System.Drawing.Size(1260, 84);
            this.pTopCheckout.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 40);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "ACCIONES";
            // 
            // tbBarCode
            // 
            this.tbBarCode.Location = new System.Drawing.Point(436, 30);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(245, 40);
            this.tbBarCode.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(787, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 40);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(643, 33);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 33);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pTotal
            // 
            this.pTotal.ColumnCount = 2;
            this.pTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.54148F));
            this.pTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.45852F));
            this.pTotal.Controls.Add(this.lbSubtext, 0, 0);
            this.pTotal.Controls.Add(this.lbSubtotalAmount, 1, 0);
            this.pTotal.Controls.Add(this.lbTotalAmount, 1, 1);
            this.pTotal.Controls.Add(this.lbtot, 0, 1);
            this.pTotal.Location = new System.Drawing.Point(1031, 0);
            this.pTotal.Name = "pTotal";
            this.pTotal.RowCount = 2;
            this.pTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pTotal.Size = new System.Drawing.Size(229, 94);
            this.pTotal.TabIndex = 0;
            // 
            // lbSubtext
            // 
            this.lbSubtext.AutoSize = true;
            this.lbSubtext.Location = new System.Drawing.Point(3, 0);
            this.lbSubtext.Name = "lbSubtext";
            this.lbSubtext.Size = new System.Drawing.Size(96, 32);
            this.lbSubtext.TabIndex = 0;
            this.lbSubtext.Text = "SubTotal";
            // 
            // lbSubtotalAmount
            // 
            this.lbSubtotalAmount.AutoSize = true;
            this.lbSubtotalAmount.Location = new System.Drawing.Point(105, 0);
            this.lbSubtotalAmount.Name = "lbSubtotalAmount";
            this.lbSubtotalAmount.Size = new System.Drawing.Size(26, 32);
            this.lbSubtotalAmount.TabIndex = 1;
            this.lbSubtotalAmount.Text = "$";
            // 
            // lbtot
            // 
            this.lbtot.AutoSize = true;
            this.lbtot.Location = new System.Drawing.Point(3, 47);
            this.lbtot.Name = "lbtot";
            this.lbtot.Size = new System.Drawing.Size(62, 32);
            this.lbtot.TabIndex = 2;
            this.lbtot.Text = "Total";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Location = new System.Drawing.Point(105, 47);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(26, 32);
            this.lbTotalAmount.TabIndex = 3;
            this.lbTotalAmount.Text = "$";
            // 
            // pPayChange
            // 
            this.pPayChange.ColumnCount = 2;
            this.pPayChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.87234F));
            this.pPayChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.12766F));
            this.pPayChange.Controls.Add(this.tbPayment, 1, 0);
            this.pPayChange.Controls.Add(this.lbCambio, 0, 1);
            this.pPayChange.Controls.Add(this.lbCambioAmount, 1, 1);
            this.pPayChange.Controls.Add(this.lbPago, 0, 0);
            this.pPayChange.Location = new System.Drawing.Point(790, 3);
            this.pPayChange.Name = "pPayChange";
            this.pPayChange.RowCount = 2;
            this.pPayChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pPayChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pPayChange.Size = new System.Drawing.Size(235, 91);
            this.pPayChange.TabIndex = 4;
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Location = new System.Drawing.Point(3, 45);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(81, 32);
            this.lbCambio.TabIndex = 2;
            this.lbCambio.Text = "Cambio";
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Location = new System.Drawing.Point(3, 0);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(59, 32);
            this.lbPago.TabIndex = 0;
            this.lbPago.Text = "Pago";
            // 
            // lbCambioAmount
            // 
            this.lbCambioAmount.AutoSize = true;
            this.lbCambioAmount.Location = new System.Drawing.Point(92, 45);
            this.lbCambioAmount.Name = "lbCambioAmount";
            this.lbCambioAmount.Size = new System.Drawing.Size(26, 32);
            this.lbCambioAmount.TabIndex = 3;
            this.lbCambioAmount.Text = "$";
            // 
            // tbPayment
            // 
            this.tbPayment.Location = new System.Drawing.Point(92, 3);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(134, 40);
            this.tbPayment.TabIndex = 0;
            this.tbPayment.Text = "$";
            // 
            // lbStatusBarcode
            // 
            this.lbStatusBarcode.AutoSize = true;
            this.lbStatusBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusBarcode.Location = new System.Drawing.Point(430, 0);
            this.lbStatusBarcode.Name = "lbStatusBarcode";
            this.lbStatusBarcode.Size = new System.Drawing.Size(96, 32);
            this.lbStatusBarcode.TabIndex = 7;
            this.lbStatusBarcode.Text = "Scanning";
            // 
            // iBtnCard
            // 
            this.iBtnCard.BackColor = System.Drawing.Color.Transparent;
            this.iBtnCard.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.iBtnCard.IconColor = System.Drawing.Color.Black;
            this.iBtnCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCard.IconSize = 64;
            this.iBtnCard.Location = new System.Drawing.Point(520, 0);
            this.iBtnCard.Name = "iBtnCard";
            this.iBtnCard.Size = new System.Drawing.Size(111, 94);
            this.iBtnCard.TabIndex = 5;
            this.iBtnCard.Text = "Tarjeta";
            this.iBtnCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnCard.UseVisualStyleBackColor = false;
            // 
            // iBtnCash
            // 
            this.iBtnCash.BackColor = System.Drawing.Color.Transparent;
            this.iBtnCash.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iBtnCash.IconColor = System.Drawing.Color.Black;
            this.iBtnCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCash.IconSize = 64;
            this.iBtnCash.Location = new System.Drawing.Point(646, 0);
            this.iBtnCash.Name = "iBtnCash";
            this.iBtnCash.Size = new System.Drawing.Size(112, 94);
            this.iBtnCash.TabIndex = 6;
            this.iBtnCash.Text = "Efectivo";
            this.iBtnCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnCash.UseVisualStyleBackColor = false;
            // 
            // CajaFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1260, 668);
            this.Controls.Add(this.pCheckout);
            this.Font = new System.Drawing.Font("Dubai Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CajaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CajaFrm";
            this.pCheckout.ResumeLayout(false);
            this.pBottomCheckout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).EndInit();
            this.pGridCheckout.ResumeLayout(false);
            this.pTopCheckout.ResumeLayout(false);
            this.pTopCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pTotal.ResumeLayout(false);
            this.pTotal.PerformLayout();
            this.pPayChange.ResumeLayout(false);
            this.pPayChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCheckout;
        private System.Windows.Forms.Panel pBottomCheckout;
        private System.Windows.Forms.DataGridView dgvPOS;
        private System.Windows.Forms.Panel pGridCheckout;
        private System.Windows.Forms.Panel pTopCheckout;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbBarCode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel pPayChange;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label lbCambioAmount;
        private System.Windows.Forms.Label lbPago;
        private System.Windows.Forms.TableLayoutPanel pTotal;
        private System.Windows.Forms.Label lbSubtext;
        private System.Windows.Forms.Label lbSubtotalAmount;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label lbtot;
        private System.Windows.Forms.Label lbStatusBarcode;
        private FontAwesome.Sharp.IconButton iBtnCash;
        private FontAwesome.Sharp.IconButton iBtnCard;
    }
}