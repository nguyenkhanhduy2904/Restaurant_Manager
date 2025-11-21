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

            cbxRevenue.Items.Clear();
            cbxRevenue.Items.Add("Today");
            cbxRevenue.Items.Add("This Week");
            cbxRevenue.Items.Add("This Month");

            cbxBestSell.Items.Clear();
            cbxBestSell.Items.Add("Today");
            cbxBestSell.Items.Add("This Week");
            cbxBestSell.Items.Add("This Month");

            cbxRevenue.SelectedIndex = 0;
            cbxBestSell.SelectedIndex = 0;
            CalculateRevenue();
            CalculateBestSellingProducts();


        }

        void CalculateRevenue()
        {
            int caseIndex = cbxRevenue.SelectedIndex;
            int revenue = 0;

            switch (caseIndex)
            {
                case 0:

                    revenue = OrderList.GetTotalRevenueFromTo(DateTime.Now.Date, DateTime.Now.Date.AddDays(1).AddTicks(-1));
                    lbTotalRevenue.Text = $"Revenue: ${revenue}";
                    lbTimeStampTotal.Text = $"From Today: {DateTime.Now.Date.ToShortDateString()} ";

                    break;
                case 1:
                    revenue = OrderList.GetTotalRevenueFromTo(DateTime.Now.Date.AddDays(-6), DateTime.Now.Date.AddDays(1).AddTicks(-1));
                    lbTotalRevenue.Text = $"Revenue: ${revenue}";
                    lbTimeStampTotal.Text = $"From: {DateTime.Now.Date.AddDays(-6).ToShortDateString()} to {DateTime.Now.Date.AddDays(1).AddTicks(-1).ToShortDateString()} ";
                    break;
                case 2:
                    revenue = OrderList.GetTotalRevenueFromTo(DateTime.Now.Date.AddDays(-29), DateTime.Now.Date.AddDays(1).AddTicks(-1));
                    lbTotalRevenue.Text = $"Revenue: ${revenue}";
                    lbTimeStampTotal.Text = $"From: {DateTime.Now.Date.AddDays(-29).ToShortDateString()} to {DateTime.Now.Date.AddDays(1).AddTicks(-1).ToShortDateString()} ";
                    break;
                default:
                    break;
            }
        }

        void CalculateBestSellingProducts()
        {
            int caseIndex = cbxBestSell.SelectedIndex;
            DateTime from = DateTime.Now.Date;
            DateTime to = DateTime.Now.Date.AddDays(1).AddTicks(-1);

            switch (caseIndex)
            {
                case 0:
                    // Today
                    lbTimeStampSelling.Text = $"From Today: {DateTime.Now.Date.ToShortDateString()} ";
                    break;
                case 1: //last 7 days
                    from = DateTime.Now.Date.AddDays(-6);
                    to = DateTime.Now.Date.AddDays(1).AddTicks(-1); // today 23:59:59

                    lbTimeStampSelling.Text = $"From: {from.ToShortDateString()} to {to.ToShortDateString()} ";
                    break;
                case 2: // last 30 days
                    from = DateTime.Now.AddDays(-29);
                    to = DateTime.Now.Date.AddDays(1).AddTicks(-1); // today 23:59:59

                    lbTimeStampSelling.Text = $"From: {from.ToShortDateString()} to {to.ToShortDateString()} ";
                    break;
            }

            var bestSellList = ProductList.GetBestSellingList(from, to);

            // Display top 3 safely
            int index = 1;
            foreach (var item in bestSellList.Take(3))
            {
                var product = ProductList.GetProductByID(item.Key);
                switch (index)
                {
                    case 1: lbBestSell1.Text = $"1.{product.ProductName}: {item.Value}"; break;
                    case 2: lbBestSell2.Text = $"2.{product.ProductName}: {item.Value}"; break;
                    case 3: lbBestSell3.Text = $"3.{product.ProductName}: {item.Value}"; break;
                }
                index++;
            }
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

        private void cbxRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateRevenue();
        }

        private void cbxBestSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBestSellingProducts();
        }

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            SetupControls();
        }
    }
}
