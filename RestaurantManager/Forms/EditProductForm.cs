using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManager.Models;
namespace RestaurantManager.Forms
{
    public partial class EditProductForm : Form
    {

        private User currentUser;
        private Form previousForm;
        private Product choosedProduct;

        public EditProductForm(Product choosedProduct, User currentUser, Form previousForm)
        {
            InitializeComponent();
            this.choosedProduct = choosedProduct;
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            SetupData();
        }

        void SetupData()
        {
            lbUserName.Text = $"{currentUser.UserName}!";
            if (choosedProduct != null)
            {
                txtBxID.Text = choosedProduct.ProductID;
                txtBxID.ReadOnly = true;
                txtBxName.Text = choosedProduct.ProductName;
                txtBxPrice.Text = choosedProduct.Price.ToString();
                cbxCategory.DataSource = ProductCategoryList.Categories;
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.SelectedItem = choosedProduct.Category;
                radTrue.Checked = choosedProduct.IsAvailable;
                radFalse.Checked = !choosedProduct.IsAvailable;
            }
            else
            {
                txtBxID.Text = "";
                txtBxName.Text = "";
                txtBxPrice.Text = "0";
                cbxCategory.DataSource = ProductCategoryList.Categories;
                cbxCategory.DisplayMember = "CategoryName";
                radTrue.Checked = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal price;
            if (!decimal.TryParse(txtBxPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK);
                return;
            }

            ProductCategory selectedCategory = cbxCategory.SelectedItem as ProductCategory;
            if (selectedCategory == null)
            {
                MessageBox.Show("Please choose a category.", "Error", MessageBoxButtons.OK);
                return;
            }
            bool isAvailable = radTrue.Checked;
           

            if (choosedProduct== null)
            {

                Product newProduct = new Product(
                    txtBxID.Text,
                    txtBxName.Text,
                    price,
                    selectedCategory,
                    isAvailable
                    );
                if (ProductList.AddProduct(newProduct))
                {
                    DialogResult result = MessageBox.Show("Product added successfully! Do you want to return?", "Success", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        previousForm.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
