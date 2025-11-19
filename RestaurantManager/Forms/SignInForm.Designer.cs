namespace RestaurantManager.Forms
{
    partial class SignInForm
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
            txtBxUserName = new TextBox();
            txtBxPassword = new TextBox();
            btnSignIn = new Button();
            btnForgotPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1075, 101);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1075, 196);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtBxUserName
            // 
            txtBxUserName.Location = new Point(1195, 95);
            txtBxUserName.Name = "txtBxUserName";
            txtBxUserName.Size = new Size(372, 31);
            txtBxUserName.TabIndex = 2;
            // 
            // txtBxPassword
            // 
            txtBxPassword.Location = new Point(1195, 190);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(372, 31);
            txtBxPassword.TabIndex = 3;
            txtBxPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(1240, 310);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(137, 72);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Location = new Point(1394, 310);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(173, 72);
            btnForgotPassword.TabIndex = 5;
            btnForgotPassword.Text = "Forgot Password";
            btnForgotPassword.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnForgotPassword);
            Controls.Add(btnSignIn);
            Controls.Add(txtBxPassword);
            Controls.Add(txtBxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBxUserName;
        private TextBox txtBxPassword;
        private Button btnSignIn;
        private Button btnForgotPassword;

    }
}