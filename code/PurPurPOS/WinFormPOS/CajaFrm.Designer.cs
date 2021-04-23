
namespace WinFormPOS
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
            this.pTopCheckout = new System.Windows.Forms.Panel();
            this.lbStatusBarcode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iBtnSearchPrice = new FontAwesome.Sharp.IconButton();
            this.NumAmount = new System.Windows.Forms.NumericUpDown();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pGridCheckout = new System.Windows.Forms.Panel();
            this.dgvPOS = new System.Windows.Forms.DataGridView();
            this.pBottomCheckout = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iBtnCash = new FontAwesome.Sharp.IconButton();
            this.iBtnCard = new FontAwesome.Sharp.IconButton();
            this.pPayChange = new System.Windows.Forms.TableLayoutPanel();
            this.lbCambio = new System.Windows.Forms.Label();
            this.lbCambioAmount = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.pTotal = new System.Windows.Forms.TableLayoutPanel();
            this.lbSubtext = new System.Windows.Forms.Label();
            this.lbSubtotalAmount = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.lbtot = new System.Windows.Forms.Label();
            this.pCheckout.SuspendLayout();
            this.pTopCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmount)).BeginInit();
            this.pGridCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).BeginInit();
            this.pBottomCheckout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pPayChange.SuspendLayout();
            this.pTotal.SuspendLayout();
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
            // pTopCheckout
            // 
            this.pTopCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pTopCheckout.Controls.Add(this.lbStatusBarcode);
            this.pTopCheckout.Controls.Add(this.button1);
            this.pTopCheckout.Controls.Add(this.iBtnSearchPrice);
            this.pTopCheckout.Controls.Add(this.NumAmount);
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
            // lbStatusBarcode
            // 
            this.lbStatusBarcode.AutoSize = true;
            this.lbStatusBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusBarcode.Location = new System.Drawing.Point(443, 3);
            this.lbStatusBarcode.Name = "lbStatusBarcode";
            this.lbStatusBarcode.Size = new System.Drawing.Size(117, 32);
            this.lbStatusBarcode.TabIndex = 7;
            this.lbStatusBarcode.Text = "Escaneando";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iBtnSearchPrice
            // 
            this.iBtnSearchPrice.BackColor = System.Drawing.Color.Transparent;
            this.iBtnSearchPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnSearchPrice.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.iBtnSearchPrice.IconColor = System.Drawing.Color.Black;
            this.iBtnSearchPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearchPrice.IconSize = 32;
            this.iBtnSearchPrice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iBtnSearchPrice.Location = new System.Drawing.Point(650, 41);
            this.iBtnSearchPrice.Name = "iBtnSearchPrice";
            this.iBtnSearchPrice.Size = new System.Drawing.Size(34, 33);
            this.iBtnSearchPrice.TabIndex = 5;
            this.iBtnSearchPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBtnSearchPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnSearchPrice.UseVisualStyleBackColor = false;
            this.iBtnSearchPrice.Click += new System.EventHandler(this.iBtnSearchPrice_Click);
            // 
            // NumAmount
            // 
            this.NumAmount.Location = new System.Drawing.Point(794, 39);
            this.NumAmount.Name = "NumAmount";
            this.NumAmount.Size = new System.Drawing.Size(53, 40);
            this.NumAmount.TabIndex = 4;
            this.NumAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbBarCode
            // 
            this.tbBarCode.Location = new System.Drawing.Point(443, 38);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(245, 40);
            this.tbBarCode.TabIndex = 3;
            this.tbBarCode.Enter += new System.EventHandler(this.tbBarCode_Enter);
            this.tbBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarCode_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "ACCIONES",
            "ELIMINAR",
            "EDITAR CANTIDAD"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ELIMINAR",
            "EDITAR CANTIDAD"});
            this.comboBox1.Location = new System.Drawing.Point(32, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 40);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "ACCIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Barras";
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
            // dgvPOS
            // 
            this.dgvPOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.dgvPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPOS.Location = new System.Drawing.Point(0, 0);
            this.dgvPOS.Name = "dgvPOS";
            this.dgvPOS.Size = new System.Drawing.Size(1260, 460);
            this.dgvPOS.TabIndex = 0;
            // 
            // pBottomCheckout
            // 
            this.pBottomCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pBottomCheckout.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPayment);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(883, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 44);
            this.panel1.TabIndex = 7;
            // 
            // tbPayment
            // 
            this.tbPayment.Location = new System.Drawing.Point(31, 0);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(111, 40);
            this.tbPayment.TabIndex = 0;
            this.tbPayment.TextChanged += new System.EventHandler(this.tbPayment_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "$";
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
            // pPayChange
            // 
            this.pPayChange.ColumnCount = 2;
            this.pPayChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.87234F));
            this.pPayChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.12766F));
            this.pPayChange.Controls.Add(this.lbCambio, 0, 1);
            this.pPayChange.Controls.Add(this.lbCambioAmount, 1, 1);
            this.pPayChange.Controls.Add(this.lbPago, 0, 0);
            this.pPayChange.Location = new System.Drawing.Point(790, 3);
            this.pPayChange.Name = "pPayChange";
            this.pPayChange.RowCount = 2;
            this.pPayChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pPayChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pPayChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pPayChange.Size = new System.Drawing.Size(235, 91);
            this.pPayChange.TabIndex = 4;
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Location = new System.Drawing.Point(3, 45);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(80, 32);
            this.lbCambio.TabIndex = 2;
            this.lbCambio.Text = "Cambio";
            // 
            // lbCambioAmount
            // 
            this.lbCambioAmount.AutoSize = true;
            this.lbCambioAmount.Location = new System.Drawing.Point(92, 45);
            this.lbCambioAmount.Name = "lbCambioAmount";
            this.lbCambioAmount.Size = new System.Drawing.Size(25, 32);
            this.lbCambioAmount.TabIndex = 3;
            this.lbCambioAmount.Text = "$";
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Location = new System.Drawing.Point(3, 0);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(58, 32);
            this.lbPago.TabIndex = 0;
            this.lbPago.Text = "Pago";
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
            this.lbSubtext.Size = new System.Drawing.Size(95, 32);
            this.lbSubtext.TabIndex = 0;
            this.lbSubtext.Text = "SubTotal";
            // 
            // lbSubtotalAmount
            // 
            this.lbSubtotalAmount.AutoSize = true;
            this.lbSubtotalAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSubtotalAmount.Location = new System.Drawing.Point(104, 0);
            this.lbSubtotalAmount.Name = "lbSubtotalAmount";
            this.lbSubtotalAmount.Size = new System.Drawing.Size(25, 32);
            this.lbSubtotalAmount.TabIndex = 1;
            this.lbSubtotalAmount.Text = "$";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Location = new System.Drawing.Point(104, 47);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(25, 32);
            this.lbTotalAmount.TabIndex = 3;
            this.lbTotalAmount.Text = "$";
            // 
            // lbtot
            // 
            this.lbtot.AutoSize = true;
            this.lbtot.Location = new System.Drawing.Point(3, 47);
            this.lbtot.Name = "lbtot";
            this.lbtot.Size = new System.Drawing.Size(61, 32);
            this.lbtot.TabIndex = 2;
            this.lbtot.Text = "Total";
            // 
            // CajaFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1260, 668);
            this.Controls.Add(this.pCheckout);
            this.Font = new System.Drawing.Font("Dubai Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CajaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CajaFrm";
            this.Load += new System.EventHandler(this.CajaFrm_Load);
            this.pCheckout.ResumeLayout(false);
            this.pTopCheckout.ResumeLayout(false);
            this.pTopCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmount)).EndInit();
            this.pGridCheckout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).EndInit();
            this.pBottomCheckout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPayChange.ResumeLayout(false);
            this.pPayChange.PerformLayout();
            this.pTotal.ResumeLayout(false);
            this.pTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCheckout;
        private System.Windows.Forms.Panel pBottomCheckout;
        private System.Windows.Forms.DataGridView dgvPOS;
        private System.Windows.Forms.Panel pGridCheckout;
        private System.Windows.Forms.Panel pTopCheckout;
        private FontAwesome.Sharp.IconButton iBtnSearchPrice;
        private System.Windows.Forms.NumericUpDown NumAmount;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}