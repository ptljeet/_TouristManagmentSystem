namespace ProjectTouristManagmentSystem
{
    partial class lblLogin
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
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            lblErrorMessage = new Label();
            lblacc = new Label();
            linkCreateAccount = new LinkLabel();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(177, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(148, 125);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(277, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(277, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(263, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.HotTrack;
            btnSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(220, 192);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(203, 42);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(177, 342);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 20);
            lblErrorMessage.TabIndex = 5;
            // 
            // lblacc
            // 
            lblacc.AutoSize = true;
            lblacc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblacc.Location = new Point(173, 260);
            lblacc.Name = "lblacc";
            lblacc.Size = new Size(163, 20);
            lblacc.TabIndex = 6;
            lblacc.Text = "Don't Have an Account?";
            // 
            // linkCreateAccount
            // 
            linkCreateAccount.AutoSize = true;
            linkCreateAccount.Location = new Point(347, 260);
            linkCreateAccount.Name = "linkCreateAccount";
            linkCreateAccount.Size = new Size(110, 20);
            linkCreateAccount.TabIndex = 7;
            linkCreateAccount.TabStop = true;
            linkCreateAccount.Text = "Create Account";
            linkCreateAccount.LinkClicked += linkCreateAccount_LinkClicked;
            // 
            // lblLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkCreateAccount);
            Controls.Add(lblacc);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Name = "lblLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignUp;
        private Label lblErrorMessage;
        private Label lblacc;
        private LinkLabel linkCreateAccount;
    }
}