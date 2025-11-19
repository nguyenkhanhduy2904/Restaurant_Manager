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


    public partial class EditUserForm : Form
    {
        private User currentUser;
        private User choosedUser;
        private Form previousForm;


        public EditUserForm(User currentUser, User choosedUser, Form previousForm)
        {
            InitializeComponent();
            AssignData(currentUser, choosedUser);
            LoadUserData();
            this.previousForm = previousForm;

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.StartPosition = FormStartPosition.CenterScreen;

            //// Optional fixed size:
            //this.Size = new Size(1366, 768);

            Helper.SetFixedFormSize(this, Constant.BIG_WINDOW_WIDTH, Constant.BIG_WINDOW_HEIGHT);
        }

        void AssignData(User currentUser, User choosedUser)
        {
            this.currentUser = currentUser;
            this.choosedUser = choosedUser;
        }

        void LoadUserData()
        {
            if(choosedUser == null)
            {
                txtBxID.Text = "";
              
                txtBxName.Text = "";
                txtBxPassword.Text = "";
                radAdmin.Checked = false;
                radStaff.Checked = true;
                return;
            }
            else
            {
                txtBxID.Text = choosedUser.UserID;
                txtBxID.ReadOnly = true;
                txtBxName.Text = choosedUser.UserName;
                txtBxPassword.Text = choosedUser.Password;


                radAdmin.Checked = choosedUser.Role == UserRole.Admin;
                radStaff.Checked = choosedUser.Role == UserRole.Staff;

                // role-based restrictions
                if (currentUser.Role == UserRole.Admin)
                {
                    // Admin editing someone else's account
                    if (choosedUser != currentUser)
                    {
                        txtBxPassword.UseSystemPasswordChar = true;
                        txtBxPassword.ReadOnly = true;
                    }
                }
                else if (currentUser.Role == UserRole.Staff)
                {
                    // Staff editing own or others' account
                    if (choosedUser != currentUser)
                    {
                        // cannot edit other users
                        txtBxName.ReadOnly = true;
                        txtBxPassword.ReadOnly = true;
                        txtBxPassword.UseSystemPasswordChar = true;
                        grBxRole.Enabled = false;
                    }
                    else
                    {
                        // editing self – only allow password change
                        txtBxName.ReadOnly = true;
                        grBxRole.Enabled = false;
                    }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(choosedUser != null)
            {
                //choosedUser.UserID = txtBxID.Text;
                choosedUser.UserName = txtBxName.Text;
                choosedUser.Password = txtBxPassword.Text;
                if (radAdmin.Checked)
                {
                    choosedUser.Role = UserRole.Admin;
                }
                else if (radStaff.Checked)
                {
                    choosedUser.Role = UserRole.Staff;
                }


                if (UserList.UpdateUser(choosedUser))
                {
                    DialogResult result = MessageBox.Show("User information updated successfully. Do you want to return?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        previousForm.Show();
                        this.Close();
                    }
                }
            }
            else if (choosedUser == null)
            {
                User newUser = new User(
                    txtBxID.Text,
                    txtBxName.Text,
                    txtBxPassword.Text,
                    radAdmin.Checked ? UserRole.Admin : UserRole.Staff
                    );

                if (UserList.AddUser(newUser))
                {
                    DialogResult result = MessageBox.Show("User created successfully. Do you want to return?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
