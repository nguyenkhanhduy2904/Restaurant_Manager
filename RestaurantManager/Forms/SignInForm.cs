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
    public partial class SignInForm : Form
    {
        string username;
        string password;
        public SignInForm()
        {
            InitializeComponent();

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.StartPosition = FormStartPosition.CenterScreen;

            //// Optional fixed size:
            //this.Size = new Size(1366, 768);

            Helper.SetFixedFormSize(this, Constant.BIG_WINDOW_WIDTH, Constant.BIG_WINDOW_HEIGHT);


        }


        void AssignData()
        {
            username = txtBxUserName.Text;
            password = txtBxPassword.Text;
        }
        bool isInputValid()
        {
            //username = txtBxUserName.Text;
            //password = txtBxPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            AssignData();
            if (!isInputValid())
            {
                return;
            }
            //MessageBox.Show("Input Valid", "Info", MessageBoxButtons.OK);

            foreach (var user in UserList.Users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    MessageBox.Show($"Welcome back, {user.UserName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.DialogResult = DialogResult.OK;
                    //this.Tag = user; // Pass the logged-in user back to the caller
                    //this.Close();

                    if (user.Role == UserRole.Admin)
                    {
                        AdminForm adminForm = new AdminForm(user,this);
                        adminForm.Show();
                        

                    }
                    else if (user.Role == UserRole.Staff) 
                    {
                        StaffForm staffForm = new StaffForm(user, this);
                        staffForm.Show();
                        

                    }
                    txtBxUserName.Text = "";
                    txtBxPassword.Text = "";// clear input fields
                    this.Hide();
                    return;
                }
                
            }
            MessageBox.Show("Wrong username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;




        }
    }
}
