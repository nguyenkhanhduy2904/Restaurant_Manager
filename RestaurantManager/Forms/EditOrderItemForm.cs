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
    public partial class EditOrderItemForm : Form
    {
        private Form previousForm;
        private OrderItem choosedOrderItem;
        private User currentUser;
        public EditOrderItemForm(User currentUser, Form previousForm, OrderItem orderItem)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            this.choosedOrderItem = orderItem;
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
            if (choosedOrderItem != null)
            {
                txtBxID.Text = choosedOrderItem.ProductID.ToString();
                txtBxQuantity.Text = choosedOrderItem.Quantity.ToString();
                txtBxName.Text = choosedOrderItem.ProductName;

                txtBxID.Enabled = false;
                txtBxName.Enabled = false;
                
                var product = ProductList.GetProductByID(choosedOrderItem.ProductID);
                if (product!=null && !product.IsAvailable)
                {
                    txtBxQuantity.Enabled = false;
                    lbStatus.Text = "This product is currently unavailable. Cannot modify";
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return? Unsaved changes will be lost.", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                previousForm.Show();
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int quantity;
            if(int.TryParse(txtBxQuantity.Text, out quantity))
            {
                
                choosedOrderItem.Quantity = int.Parse(txtBxQuantity.Text);
                MessageBox.Show("Order item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                previousForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
