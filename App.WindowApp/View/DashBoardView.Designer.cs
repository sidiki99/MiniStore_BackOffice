using System.Windows.Forms;
namespace App.WindowApp.View
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "MS-2010", "Aslam", "20,763", "Pending" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "MS-2011", "Zain", "9,098", "Paid" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "MS-2012", "Haris", "23,456", "Paid" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "MS-2013", "Sara", "3,564", "Pending" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Notebook", "5" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Headphone", "10" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "HDMI", "7" }, -1);
            tbldashboard = new TableLayoutPanel();
            tblkpi = new TableLayoutPanel();
            pnlSales = new Panel();
            lblsalesV = new Label();
            lblsalesT = new Label();
            pnlorders = new Panel();
            lblOrderV = new Label();
            lblorderT = new Label();
            pnlresourses = new Panel();
            lblRevenueV = new Label();
            lblREvenueT = new Label();
            pnlorder = new Panel();
            listViewOrder = new ListView();
            orderId = new ColumnHeader();
            customer = new ColumnHeader();
            total = new ColumnHeader();
            status = new ColumnHeader();
            label1 = new Label();
            pnlstock = new Panel();
            listViewstock = new ListView();
            Product = new ColumnHeader();
            stock = new ColumnHeader();
            lblstock = new Label();
            tbldashboard.SuspendLayout();
            tblkpi.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlorders.SuspendLayout();
            pnlresourses.SuspendLayout();
            pnlorder.SuspendLayout();
            pnlstock.SuspendLayout();
            SuspendLayout();
            // 
            // tbldashboard
            // 
            tbldashboard.BackColor = Color.White;
            tbldashboard.ColumnCount = 1;
            tbldashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbldashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbldashboard.Controls.Add(tblkpi, 0, 0);
            tbldashboard.Controls.Add(pnlorder, 0, 2);
            tbldashboard.Controls.Add(pnlstock, 0, 1);
            tbldashboard.Dock = DockStyle.Fill;
            tbldashboard.Location = new Point(0, 0);
            tbldashboard.Margin = new Padding(3, 4, 3, 4);
            tbldashboard.Name = "tbldashboard";
            tbldashboard.Padding = new Padding(18, 20, 18, 20);
            tbldashboard.RowCount = 3;
            tbldashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tbldashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbldashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbldashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tbldashboard.Size = new Size(1109, 594);
            tbldashboard.TabIndex = 0;
            tbldashboard.Paint += tbldashboard_Paint;
            // 
            // tblkpi
            // 
            tblkpi.ColumnCount = 3;
            tblkpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblkpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblkpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tblkpi.Controls.Add(pnlSales, 0, 0);
            tblkpi.Controls.Add(pnlorders, 1, 0);
            tblkpi.Controls.Add(pnlresourses, 2, 0);
            tblkpi.Dock = DockStyle.Fill;
            tblkpi.Location = new Point(21, 24);
            tblkpi.Margin = new Padding(3, 4, 3, 4);
            tblkpi.Name = "tblkpi";
            tblkpi.RowCount = 1;
            tblkpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblkpi.Size = new Size(1067, 142);
            tblkpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblsalesV);
            pnlSales.Controls.Add(lblsalesT);
            pnlSales.Dock = DockStyle.Fill;
            pnlSales.Location = new Point(3, 4);
            pnlSales.Margin = new Padding(3, 4, 3, 4);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(346, 134);
            pnlSales.TabIndex = 0;
            pnlSales.Paint += pnlSales_Paint;
            // 
            // lblsalesV
            // 
            lblsalesV.AutoSize = true;
            lblsalesV.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsalesV.Location = new Point(253, 55);
            lblsalesV.Name = "lblsalesV";
            lblsalesV.Size = new Size(39, 20);
            lblsalesV.TabIndex = 1;
            lblsalesV.Text = "168";
            // 
            // lblsalesT
            // 
            lblsalesT.AutoSize = true;
            lblsalesT.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsalesT.Location = new Point(46, 55);
            lblsalesT.Name = "lblsalesT";
            lblsalesT.Size = new Size(54, 20);
            lblsalesT.TabIndex = 0;
            lblsalesT.Text = "Sales";
            // 
            // pnlorders
            // 
            pnlorders.BackColor = Color.White;
            pnlorders.Controls.Add(lblOrderV);
            pnlorders.Controls.Add(lblorderT);
            pnlorders.Dock = DockStyle.Fill;
            pnlorders.Location = new Point(355, 4);
            pnlorders.Margin = new Padding(3, 4, 3, 4);
            pnlorders.Name = "pnlorders";
            pnlorders.Size = new Size(346, 134);
            pnlorders.TabIndex = 1;
            pnlorders.Paint += pnlorders_Paint;
            // 
            // lblOrderV
            // 
            lblOrderV.AutoSize = true;
            lblOrderV.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderV.Location = new Point(252, 55);
            lblOrderV.Name = "lblOrderV";
            lblOrderV.Size = new Size(29, 20);
            lblOrderV.TabIndex = 1;
            lblOrderV.Text = "32";
            // 
            // lblorderT
            // 
            lblorderT.AutoSize = true;
            lblorderT.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblorderT.Location = new Point(22, 55);
            lblorderT.Name = "lblorderT";
            lblorderT.Size = new Size(63, 20);
            lblorderT.TabIndex = 0;
            lblorderT.Text = "Orders";
            // 
            // pnlresourses
            // 
            pnlresourses.BackColor = Color.White;
            pnlresourses.Controls.Add(lblRevenueV);
            pnlresourses.Controls.Add(lblREvenueT);
            pnlresourses.Dock = DockStyle.Fill;
            pnlresourses.Location = new Point(707, 4);
            pnlresourses.Margin = new Padding(3, 4, 3, 4);
            pnlresourses.Name = "pnlresourses";
            pnlresourses.Size = new Size(357, 134);
            pnlresourses.TabIndex = 2;
            pnlresourses.Paint += pnlresourses_Paint;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueV.Location = new Point(200, 55);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(104, 20);
            lblRevenueV.TabIndex = 2;
            lblRevenueV.Text = "37,765 PKR";
            lblRevenueV.Click += lblRevenueV_Click;
            // 
            // lblREvenueT
            // 
            lblREvenueT.AutoSize = true;
            lblREvenueT.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblREvenueT.Location = new Point(38, 55);
            lblREvenueT.Name = "lblREvenueT";
            lblREvenueT.Size = new Size(80, 20);
            lblREvenueT.TabIndex = 1;
            lblREvenueT.Text = "Revenue";
            // 
            // pnlorder
            // 
            pnlorder.Controls.Add(listViewOrder);
            pnlorder.Controls.Add(label1);
            pnlorder.Dock = DockStyle.Fill;
            pnlorder.Location = new Point(21, 376);
            pnlorder.Margin = new Padding(3, 4, 3, 4);
            pnlorder.Name = "pnlorder";
            pnlorder.Size = new Size(1067, 194);
            pnlorder.TabIndex = 2;
            // 
            // listViewOrder
            // 
            listViewOrder.Columns.AddRange(new ColumnHeader[] { orderId, customer, total, status });
            listViewOrder.Dock = DockStyle.Fill;
            listViewOrder.FullRowSelect = true;
            listViewOrder.GridLines = true;
            listViewOrder.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listViewOrder.Location = new Point(0, 20);
            listViewOrder.Margin = new Padding(3, 4, 3, 4);
            listViewOrder.Name = "listViewOrder";
            listViewOrder.Size = new Size(1067, 174);
            listViewOrder.TabIndex = 1;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // orderId
            // 
            orderId.Text = "Order Id";
            orderId.Width = 100;
            // 
            // customer
            // 
            customer.Text = "Customer";
            customer.Width = 150;
            // 
            // total
            // 
            total.Text = "Total";
            total.Width = 100;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Recent Orders";
            // 
            // pnlstock
            // 
            pnlstock.Controls.Add(listViewstock);
            pnlstock.Controls.Add(lblstock);
            pnlstock.Dock = DockStyle.Fill;
            pnlstock.Location = new Point(21, 174);
            pnlstock.Margin = new Padding(3, 4, 3, 4);
            pnlstock.Name = "pnlstock";
            pnlstock.Size = new Size(1067, 194);
            pnlstock.TabIndex = 3;
            // 
            // listViewstock
            // 
            listViewstock.Columns.AddRange(new ColumnHeader[] { Product, stock });
            listViewstock.Dock = DockStyle.Fill;
            listViewstock.FullRowSelect = true;
            listViewstock.GridLines = true;
            listViewstock.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6, listViewItem7 });
            listViewstock.Location = new Point(0, 20);
            listViewstock.Margin = new Padding(3, 4, 3, 4);
            listViewstock.Name = "listViewstock";
            listViewstock.Size = new Size(1067, 174);
            listViewstock.TabIndex = 1;
            listViewstock.UseCompatibleStateImageBehavior = false;
            listViewstock.View = System.Windows.Forms.View.Details;
            listViewstock.SelectedIndexChanged += listViewstock_SelectedIndexChanged;
            // 
            // Product
            // 
            Product.Text = "Product";
            Product.Width = 200;
            // 
            // stock
            // 
            stock.Text = "Stock";
            stock.Width = 150;
            // 
            // lblstock
            // 
            lblstock.AutoSize = true;
            lblstock.Dock = DockStyle.Top;
            lblstock.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstock.Location = new Point(0, 0);
            lblstock.Name = "lblstock";
            lblstock.Size = new Size(92, 20);
            lblstock.TabIndex = 0;
            lblstock.Text = "Low Stock";
            // 
            // DashBoardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbldashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashBoardView";
            Size = new Size(1109, 594);
            tbldashboard.ResumeLayout(false);
            tblkpi.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlorders.ResumeLayout(false);
            pnlorders.PerformLayout();
            pnlresourses.ResumeLayout(false);
            pnlresourses.PerformLayout();
            pnlorder.ResumeLayout(false);
            pnlorder.PerformLayout();
            pnlstock.ResumeLayout(false);
            pnlstock.PerformLayout();
            ResumeLayout(false);

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
