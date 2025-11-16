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
    public partial class EditCategoriesForm : Form
    {
        private Form previousForm;
        private User currentUser;
        private ProductCategory choosedCategory;
        public EditCategoriesForm(Form previousForm, User currentUser, ProductCategory choosedCategory)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.currentUser = currentUser;
            this.choosedCategory = choosedCategory;
            SetupData();
        }


        void SetupData()
        {
           
            if (choosedCategory !=null)
            {
                txtBxID.Text = choosedCategory.CategoryID;
                txtBxID.ReadOnly = true;
                txtBxName.Text = choosedCategory.CategoryName;
            }
            else
            {
                txtBxID.Text = "";
                txtBxName.Text = "";
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (choosedCategory == null)
            {
                ProductCategory productCategory = new ProductCategory(

                txtBxID.Text,
                txtBxName.Text
                );
                if (ProductCategoryList.AddCategory(productCategory))
                {
                    DialogResult result = MessageBox.Show("Category added successfully! Do you want to return?", "Info", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        previousForm.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                choosedCategory.CategoryName = txtBxName.Text;
                ProductCategoryList.UpdateCategory(choosedCategory);
                DialogResult result = MessageBox.Show("Category information updated successfully! Do you want to return?", "Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    previousForm.Show();
                    this.Close();
                }
            }
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Make sure you saved change before return", "Info", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                previousForm.Show();
                this.Close();
            }
        }
    }
}
