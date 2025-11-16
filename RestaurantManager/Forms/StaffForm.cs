using RestaurantManager.Models;
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
        string username;
        public StaffForm(User user)
        {
            InitializeComponent();
            SetupData(user);
            AssignData();
            SetupControls();
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
    }
}
