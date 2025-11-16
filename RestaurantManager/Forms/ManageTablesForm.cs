using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManager.Models;

namespace RestaurantManager.Forms
{
    public partial class ManageTablesForm : Form
    {
        private User currentUser;
        private Form previousForm;
        public ManageTablesForm(User currentUser, Form previousForm)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.previousForm = previousForm;
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

                flpTables.Controls.Add(btn);
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Table table = btn.Tag as Table;

            if (table != null)
            {
                MessageBox.Show($"Table {table.TableName} clicked. Occupied? {table.IsOccupied}");
                // Here you can open the order form or update table status
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EditTablesForm editTablesForm = new EditTablesForm(currentUser, this, null);
            editTablesForm.Show();
            this.Hide();
        }
    }
}
