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
    public partial class StaffForm : Form
    {
        private User currentUser;
        private Form previousForm;
        string username;
        public StaffForm(User user, Form previousForm)
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
            lbUserName.Text = $"Welcome, {username}!";
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(currentUser, currentUser, this);
            editUserForm.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ManageTablesForm manageTablesForm = new ManageTablesForm(currentUser, this);
            manageTablesForm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
