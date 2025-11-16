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
    public partial class EditTableTypeForm : Form
    {
        private Form previousForm;
        private User currentUser;
        TableType choosedTableType;
        public EditTableTypeForm(User currentUser, Form previousForm, TableType tbType)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            this.choosedTableType = tbType;
            SetupData();
        }

        void SetupData()
        {
            if (choosedTableType != null)
            {
                txtBxID.Text = choosedTableType.TypeID;
                txtBxID.ReadOnly = true;
                txtBxName.Text = choosedTableType.TypeName;
            }
            else
            {
                txtBxID.Text = "";
                txtBxName.Text = "";
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
            if (choosedTableType == null)
            {
                TableType tableType = new TableType(
                txtBxID.Text,
                txtBxName.Text
                );
                if (TableTypeList.AddTableType(tableType))
                {
                    DialogResult result = MessageBox.Show("Table type added successfully! Do you want to return?", "Info", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        previousForm.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                choosedTableType.TypeName = txtBxName.Text;
                if (TableTypeList.UpdateTableType(choosedTableType))
                {
                    DialogResult result = MessageBox.Show("Table type updated successfully! Do you want to return?", "Info", MessageBoxButtons.YesNo);
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
