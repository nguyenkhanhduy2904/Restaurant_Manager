namespace RestaurantManager.Forms
{
    partial class EditOrderItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBxQuantity = new TextBox();
            label1 = new Label();
            btnReturn = new Button();
            btnSave = new Button();
            label = new Label();
            label3 = new Label();
            txtBxID = new TextBox();
            txtBxName = new TextBox();
            lbStatus = new Label();
            SuspendLayout();
            // 
            // txtBxQuantity
            // 
            txtBxQuantity.Location = new Point(252, 154);
            txtBxQuantity.Name = "txtBxQuantity";
            txtBxQuantity.Size = new Size(150, 31);
            txtBxQuantity.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 154);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 1;
            label1.Text = "New Quantity:";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(119, 262);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(246, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(92, 49);
            label.Name = "label";
            label.Size = new Size(34, 25);
            label.TabIndex = 5;
            label.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 97);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 6;
            label3.Text = "Product Name:";
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(252, 43);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(150, 31);
            txtBxID.TabIndex = 7;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(252, 99);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(150, 31);
            txtBxName.TabIndex = 8;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(439, 160);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(0, 25);
            lbStatus.TabIndex = 9;
            // 
            // EditOrderItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbStatus);
            Controls.Add(txtBxName);
            Controls.Add(txtBxID);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(btnSave);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Controls.Add(txtBxQuantity);
            Name = "EditOrderItemForm";
            Text = "EditOrderItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBxQuantity;
        private Label label1;
        private Button btnReturn;
        private Button btnSave;
        private Label label;
        private Label label3;
        private TextBox txtBxID;
        private TextBox txtBxName;
        private Label lbStatus;
    }
}