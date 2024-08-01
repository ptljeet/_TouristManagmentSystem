
namespace ProjectTouristManagmentSystem
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblContactNo = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtContactNo = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSignUp = new Button();
            lblErrorMessage = new Label();
            linkLogin = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirstName.Location = new Point(326, 47);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(90, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLastName.Location = new Point(327, 94);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContactNo.Location = new Point(322, 142);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(92, 20);
            lblContactNo.TabIndex = 3;
            lblContactNo.Text = "Contact No:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(364, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.Location = new Point(346, 242);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 20);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(338, 293);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(273, 348);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(141, 20);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.Location = new Point(461, 44);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 27);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.Location = new Point(461, 91);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 27);
            txtLastName.TabIndex = 9;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 9F);
            txtContactNo.Location = new Point(461, 139);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(280, 27);
            txtContactNo.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(460, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(460, 239);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(278, 27);
            txtAddress.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.Location = new Point(461, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 9F);
            txtConfirmPassword.Location = new Point(461, 345);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(280, 27);
            txtConfirmPassword.TabIndex = 14;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.HotTrack;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignUp.Location = new Point(364, 407);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(280, 50);
            btnSignUp.TabIndex = 15;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.Black;
            lblErrorMessage.Location = new Point(338, 528);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 23);
            lblErrorMessage.TabIndex = 16;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLogin.Location = new Point(543, 476);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(106, 20);
            linkLogin.TabIndex = 17;
            linkLogin.TabStop = true;
            linkLogin.Text = "Back To Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 476);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 18;
            label1.Text = "Already have an Account?";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 618);
            Controls.Add(label1);
            Controls.Add(linkLogin);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnSignUp);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtContactNo);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(lblContactNo);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "SignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblContactNo;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtContactNo;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSignUp;
        private Label lblErrorMessage;
        private LinkLabel linkLogin;
        private Label label1;
    }
}
