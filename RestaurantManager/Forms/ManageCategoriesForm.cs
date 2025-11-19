using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using RestaurantManager.Models;
using RestaurantManager.Utils;

namespace RestaurantManager.Forms
{
    public partial class ManageCategoriesForm : Form
    {
        private User currentUser;
        private Form previousForm;
        public ManageCategoriesForm(User currentUser, Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            ProductCategoryList.InitCategoryListData();
            LoadAllCategories();
            AssignData(currentUser);
            SetupControls();

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.StartPosition = FormStartPosition.CenterScreen;

            //// Optional fixed size:
            //this.Size = new Size(1366, 768);

            Helper.SetFixedFormSize(this, Constant.BIG_WINDOW_WIDTH, Constant.BIG_WINDOW_HEIGHT);
        }

        void AssignData(User currentUser)
        {
            this.currentUser = currentUser;
        }
        void SetupControls()
        {
            lbUserName.Text = $"{currentUser.UserName}!";
        }
        void LoadAllCategories()
        {

            dgvCategoriesList.Rows.Clear();

            foreach (var category in ProductCategoryList.Categories)
            {
                int index = dgvCategoriesList.Rows.Add(category.CategoryID, category.CategoryName);
                dgvCategoriesList.Rows[index].Tag = category;
            }

        }
        private ProductCategory GetSelectedCategory()
        {
            if (dgvCategoriesList.CurrentRow != null)
            {
                return dgvCategoriesList.CurrentRow.Tag as ProductCategory;
            }
            else
            {
                MessageBox.Show("No category selected", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EditCategoriesForm editCategoriesForm = new EditCategoriesForm(this, currentUser, null);
            editCategoriesForm.Show();
            this.Hide();
        }

        private void ManageCategoriesForm_Activated(object sender, EventArgs e)
        {
            LoadAllCategories();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedCategory = GetSelectedCategory();
            if (selectedCategory != null)
            {
                EditCategoriesForm editCategoriesForm = new EditCategoriesForm(this, currentUser, selectedCategory);
                editCategoriesForm.Show();
                this.Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedCategory = GetSelectedCategory();
            if (selectedCategory.CategoryID == Constant.DEFAULT_CATEGORY_ID)
            {
                MessageBox.Show("You cannot delete the default category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedCategory != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete category '{selectedCategory.CategoryName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ProductCategoryList.DeleteCategory(selectedCategory);
                    LoadAllCategories();
                    
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
