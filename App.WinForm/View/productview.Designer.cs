namespace App.WinForm.View
{
    partial class productview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productview));
            this.tblproducts = new System.Windows.Forms.TableLayoutPanel();
            this.pnltoolbar = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.pnlfilters = new System.Windows.Forms.Panel();
            this.tblfilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.txtseaarch = new System.Windows.Forms.TextBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.cmbstockstatus = new System.Windows.Forms.ComboBox();
            this.pnlgrid = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblproducts.SuspendLayout();
            this.pnltoolbar.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pnlfilters.SuspendLayout();
            this.tblfilter.SuspendLayout();
            this.pnlgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblproducts
            // 
            this.tblproducts.ColumnCount = 1;
            this.tblproducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblproducts.Controls.Add(this.pnltoolbar, 0, 0);
            this.tblproducts.Controls.Add(this.pnlfilters, 0, 1);
            this.tblproducts.Controls.Add(this.pnlgrid, 0, 2);
            this.tblproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblproducts.Location = new System.Drawing.Point(0, 0);
            this.tblproducts.Name = "tblproducts";
            this.tblproducts.Padding = new System.Windows.Forms.Padding(16);
            this.tblproducts.RowCount = 3;
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblproducts.Size = new System.Drawing.Size(1201, 607);
            this.tblproducts.TabIndex = 0;
            // 
            // pnltoolbar
            // 
            this.pnltoolbar.BackColor = System.Drawing.Color.White;
            this.pnltoolbar.Controls.Add(this.toolStrip);
            this.pnltoolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltoolbar.Location = new System.Drawing.Point(19, 19);
            this.pnltoolbar.Name = "pnltoolbar";
            this.pnltoolbar.Size = new System.Drawing.Size(1163, 50);
            this.pnltoolbar.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton6});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1163, 50);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(74, 45);
            this.toolStripButton1.Text = "Add";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 45);
            this.toolStripButton2.Text = "Edit";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(77, 45);
            this.toolStripButton3.Text = "View";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(90, 45);
            this.toolStripButton4.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(98, 45);
            this.toolStripButton6.Text = "Refresh";
            // 
            // pnlfilters
            // 
            this.pnlfilters.BackColor = System.Drawing.Color.White;
            this.pnlfilters.Controls.Add(this.tblfilter);
            this.pnlfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfilters.Location = new System.Drawing.Point(19, 75);
            this.pnlfilters.Name = "pnlfilters";
            this.pnlfilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.pnlfilters.Size = new System.Drawing.Size(1163, 88);
            this.pnlfilters.TabIndex = 1;
            this.pnlfilters.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlfilters_Paint);
            // 
            // tblfilter
            // 
            this.tblfilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblfilter.BackColor = System.Drawing.Color.Transparent;
            this.tblfilter.ColumnCount = 3;
            this.tblfilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblfilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblfilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblfilter.Controls.Add(this.lblsearch, 0, 0);
            this.tblfilter.Controls.Add(this.lblcategory, 1, 0);
            this.tblfilter.Controls.Add(this.lblstock, 2, 0);
            this.tblfilter.Controls.Add(this.txtseaarch, 0, 1);
            this.tblfilter.Controls.Add(this.cmbcategory, 1, 1);
            this.tblfilter.Controls.Add(this.cmbstockstatus, 2, 1);
            this.tblfilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblfilter.Location = new System.Drawing.Point(12, 10);
            this.tblfilter.Name = "tblfilter";
            this.tblfilter.RowCount = 2;
            this.tblfilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblfilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblfilter.Size = new System.Drawing.Size(1139, 66);
            this.tblfilter.TabIndex = 0;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsearch.Location = new System.Drawing.Point(3, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(449, 33);
            this.lblsearch.TabIndex = 0;
            this.lblsearch.Text = "Search";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcategory.Location = new System.Drawing.Point(458, 0);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(335, 33);
            this.lblcategory.TabIndex = 1;
            this.lblcategory.Text = "Category";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblstock.Location = new System.Drawing.Point(799, 0);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(337, 33);
            this.lblstock.TabIndex = 2;
            this.lblstock.Text = "Stock Status";
            // 
            // txtseaarch
            // 
            this.txtseaarch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtseaarch.Location = new System.Drawing.Point(3, 36);
            this.txtseaarch.Name = "txtseaarch";
            this.txtseaarch.Size = new System.Drawing.Size(449, 26);
            this.txtseaarch.TabIndex = 3;
            // 
            // cmbcategory
            // 
            this.cmbcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(458, 36);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(335, 28);
            this.cmbcategory.TabIndex = 4;
            // 
            // cmbstockstatus
            // 
            this.cmbstockstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbstockstatus.FormattingEnabled = true;
            this.cmbstockstatus.Location = new System.Drawing.Point(799, 36);
            this.cmbstockstatus.Name = "cmbstockstatus";
            this.cmbstockstatus.Size = new System.Drawing.Size(337, 28);
            this.cmbstockstatus.TabIndex = 5;
            // 
            // pnlgrid
            // 
            this.pnlgrid.BackColor = System.Drawing.Color.White;
            this.pnlgrid.Controls.Add(this.dgvProducts);
            this.pnlgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlgrid.Location = new System.Drawing.Point(19, 169);
            this.pnlgrid.Name = "pnlgrid";
            this.pnlgrid.Padding = new System.Windows.Forms.Padding(12);
            this.pnlgrid.Size = new System.Drawing.Size(1163, 419);
            this.pnlgrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.colName,
            this.colCategory,
            this.colprice,
            this.colstock,
            this.colStatus});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1139, 218);
            this.dgvProducts.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.MinimumWidth = 8;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 8;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colprice
            // 
            this.colprice.HeaderText = "Price";
            this.colprice.MinimumWidth = 8;
            this.colprice.Name = "colprice";
            this.colprice.ReadOnly = true;
            // 
            // colstock
            // 
            this.colstock.HeaderText = "Stock";
            this.colstock.MinimumWidth = 8;
            this.colstock.Name = "colstock";
            this.colstock.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // productview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblproducts);
            this.Name = "productview";
            this.Size = new System.Drawing.Size(1201, 607);
            this.tblproducts.ResumeLayout(false);
            this.pnltoolbar.ResumeLayout(false);
            this.pnltoolbar.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlfilters.ResumeLayout(false);
            this.tblfilter.ResumeLayout(false);
            this.tblfilter.PerformLayout();
            this.pnlgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblproducts;
        private System.Windows.Forms.Panel pnltoolbar;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Panel pnlfilters;
        private System.Windows.Forms.TableLayoutPanel tblfilter;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.TextBox txtseaarch;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.ComboBox cmbstockstatus;
        private System.Windows.Forms.Panel pnlgrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
