namespace InventorySystem
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.label1 = new System.Windows.Forms.Label();
            this.custIDCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custNmCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pIDComb = new System.Windows.Forms.ComboBox();
            this.pNmCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.addCart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.billAmnt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalAm = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.unitP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.avlQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.invDTPicker = new System.Windows.Forms.DateTimePicker();
            this.invNO = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PrintDoc = new System.Windows.Forms.Button();
            this.printPreview = new System.Windows.Forms.Button();
            this.DVprintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.DVprintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID :";
            // 
            // custIDCombo
            // 
            this.custIDCombo.FormattingEnabled = true;
            this.custIDCombo.Location = new System.Drawing.Point(146, 35);
            this.custIDCombo.Name = "custIDCombo";
            this.custIDCombo.Size = new System.Drawing.Size(175, 21);
            this.custIDCombo.TabIndex = 1;
            this.custIDCombo.SelectedIndexChanged += new System.EventHandler(this.custIDCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name :";
            // 
            // custNmCombo
            // 
            this.custNmCombo.FormattingEnabled = true;
            this.custNmCombo.Location = new System.Drawing.Point(146, 77);
            this.custNmCombo.Name = "custNmCombo";
            this.custNmCombo.Size = new System.Drawing.Size(175, 21);
            this.custNmCombo.TabIndex = 3;
            this.custNmCombo.SelectedIndexChanged += new System.EventHandler(this.custNmCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Name :";
            // 
            // pIDComb
            // 
            this.pIDComb.FormattingEnabled = true;
            this.pIDComb.Location = new System.Drawing.Point(518, 38);
            this.pIDComb.Name = "pIDComb";
            this.pIDComb.Size = new System.Drawing.Size(179, 21);
            this.pIDComb.TabIndex = 6;
            this.pIDComb.SelectedIndexChanged += new System.EventHandler(this.pIDComb_SelectedIndexChanged);
            // 
            // pNmCombo
            // 
            this.pNmCombo.FormattingEnabled = true;
            this.pNmCombo.Location = new System.Drawing.Point(518, 84);
            this.pNmCombo.Name = "pNmCombo";
            this.pNmCombo.Size = new System.Drawing.Size(179, 21);
            this.pNmCombo.TabIndex = 7;
            this.pNmCombo.SelectedIndexChanged += new System.EventHandler(this.pNmCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity :";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(146, 155);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(84, 20);
            this.qty.TabIndex = 9;
            // 
            // addCart
            // 
            this.addCart.ForeColor = System.Drawing.Color.Black;
            this.addCart.Location = new System.Drawing.Point(616, 194);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(75, 23);
            this.addCart.TabIndex = 10;
            this.addCart.Text = "Add to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Invoice Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bill Amount";
            // 
            // billAmnt
            // 
            this.billAmnt.Enabled = false;
            this.billAmnt.Location = new System.Drawing.Point(146, 538);
            this.billAmnt.Name = "billAmnt";
            this.billAmnt.Size = new System.Drawing.Size(113, 20);
            this.billAmnt.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Discount";
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(146, 584);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(113, 20);
            this.discount.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(367, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Amount";
            // 
            // totalAm
            // 
            this.totalAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAm.Location = new System.Drawing.Point(333, 579);
            this.totalAm.Name = "totalAm";
            this.totalAm.Size = new System.Drawing.Size(164, 26);
            this.totalAm.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(578, 572);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 30);
            this.button4.TabIndex = 22;
            this.button4.Text = "CONFIRM";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Unit Price :";
            // 
            // unitP
            // 
            this.unitP.Enabled = false;
            this.unitP.Location = new System.Drawing.Point(146, 116);
            this.unitP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitP.Name = "unitP";
            this.unitP.Size = new System.Drawing.Size(84, 20);
            this.unitP.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Vat :";
            // 
            // vat
            // 
            this.vat.Enabled = false;
            this.vat.Location = new System.Drawing.Point(146, 233);
            this.vat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(84, 20);
            this.vat.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pID,
            this.pName,
            this.quant,
            this.UnitPrice,
            this.vta,
            this.ammnt});
            this.dataGridView1.Location = new System.Drawing.Point(81, 277);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(646, 213);
            this.dataGridView1.TabIndex = 28;
            // 
            // pID
            // 
            this.pID.HeaderText = "Product ID";
            this.pID.Name = "pID";
            this.pID.ReadOnly = true;
            // 
            // pName
            // 
            this.pName.HeaderText = "Product Name";
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            // 
            // quant
            // 
            this.quant.HeaderText = "Quantity";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // vta
            // 
            this.vta.HeaderText = "Vat";
            this.vta.Name = "vta";
            this.vta.ReadOnly = true;
            // 
            // ammnt
            // 
            this.ammnt.HeaderText = "Amount";
            this.ammnt.Name = "ammnt";
            this.ammnt.ReadOnly = true;
            // 
            // bill
            // 
            this.bill.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.ForeColor = System.Drawing.Color.Red;
            this.bill.Location = new System.Drawing.Point(347, 493);
            this.bill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(55, 25);
            this.bill.TabIndex = 30;
            this.bill.Text = "Net Bill";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 31;
            this.button2.Text = "Complete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // avlQty
            // 
            this.avlQty.Enabled = false;
            this.avlQty.Location = new System.Drawing.Point(146, 194);
            this.avlQty.Name = "avlQty";
            this.avlQty.Size = new System.Drawing.Size(84, 20);
            this.avlQty.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Available Quantity :";
            // 
            // invDTPicker
            // 
            this.invDTPicker.Enabled = false;
            this.invDTPicker.Location = new System.Drawing.Point(518, 130);
            this.invDTPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invDTPicker.Name = "invDTPicker";
            this.invDTPicker.Size = new System.Drawing.Size(179, 20);
            this.invDTPicker.TabIndex = 34;
            // 
            // invNO
            // 
            this.invNO.Enabled = false;
            this.invNO.Location = new System.Drawing.Point(313, 233);
            this.invNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invNO.Name = "invNO";
            this.invNO.Size = new System.Drawing.Size(185, 20);
            this.invNO.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(378, 209);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 14);
            this.label13.TabIndex = 36;
            this.label13.Text = "Clear";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // PrintDoc
            // 
            this.PrintDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintDoc.BackgroundImage")));
            this.PrintDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintDoc.Location = new System.Drawing.Point(677, 572);
            this.PrintDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrintDoc.Name = "PrintDoc";
            this.PrintDoc.Size = new System.Drawing.Size(50, 29);
            this.PrintDoc.TabIndex = 37;
            this.PrintDoc.UseVisualStyleBackColor = true;
            this.PrintDoc.Click += new System.EventHandler(this.PrintDoc_Click);
            // 
            // printPreview
            // 
            this.printPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printPreview.BackgroundImage")));
            this.printPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printPreview.Location = new System.Drawing.Point(758, 572);
            this.printPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(51, 30);
            this.printPreview.TabIndex = 38;
            this.printPreview.UseVisualStyleBackColor = true;
            this.printPreview.Click += new System.EventHandler(this.printPreview_Click);
            // 
            // DVprintPreviewDialog1
            // 
            this.DVprintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVprintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVprintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.DVprintPreviewDialog1.Document = this.DVprintDocument1;
            this.DVprintPreviewDialog1.Enabled = true;
            this.DVprintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("DVprintPreviewDialog1.Icon")));
            this.DVprintPreviewDialog1.Name = "DVprintPreviewDialog1";
            this.DVprintPreviewDialog1.Visible = false;
            // 
            // DVprintDocument1
            // 
            this.DVprintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DVprintDocument1_PrintPage);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(934, 675);
            this.Controls.Add(this.printPreview);
            this.Controls.Add(this.PrintDoc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.invNO);
            this.Controls.Add(this.invDTPicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.avlQty);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.unitP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.totalAm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.billAmnt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addCart);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pNmCombo);
            this.Controls.Add(this.pIDComb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.custNmCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custIDCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sell";
            this.Text = "Sell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sell_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox custIDCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox custNmCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pIDComb;
        private System.Windows.Forms.ComboBox pNmCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox billAmnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalAm;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox unitP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn vta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammnt;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox avlQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker invDTPicker;
        private System.Windows.Forms.TextBox invNO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button PrintDoc;
        private System.Windows.Forms.Button printPreview;
        private System.Windows.Forms.PrintPreviewDialog DVprintPreviewDialog1;
        private System.Drawing.Printing.PrintDocument DVprintDocument1;
    }
}