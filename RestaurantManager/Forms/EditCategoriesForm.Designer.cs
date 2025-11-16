namespace RestaurantManager.Forms
{
    partial class EditCategoriesForm
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
            btnReturn = new Button();
            btnSave = new Button();
            txtBxID = new TextBox();
            txtBxName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 59);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 127);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(179, 320);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(323, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(258, 59);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(255, 31);
            txtBxID.TabIndex = 4;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(258, 124);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(255, 31);
            txtBxName.TabIndex = 5;
            // 
            // EditCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 450);
            Controls.Add(txtBxName);
            Controls.Add(txtBxID);
            Controls.Add(btnSave);
            Controls.Add(btnReturn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditCategoriesForm";
            Text = "EditCategoriesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnReturn;
        private Button btnSave;
        private TextBox txtBxID;
        private TextBox txtBxName;
    }
}