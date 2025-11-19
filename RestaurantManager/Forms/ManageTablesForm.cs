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
    public partial class ManageTablesForm : Form
    {
        private User currentUser;
        private Form previousForm;
        private Table selectedTable;
        private Button lastSelectedButton;
        public ManageTablesForm(User currentUser, Form previousForm)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            LoadTableButtons();
            SetupControls();

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.StartPosition = FormStartPosition.CenterScreen;

            //// Optional fixed size:
            //this.Size = new Size(1366, 768);

            Helper.SetFixedFormSize(this, Constant.BIG_WINDOW_WIDTH, Constant.BIG_WINDOW_HEIGHT);
        }

        void SetupControls()
        {
            lbUserName.Text = $"{currentUser.UserName}!";
            if (currentUser.Role == UserRole.Staff)
            {
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;

            }
        }

        private void LoadTableButtons()
        {
            flpTables.Controls.Clear(); // clear previous buttons

            foreach (var table in TableList.Tables)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 50;
                btn.Text = $"{table.TableName}\n{(table.IsOccupied ? "Occupied" : "Free")}";
                btn.BackColor = table.IsOccupied ? Color.Red : Color.Green;
                btn.Tag = table; // store the table object
                btn.Click += TableButton_Click; // event handler
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = Color.Black;

                flpTables.Controls.Add(btn);
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Table table = btn.Tag as Table;

            if (table != null)
            {
                //MessageBox.Show($"Table {table.TableName} clicked. Occupied? {table.IsOccupied}");
                //// Here you can open the order form or update table status
                ///
                selectedTable = table;


                if (lastSelectedButton != null)
                {
                    Table previousTable = lastSelectedButton.Tag as Table;
                    lastSelectedButton.FlatAppearance.BorderSize = 0;
                    //lastSelectedButton.FlatAppearance.BorderColor = Color.Green;
                }
                btn.FlatAppearance.BorderSize = 3;
                btn.FlatAppearance.BorderColor = Color.Black;
                lastSelectedButton = btn;

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTablesForm editTablesForm = new CreateTablesForm(currentUser, this, null);
            editTablesForm.Show();
            this.Hide();
        }

        private void ManageTablesForm_Activated(object sender, EventArgs e)
        {
            LoadTableButtons();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTable == null)
            {
                MessageBox.Show("No table selected, please choose a table", "Error", MessageBoxButtons.OK);
                return;

            }
            if (selectedTable.IsOccupied)
            {
                MessageBox.Show("This table are currently been ocupied. Cannot delete", "Error", MessageBoxButtons.OK);
                return;

            }
            if (TableList.DeleteTable(selectedTable))
            {
                MessageBox.Show("Successfully delete this table", "Info", MessageBoxButtons.OK);
                selectedTable = null;
                lastSelectedButton = null;
                LoadTableButtons(); // refresh the buttons
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedTable == null)
            {
                MessageBox.Show("No table selected, please choose a table", "Error", MessageBoxButtons.OK);
                return;

            }
            EditTableForm editTableForm = new EditTableForm(selectedTable, this, currentUser);
            editTableForm.Show();
            this.Hide();
        }
    }
}
