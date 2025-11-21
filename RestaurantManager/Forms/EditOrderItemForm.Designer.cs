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
            panel1 = new Panel();
            lbUserName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBxQuantity
            // 
            txtBxQuantity.Location = new Point(918, 400);
            txtBxQuantity.Name = "txtBxQuantity";
            txtBxQuantity.Size = new Size(371, 31);
            txtBxQuantity.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(705, 391);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 1;
            label1.Text = "New Quantity:";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(75, 925);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(150, 75);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1121, 488);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 57);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(705, 194);
            label.Name = "label";
            label.Size = new Size(40, 30);
            label.TabIndex = 5;
            label.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(705, 292);
            label3.Name = "label3";
            label3.Size = new Size(161, 30);
            label3.TabIndex = 6;
            label3.Text = "Product Name:";
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(918, 195);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(371, 31);
            txtBxID.TabIndex = 7;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(918, 293);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(371, 31);
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
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.abstract_background_design_perfect_landing_page_background_other_you_want_288336_2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbUserName);
            panel1.Controls.Add(btnReturn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 1024);
            panel1.TabIndex = 10;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(22, 18);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(179, 38);
            lbUserName.TabIndex = 11;
            lbUserName.Text = "<username>";
            // 
            // EditOrderItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(lbStatus);
            Controls.Add(txtBxName);
            Controls.Add(txtBxID);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtBxQuantity);
            Name = "EditOrderItemForm";
            Text = "EditOrderItemForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label lbUserName;
    }
}