namespace RestaurantManager.Forms
{
    partial class CreateTablesForm
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
            panel1 = new Panel();
            lbUserName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(796, 194);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 0;
            label1.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(796, 292);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 1;
            label2.Text = "Type:";
            // 
            // txtBxAmount
            // 
            txtBxAmount.Location = new Point(918, 195);
            txtBxAmount.Name = "txtBxAmount";
            txtBxAmount.Size = new Size(371, 31);
            txtBxAmount.TabIndex = 2;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(918, 293);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(371, 33);
            cbxType.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(1121, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 57);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(75, 925);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(150, 75);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
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
            panel1.TabIndex = 6;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(12, 9);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(179, 38);
            lbUserName.TabIndex = 7;
            lbUserName.Text = "<username>";
            // 
            // CreateTablesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(cbxType);
            Controls.Add(txtBxAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateTablesForm";
            Text = "EditTablesForm";
            Load += CreateTablesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label lbUserName;
    }
}