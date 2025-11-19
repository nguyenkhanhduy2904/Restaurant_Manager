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
    public partial class AdminForm : Form
    {
        private Form previousForm;
        private User currentUser;
        string username;
        public AdminForm(User user, Form previousForm)
        {
            InitializeComponent();
            SetupData(user);
            AssignData();
            SetupControls();
            this.previousForm = previousForm;

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.StartPosition = FormStartPosition.CenterScreen;

            //// Optional fixed size:
            //this.Size = new Size(1366, 768);

            Helper.SetFixedFormSize(this, Constant.BIG_WINDOW_WIDTH, Constant.BIG_WINDOW_HEIGHT);
        }

        void SetupData(User user)
        {
            currentUser = user;
        }

        void AssignData()
        {
            username = currentUser.UserName;
        }

        void SetupControls()
        {
            lbUserName.Text = $"Hello, {username}!";
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm(currentUser, this);
            manageUsersForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProductsForm manageProductsForm = new ManageProductsForm(this, currentUser);
            manageProductsForm.Show();
            this.Hide();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            ManageCategoriesForm manageCategoriesForm = new ManageCategoriesForm(currentUser, this);
            manageCategoriesForm.Show();
            this.Hide();
        }

        private void btnManageTableType_Click(object sender, EventArgs e)
        {
            ManageTableTypeForm manageTableTypeForm = new ManageTableTypeForm(currentUser, this);
            manageTableTypeForm.Show();
            this.Hide();
        }

        private void btnManageTable_Click(object sender, EventArgs e)
        {
            ManageTablesForm manageTablesForm = new ManageTablesForm(currentUser, this);
            manageTablesForm.Show();
            this.Hide();
        }
    }
}
