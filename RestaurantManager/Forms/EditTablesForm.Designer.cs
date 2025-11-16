namespace RestaurantManager.Forms
{
    partial class EditTablesForm
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
            label1 = new Label();
            label2 = new Label();
            txtBxAmount = new TextBox();
            cbxType = new ComboBox();
            btnSave = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 80);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 137);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Type:";
            // 
            // txtBxAmount
            // 
            txtBxAmount.Location = new Point(151, 80);
            txtBxAmount.Name = "txtBxAmount";
            txtBxAmount.Size = new Size(191, 31);
            txtBxAmount.TabIndex = 2;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(151, 134);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(182, 33);
            cbxType.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(356, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(160, 333);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // EditTablesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 531);
            Controls.Add(btnReturn);
            Controls.Add(btnSave);
            Controls.Add(cbxType);
            Controls.Add(txtBxAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditTablesForm";
            Text = "EditTablesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBxAmount;
        private ComboBox cbxType;
        private Button btnSave;
        private Button btnReturn;
    }
}