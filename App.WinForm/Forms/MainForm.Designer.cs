namespace App.WinForm.Forms
    {
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlheader = new System.Windows.Forms.Panel();
            this.flpright = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeladmin = new System.Windows.Forms.Label();
            this.flpleft = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.flpnav = new System.Windows.Forms.FlowLayoutPanel();
            this.btndashboard = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnlogs = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlheader.SuspendLayout();
            this.flpright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flpleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlsidebar.SuspendLayout();
            this.flpnav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlheader.Controls.Add(this.flpright);
            this.pnlheader.Controls.Add(this.flpleft);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1560, 84);
            this.pnlheader.TabIndex = 0;
            // 
            // flpright
            // 
            this.flpright.Controls.Add(this.pictureBox1);
            this.flpright.Controls.Add(this.labeladmin);
            this.flpright.Location = new System.Drawing.Point(1360, 3);
            this.flpright.Name = "flpright";
            this.flpright.Size = new System.Drawing.Size(200, 81);
            this.flpright.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(70, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labeladmin
            // 
            this.labeladmin.AutoSize = true;
            this.labeladmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladmin.Location = new System.Drawing.Point(79, 20);
            this.labeladmin.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.labeladmin.Name = "labeladmin";
            this.labeladmin.Size = new System.Drawing.Size(59, 20);
            this.labeladmin.TabIndex = 1;
            this.labeladmin.Text = "Admin";
            this.labeladmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpleft
            // 
            this.flpleft.Controls.Add(this.pictureBox2);
            this.flpleft.Location = new System.Drawing.Point(0, 0);
            this.flpleft.Name = "flpleft";
            this.flpleft.Size = new System.Drawing.Size(231, 84);
            this.flpleft.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(228, 81);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(229, 85);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1331, 318);
            this.pnlContainer.TabIndex = 1;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1560, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlsidebar
            // 
            this.pnlsidebar.Controls.Add(this.flpnav);
            this.pnlsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidebar.Location = new System.Drawing.Point(0, 84);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(231, 338);
            this.pnlsidebar.TabIndex = 2;
            // 
            // flpnav
            // 
            this.flpnav.BackColor = System.Drawing.Color.White;
            this.flpnav.Controls.Add(this.btndashboard);
            this.flpnav.Controls.Add(this.btnproducts);
            this.flpnav.Controls.Add(this.btnorders);
            this.flpnav.Controls.Add(this.btnlogs);
            this.flpnav.Controls.Add(this.btnsetting);
            this.flpnav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnav.Location = new System.Drawing.Point(0, 0);
            this.flpnav.Name = "flpnav";
            this.flpnav.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.flpnav.Size = new System.Drawing.Size(228, 316);
            this.flpnav.TabIndex = 0;
            // 
            // btndashboard
            // 
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(25, 25);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(200, 40);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "  Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndashboard.UseCompatibleTextRendering = true;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.FlatAppearance.BorderSize = 0;
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducts.Location = new System.Drawing.Point(25, 75);
            this.btnproducts.Margin = new System.Windows.Forms.Padding(5);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(157, 36);
            this.btnproducts.TabIndex = 1;
            this.btnproducts.Text = "Products";
            this.btnproducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproducts.UseVisualStyleBackColor = true;
            this.btnproducts.Click += new System.EventHandler(this.btnproducts_Click);
            // 
            // btnorders
            // 
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.Location = new System.Drawing.Point(25, 121);
            this.btnorders.Margin = new System.Windows.Forms.Padding(5);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(165, 48);
            this.btnorders.TabIndex = 2;
            this.btnorders.Text = "Orders";
            this.btnorders.UseVisualStyleBackColor = true;
            // 
            // btnlogs
            // 
            this.btnlogs.FlatAppearance.BorderSize = 0;
            this.btnlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogs.Location = new System.Drawing.Point(25, 179);
            this.btnlogs.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogs.Name = "btnlogs";
            this.btnlogs.Size = new System.Drawing.Size(157, 51);
            this.btnlogs.TabIndex = 3;
            this.btnlogs.Text = "Logs";
            this.btnlogs.UseVisualStyleBackColor = true;
            // 
            // btnsetting
            // 
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.ImageKey = "(none)";
            this.btnsetting.Location = new System.Drawing.Point(25, 240);
            this.btnsetting.Margin = new System.Windows.Forms.Padding(5);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(165, 50);
            this.btnsetting.TabIndex = 4;
            this.btnsetting.Text = "Setting";
            this.btnsetting.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlsidebar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlheader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlheader.ResumeLayout(false);
            this.flpright.ResumeLayout(false);
            this.flpright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flpleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlsidebar.ResumeLayout(false);
            this.flpnav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlsidebar;
        private System.Windows.Forms.FlowLayoutPanel flpright;
        private System.Windows.Forms.FlowLayoutPanel flpleft;
        private System.Windows.Forms.FlowLayoutPanel flpnav;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeladmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
    }
}