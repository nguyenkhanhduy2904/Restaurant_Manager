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
    public partial class ManageUsersForm : Form
    {
        private User currentUser;
        private Form previousForm;


        public ManageUsersForm(User currentUser, Form previousForm)
        {
            InitializeComponent();
            LoadAllUsers();
            AssignData(currentUser);
            SetuControls();
            this.previousForm = previousForm;
        }

        void AssignData(User currentUser)
        {
            this.currentUser = currentUser;
        }
        void SetuControls()
        {
            lbUserName.Text = $"{currentUser.UserName}!";
        }

        void LoadAllUsers()
        {
            dgvUsersList.Rows.Clear();
            foreach (var user in UserList.Users)
            {
                int index = dgvUsersList.Rows.Add(user.UserID, user.UserName, user.Role.ToString());
                dgvUsersList.Rows[index].Tag = user;
            }


        }

        private User GetSelectedUser()
        {
            if (dgvUsersList.CurrentRow != null)
            {
                return dgvUsersList.CurrentRow.Tag as User;
            }
            else
            {
                MessageBox.Show("No user selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            User selectedUser = GetSelectedUser();
            if (selectedUser != null)
            {
                EditUserForm editUserForm = new EditUserForm(currentUser, selectedUser, this);
                editUserForm.Show();
                this.Hide();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void ManageUsersForm_Activated(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User selectedUser = GetSelectedUser();
            if (selectedUser != null)
            {
                if (currentUser == selectedUser)
                {
                    MessageBox.Show("You can't delete your own account", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{selectedUser.UserName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    UserList.RemoveUser(selectedUser);
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllUsers();
                }

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(currentUser, null, this);
            editUserForm.Show();
            this.Hide();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            User selectedUser = GetSelectedUser();
            DialogResult result = MessageBox.Show($"Are you sure you want to reset password for user '{selectedUser.UserName}' to default password: '{Constant.DEFAULT_PASSWORD}'?", "Confirm Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                selectedUser.Password = Constant.DEFAULT_PASSWORD.ToString();
                UserList.UpdateUser(selectedUser);
                MessageBox.Show($"Password reset successfully.{selectedUser.UserName} new password is : '{Constant.DEFAULT_PASSWORD}' ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
