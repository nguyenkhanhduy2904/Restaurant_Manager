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
    public partial class EditTableForm : Form
    {
        private Form previousForm;
        private User currentUser;
        private Table choosedTable;
        private string currentOrderID;
        public EditTableForm(Table choosedTable, Form previousForm,User currentUser)
        {
            InitializeComponent();
            this.choosedTable = choosedTable;
            this.previousForm = previousForm;
            this.currentUser = currentUser;
        }

        void SetupData()
        {
            currentOrderID = choosedTable.CurrentOrderID;
            //var order = ;
        }
    }
}
