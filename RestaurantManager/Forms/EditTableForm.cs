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
    public partial class EditTableForm : Form
    {
        private Form previousForm;
        private User currentUser;
        private Table choosedTable;
        private int currentOrderID;
        private Order thisOrder;
        public EditTableForm(Table choosedTable, Form previousForm, User currentUser)
        {
            InitializeComponent();
            this.choosedTable = choosedTable;
            this.previousForm = previousForm;
            this.currentUser = currentUser;
            SetupData();
            LoadAllCategories();

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
            if (choosedTable == null)
                return;

            txtBxOrderID.Text = choosedTable.CurrentOrderID.ToString();


            txtBxID.Text = choosedTable.TableID.ToString();
            txtBxID.Enabled = false;
            txtName.Text = choosedTable.TableName;
            if (choosedTable.IsOccupied)
            {
                radTrue.Checked = true;
                radFalse.Checked = false;
            }
            else
            {
                radTrue.Checked = false;
                radFalse.Checked = true;
            }
            currentOrderID = choosedTable.CurrentOrderID ?? -1;

            //if (int.TryParse(choosedTable.CurrentOrderID, out currentOrderID))
            //{
            thisOrder = OrderList.GetOrderByID(currentOrderID);
            if (thisOrder != null)
            {
                lbTimeCreate.Text = thisOrder.CreateAt.ToString();
                string? userName = UserList.GetUserByID(thisOrder.OrderedByUserID)?.UserName;
                if (userName!=null)
                {
                    lbCreateByUser.Text = userName;
                }
                else
                {
                    lbCreateByUser.Text = "Unknown";
                }



                if (thisOrder.Items == null)
                {
                    thisOrder.Items = new List<OrderItem>();
                }
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = thisOrder.Items;


            }
            else
            {
                dgvOrder.DataSource = null;
            }


            //}
            //else
            //{
            //    dgvOrder.DataSource = null;

            //}

            if (currentUser.Role == UserRole.Staff)
            {
                txtBxID.Enabled = false;
                txtName.Enabled = false;
                radTrue.Enabled = false;
                radFalse.Enabled = false;

            }



        }

        void LoadAllCategories()
        {
            flpProdCategory.Controls.Clear();
            foreach (var category in ProductCategoryList.Categories)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 50;
                btn.Text = category.CategoryName;
                btn.Tag = category; // store the category object
                btn.Click += CategoryButton_Click; // event handler
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.BackColor = Color.LightGray;
                flpProdCategory.Controls.Add(btn);
            }
        }

        void LoadProducts(ProductCategory category)
        {
            foreach (var product in ProductList.Products)
            {
                if (product.Category.CategoryID == category.CategoryID)
                {
                    Button btn = new Button();
                    btn.Width = 100;
                    btn.Height = 50;
                    btn.Text = product.ProductName;
                    btn.Tag = product; // store the product object
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.BorderColor = Color.Black;
                    btn.BackColor = Color.LightYellow;
                    btn.Click += ProductButton_Click;// event handler
                    if (!product.IsAvailable)
                    {
                        btn.Enabled = false;
                    }
                    flpProd.Controls.Add(btn);

                }
            }
        }

        void CategoryButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ProductCategory category = btn.Tag as ProductCategory;
            if (category != null)
            {
                flpProd.Controls.Clear();
                LoadProducts(category);
            }

        }

        void ProductButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Product product = btn.Tag as Product;
            if (product == null)
            {
                return;
            }
            OrderItem orderItem = new OrderItem(product.ProductID, product.ProductName, 1, product.Price);
            if (thisOrder == null)
            {
                thisOrder = OrderList.CreateNextOrder(choosedTable.TableID, currentUser.UserID);
                thisOrder.Items = new List<OrderItem>();   // init list first
                thisOrder.Items.Add(orderItem);            // then add the item
                OrderList.AddOrder(thisOrder);
                choosedTable.CurrentOrderID = thisOrder.OrderID;
            }
            else
            {
                var existingItem = thisOrder.Items.FirstOrDefault(i => i.ProductID == product.ProductID);
                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    thisOrder.Items.Add(new OrderItem(product.ProductID, product.ProductName, 1, product.Price));
                }
            }


            dgvOrder.DataSource = null;
            dgvOrder.DataSource = thisOrder.Items;






        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (choosedTable == null)
                return;

            choosedTable.TableName = txtName.Text.Trim();
            choosedTable.IsOccupied = radTrue.Checked;

            TableList.UpdateTable(choosedTable);

            // Only update order if it exists
            if (thisOrder != null)
            {
                OrderList.UpdateOrder(thisOrder);
            }

            MessageBox.Show("Table updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        OrderItem GetOrderItem()
        {
            if (dgvOrder.CurrentRow != null)
            {
                return dgvOrder.CurrentRow.DataBoundItem as OrderItem;
            }

            MessageBox.Show("No order item selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = GetOrderItem();
            if (selectedItem != null)
            {
                EditOrderItemForm editOrderItemForm = new EditOrderItemForm(currentUser, this, selectedItem);
                editOrderItemForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select an order item to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditTableForm_Activated(object sender, EventArgs e)
        {
            SetupData();
        }
    }


}
