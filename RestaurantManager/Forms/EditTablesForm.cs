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
    public partial class EditTablesForm : Form
    {
        private User currentUser;
        private Form previousForm;
        private Table choosedTable;
        public EditTablesForm(User currentUser, Form previousForm, Table choosedTable)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            this.choosedTable = choosedTable;
            SetupData();
        }



        void SetupData()
        {
            TableTypeList.InitTableTypeListData();


            txtBxAmount.Text = "";
            cbxType.DataSource = TableTypeList.TableTypes;
            cbxType.DisplayMember = "TypeName";
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
            int amount = 1;
            if (!int.TryParse(txtBxAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK);
                return;
            }
            TableType tbType = cbxType.SelectedItem as TableType;
            if(tbType == null)
            {
                MessageBox.Show("Please choose a type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (choosedTable ==null)
            {
                for (int i =0; i< amount; i++)
                {
                    TableList.AddTable(TableList.CreateNextTable(tbType));
                }
                DialogResult result = MessageBox.Show("Tables added successfully! Do you want to return?", "Success", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    previousForm.Show();
                    this.Close();
                }
            }

        }
    }
}
