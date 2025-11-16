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
using RestaurantManager.Utils;


namespace RestaurantManager.Forms
{
    public partial class ManageTableTypeForm : Form
    {
        private Form previousForm;
        private User currentUser;
        public ManageTableTypeForm(User currentUser, Form previousForm)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            SetupControls();
            LoadAllTableTypes();
        }

        void SetupControls()
        {
            lbUserName.Text = $"{currentUser.UserName}!";
        }

        void LoadAllTableTypes()
        {
            TableTypeList.InitTableTypeListData();
            dgvTableType.Rows.Clear();
            foreach (var tableType in TableTypeList.TableTypes)
            {
                int index = dgvTableType.Rows.Add(tableType.TypeID, tableType.TypeName);
                dgvTableType.Rows[index].Tag = tableType;
            }
        }

        private TableType GetSelectedTableType()
        {
            if (dgvTableType.CurrentRow != null)
            {
                return dgvTableType.CurrentRow.Tag as TableType;
            }
            else
            {
                MessageBox.Show("No table type selected", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedTableType = GetSelectedTableType();
            if (selectedTableType.TypeID == Constant.TABLE_TYPE_DEFAULT_ID)
            {
                MessageBox.Show("Default table type cannot be deleted!", "Warning", MessageBoxButtons.OK);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this table type?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                if (selectedTableType != null)
                {
                    if (TableTypeList.DeleteTableType(selectedTableType))
                    {
                        MessageBox.Show("Table type deleted successfully!", "Info", MessageBoxButtons.OK);
                        LoadAllTableTypes();
                    }
                }
            }
        }

        private void ManageTableTypeForm_Activated(object sender, EventArgs e)
        {
            LoadAllTableTypes();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            EditTableTypeForm editTableTypeForm = new EditTableTypeForm(currentUser, this, null);
            editTableTypeForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTableTypeForm editTableTypeForm = new EditTableTypeForm(currentUser, this, GetSelectedTableType());
            editTableTypeForm.Show();
            this.Hide();
        }
    }
}
