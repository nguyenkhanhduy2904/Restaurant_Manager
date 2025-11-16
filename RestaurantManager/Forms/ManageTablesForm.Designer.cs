namespace RestaurantManager.Forms
{
    partial class ManageTablesForm
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
            flpTables = new FlowLayoutPanel();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // flpTables
            // 
            flpTables.AutoScroll = true;
            flpTables.Dock = DockStyle.Bottom;
            flpTables.Location = new Point(0, 128);
            flpTables.Name = "flpTables";
            flpTables.Size = new Size(1314, 474);
            flpTables.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(848, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(154, 34);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Tables";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // ManageTablesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 602);
            Controls.Add(btnCreate);
            Controls.Add(flpTables);
            Name = "ManageTablesForm";
            Text = "ManageTablesForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTables;
        private Button btnCreate;
    }
}