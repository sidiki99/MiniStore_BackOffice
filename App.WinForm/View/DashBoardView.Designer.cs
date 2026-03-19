namespace App.WinForm.View
{
    partial class DashBoardView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "MS-2010",
            "Aslam",
            "20,763",
            "Pending"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "MS-2011",
            "Zain",
            "9,098",
            "Paid"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "MS-2012",
            "Haris",
            "23,456",
            "Paid"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "MS-2013",
            "Sara",
            "3,564",
            "Pending"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Notebook",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Headphone",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "HDMI",
            "7"}, -1);
            this.tbldashboard = new System.Windows.Forms.TableLayoutPanel();
            this.tblkpi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblsalesV = new System.Windows.Forms.Label();
            this.lblsalesT = new System.Windows.Forms.Label();
            this.pnlorders = new System.Windows.Forms.Panel();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.lblorderT = new System.Windows.Forms.Label();
            this.pnlresourses = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblREvenueT = new System.Windows.Forms.Label();
            this.pnlorder = new System.Windows.Forms.Panel();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.orderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlstock = new System.Windows.Forms.Panel();
            this.listViewstock = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblstock = new System.Windows.Forms.Label();
            this.tbldashboard.SuspendLayout();
            this.tblkpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlorders.SuspendLayout();
            this.pnlresourses.SuspendLayout();
            this.pnlorder.SuspendLayout();
            this.pnlstock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbldashboard
            // 
            this.tbldashboard.BackColor = System.Drawing.Color.White;
            this.tbldashboard.ColumnCount = 1;
            this.tbldashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbldashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbldashboard.Controls.Add(this.tblkpi, 0, 0);
            this.tbldashboard.Controls.Add(this.pnlorder, 0, 2);
            this.tbldashboard.Controls.Add(this.pnlstock, 0, 1);
            this.tbldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbldashboard.Location = new System.Drawing.Point(0, 0);
            this.tbldashboard.Name = "tbldashboard";
            this.tbldashboard.Padding = new System.Windows.Forms.Padding(16);
            this.tbldashboard.RowCount = 3;
            this.tbldashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tbldashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbldashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbldashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbldashboard.Size = new System.Drawing.Size(998, 475);
            this.tbldashboard.TabIndex = 0;
            this.tbldashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.tbldashboard_Paint);
            // 
            // tblkpi
            // 
            this.tblkpi.ColumnCount = 3;
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblkpi.Controls.Add(this.pnlSales, 0, 0);
            this.tblkpi.Controls.Add(this.pnlorders, 1, 0);
            this.tblkpi.Controls.Add(this.pnlresourses, 2, 0);
            this.tblkpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblkpi.Location = new System.Drawing.Point(19, 19);
            this.tblkpi.Name = "tblkpi";
            this.tblkpi.RowCount = 1;
            this.tblkpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblkpi.Size = new System.Drawing.Size(960, 114);
            this.tblkpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblsalesV);
            this.pnlSales.Controls.Add(this.lblsalesT);
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(310, 108);
            this.pnlSales.TabIndex = 0;
            this.pnlSales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSales_Paint);
            // 
            // lblsalesV
            // 
            this.lblsalesV.AutoSize = true;
            this.lblsalesV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalesV.Location = new System.Drawing.Point(228, 44);
            this.lblsalesV.Name = "lblsalesV";
            this.lblsalesV.Size = new System.Drawing.Size(39, 20);
            this.lblsalesV.TabIndex = 1;
            this.lblsalesV.Text = "168";
            // 
            // lblsalesT
            // 
            this.lblsalesT.AutoSize = true;
            this.lblsalesT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalesT.Location = new System.Drawing.Point(41, 44);
            this.lblsalesT.Name = "lblsalesT";
            this.lblsalesT.Size = new System.Drawing.Size(54, 20);
            this.lblsalesT.TabIndex = 0;
            this.lblsalesT.Text = "Sales";
            // 
            // pnlorders
            // 
            this.pnlorders.BackColor = System.Drawing.Color.White;
            this.pnlorders.Controls.Add(this.lblOrderV);
            this.pnlorders.Controls.Add(this.lblorderT);
            this.pnlorders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlorders.Location = new System.Drawing.Point(319, 3);
            this.pnlorders.Name = "pnlorders";
            this.pnlorders.Size = new System.Drawing.Size(310, 108);
            this.pnlorders.TabIndex = 1;
            this.pnlorders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlorders_Paint);
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderV.Location = new System.Drawing.Point(227, 44);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(29, 20);
            this.lblOrderV.TabIndex = 1;
            this.lblOrderV.Text = "32";
            // 
            // lblorderT
            // 
            this.lblorderT.AutoSize = true;
            this.lblorderT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderT.Location = new System.Drawing.Point(20, 44);
            this.lblorderT.Name = "lblorderT";
            this.lblorderT.Size = new System.Drawing.Size(63, 20);
            this.lblorderT.TabIndex = 0;
            this.lblorderT.Text = "Orders";
            // 
            // pnlresourses
            // 
            this.pnlresourses.BackColor = System.Drawing.Color.White;
            this.pnlresourses.Controls.Add(this.lblRevenueV);
            this.pnlresourses.Controls.Add(this.lblREvenueT);
            this.pnlresourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlresourses.Location = new System.Drawing.Point(635, 3);
            this.pnlresourses.Name = "pnlresourses";
            this.pnlresourses.Size = new System.Drawing.Size(322, 108);
            this.pnlresourses.TabIndex = 2;
            this.pnlresourses.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlresourses_Paint);
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueV.Location = new System.Drawing.Point(180, 44);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(104, 20);
            this.lblRevenueV.TabIndex = 2;
            this.lblRevenueV.Text = "37,765 PKR";
            this.lblRevenueV.Click += new System.EventHandler(this.lblRevenueV_Click);
            // 
            // lblREvenueT
            // 
            this.lblREvenueT.AutoSize = true;
            this.lblREvenueT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREvenueT.Location = new System.Drawing.Point(34, 44);
            this.lblREvenueT.Name = "lblREvenueT";
            this.lblREvenueT.Size = new System.Drawing.Size(80, 20);
            this.lblREvenueT.TabIndex = 1;
            this.lblREvenueT.Text = "Revenue";
            // 
            // pnlorder
            // 
            this.pnlorder.Controls.Add(this.listViewOrder);
            this.pnlorder.Controls.Add(this.label1);
            this.pnlorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlorder.Location = new System.Drawing.Point(19, 300);
            this.pnlorder.Name = "pnlorder";
            this.pnlorder.Size = new System.Drawing.Size(960, 156);
            this.pnlorder.TabIndex = 2;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderId,
            this.customer,
            this.total,
            this.status});
            this.listViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewOrder.Location = new System.Drawing.Point(0, 20);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(960, 136);
            this.listViewOrder.TabIndex = 1;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // orderId
            // 
            this.orderId.Text = "Order Id";
            this.orderId.Width = 100;
            // 
            // customer
            // 
            this.customer.Text = "Customer";
            this.customer.Width = 150;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 100;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent Orders";
            // 
            // pnlstock
            // 
            this.pnlstock.Controls.Add(this.listViewstock);
            this.pnlstock.Controls.Add(this.lblstock);
            this.pnlstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlstock.Location = new System.Drawing.Point(19, 139);
            this.pnlstock.Name = "pnlstock";
            this.pnlstock.Size = new System.Drawing.Size(960, 155);
            this.pnlstock.TabIndex = 3;
            // 
            // listViewstock
            // 
            this.listViewstock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.stock});
            this.listViewstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewstock.FullRowSelect = true;
            this.listViewstock.GridLines = true;
            this.listViewstock.HideSelection = false;
            this.listViewstock.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listViewstock.Location = new System.Drawing.Point(0, 20);
            this.listViewstock.Name = "listViewstock";
            this.listViewstock.Size = new System.Drawing.Size(960, 135);
            this.listViewstock.TabIndex = 1;
            this.listViewstock.UseCompatibleStateImageBehavior = false;
            this.listViewstock.View = System.Windows.Forms.View.Details;
            this.listViewstock.SelectedIndexChanged += new System.EventHandler(this.listViewstock_SelectedIndexChanged);
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 200;
            // 
            // stock
            // 
            this.stock.Text = "Stock";
            this.stock.Width = 150;
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(0, 0);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(92, 20);
            this.lblstock.TabIndex = 0;
            this.lblstock.Text = "Low Stock";
            // 
            // DashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbldashboard);
            this.Name = "DashBoardView";
            this.Size = new System.Drawing.Size(998, 475);
            this.tbldashboard.ResumeLayout(false);
            this.tblkpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlorders.ResumeLayout(false);
            this.pnlorders.PerformLayout();
            this.pnlresourses.ResumeLayout(false);
            this.pnlresourses.PerformLayout();
            this.pnlorder.ResumeLayout(false);
            this.pnlorder.PerformLayout();
            this.pnlstock.ResumeLayout(false);
            this.pnlstock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbldashboard;
        private System.Windows.Forms.TableLayoutPanel tblkpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlorders;
        private System.Windows.Forms.Panel pnlresourses;
        private System.Windows.Forms.Label lblsalesV;
        private System.Windows.Forms.Label lblsalesT;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblorderT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblREvenueT;
        private System.Windows.Forms.Panel pnlorder;
        private System.Windows.Forms.Panel pnlstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader orderId;
        private System.Windows.Forms.ColumnHeader customer;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ListView listViewstock;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader stock;
    }
}
