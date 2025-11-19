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

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.StartPosition = FormStartPosition.CenterScreen;

            //// Optional fixed size:
            //this.Size = new Size(1366, 768);

            Helper.SetFixedFormSize(this, Constant.BIG_WINDOW_WIDTH, Constant.BIG_WINDOW_HEIGHT);
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
                cbxCategory.ValueMember = "CategoryID";

                cbxCategory.SelectedValue = choosedProduct.Category.CategoryID;
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


            if (choosedProduct == null)
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
            else
            {
                choosedProduct.ProductName = txtBxName.Text;
                choosedProduct.Price = price;
                choosedProduct.Category = selectedCategory;
                choosedProduct.IsAvailable = isAvailable;
                ProductList.UpdateProduct(choosedProduct);
                DialogResult result = MessageBox.Show("Product information updated successfully! Do you want to return?", "Success", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    previousForm.Show();
                    this.Close();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();

        }
    }
}
