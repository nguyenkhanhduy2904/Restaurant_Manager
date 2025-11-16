using Microsoft.VisualBasic;
using RestaurantManager.Models;
using RestaurantManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.Forms
{
    public partial class ManageProductsForm : Form
    {
        private User currentUser;
        private Form previousForm;
        public ManageProductsForm(Form previousForm, User currentUser)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.currentUser = currentUser;
            //ProductList.InitProductListData();
            SetupControls();
            LoadAllProducts();
        }

        void SetupControls()
        {
            lbUserName.Text = $"{currentUser.UserName}!";
        }


        void LoadAllProducts()
        {
            ProductCategoryList.InitCategoryListData();
            ProductList.InitProductListData();
            dgvProductsList.Rows.Clear();
            foreach (var product in ProductList.Products)
            {

                int index = dgvProductsList.Rows.Add(product.ProductID, product.ProductName, product.Price, product.Category.CategoryName, product.IsAvailable ? "Yes" : "No");
                dgvProductsList.Rows[index].Tag = product;
            }
        }

        private Product GetSelectedProduct()
        {
            if (dgvProductsList.CurrentRow != null)
            {
                return dgvProductsList.CurrentRow.Tag as Product;
            }
            else
            {
                MessageBox.Show("No product selected", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ProductCategoryList.Categories.Count == 0 || ProductCategoryList.Categories == null)
            {
                DialogResult result = MessageBox.Show("There are no Categories exist, Do you want to create a new Category first", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    EditCategoriesForm editCategoriesForm = new EditCategoriesForm(this, currentUser, null);
                    editCategoriesForm.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    return;
                }
            }
            EditProductForm editProductForm = new EditProductForm(null, currentUser, this);
            editProductForm.Show();
            this.Hide();
        }

        private void ManageProductsForm_Activated(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            if (selectedProduct != null)
            {
                //if (!Constant.isDeleteProductWarningSkipped)
                //{
                //    DialogResult res = MessageBox.Show($"Are you sure you need to delete this product :{selectedProduct.ProductName}?\n You can set isAvailable = false for safer data integrity.\nDo you want to skip this warning for future action?", "Warning", MessageBoxButtons.YesNo);
                //    if (res == DialogResult.Yes)
                //    {
                //        Constant.isDeleteProductWarningSkipped = true;
                //    }
                //}





                DialogResult result = MessageBox.Show($"Are you sure you want to delete product: {selectedProduct.ProductName}? ", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ProductList.DeleteProduct(selectedProduct);
                    LoadAllProducts();
                }
            }
        }
    }
}
