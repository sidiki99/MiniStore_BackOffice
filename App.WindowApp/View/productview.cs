using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Utilities;
using App.Core.Models;
using App.WindowApp.Forms;

namespace App.WindowApp.View
{
    public partial class productview : UserControl

    {
        BindingSource dgvBindingSource = new BindingSource();
        IProductService _service;
        public productview(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = dgvBindingSource;
        }

        private void pnlfilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productview_Load(object sender, EventArgs e)
        {
            cmbcategory.Items.Clear();
            cmbcategory.Items.Add("--ALL--");
            cmbcategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbcategory.SelectedIndex = 0;

            cmbstockstatus.Items.Clear();
            cmbstockstatus.Items.Add("--ALL--");
            cmbstockstatus.Items.AddRange(Enum.GetNames(typeof(ProductCategoryStatus)));
            cmbstockstatus.SelectedIndex = 0;

            if (_service == null)
            {
                return;
            }
            _service.GetAll();
            dgvBindingSource.DataSource = _service.GetAll();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Product ? selectedProduct =dgvBindingSource.Current as Product;
            if(selectedProduct != null)
            {
                ProductForm productForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                productForm.ShowDialog();
            }

            

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm productForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                productForm.ShowDialog();
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(ProductFormModeEnum.Add, null);
            productForm.ShowDialog();
        }
    }
}
