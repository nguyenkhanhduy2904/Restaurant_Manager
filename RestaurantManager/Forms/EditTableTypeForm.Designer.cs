namespace RestaurantManager.Forms
{
    partial class EditTableTypeForm
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
            txtBxID = new TextBox();
            txtBxName = new TextBox();
            btnReturn = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            lbUserName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(820, 202);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 30);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(820, 293);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(918, 195);
            txtBxID.Margin = new Padding(4, 4, 4, 4);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(371, 37);
            txtBxID.TabIndex = 2;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(918, 293);
            txtBxName.Margin = new Padding(4, 4, 4, 4);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(371, 37);
            txtBxName.TabIndex = 3;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(75, 925);
            btnReturn.Margin = new Padding(4, 4, 4, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(195, 90);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1095, 412);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 64);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.abstract_background_design_perfect_landing_page_background_other_you_want_288336_2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(lbUserName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 1024);
            panel1.TabIndex = 6;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(40, 26);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(179, 38);
            lbUserName.TabIndex = 6;
            lbUserName.Text = "<username>";
            // 
            // EditTableTypeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(txtBxName);
            Controls.Add(txtBxID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EditTableTypeForm";
            Text = "EditTableTypeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBxID;
        private TextBox txtBxName;
        private Button btnReturn;
        private Button btnSave;
        private Panel panel1;
        private Label lbUserName;
    }
}