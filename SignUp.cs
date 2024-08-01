using Oracle.ManagedDataAccess.Client;

namespace ProjectTouristManagmentSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {

            lblErrorMessage.Text = "";

            if (ValidateFields())
            {
                SaveDataToDatabase();
            }

        }
        private bool ValidateFields()
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                lblErrorMessage.Text = "All fields are required.";
                return false;
            }

            // Check if passwords match
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblErrorMessage.Text = "Passwords do not match.";
                return false;
            }


            return true;
        }

        private void SaveDataToDatabase()
        {
            string query = "INSERT INTO TOURIST (FirstName, LastName, ContactNo, Email, Address, Password) VALUES (:FirstName, :LastName, :ContactNo, :Email, :Address, :Password)";

            using (OracleConnection connection = DatabaseConnection.GetInstance().GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter("FirstName", txtFirstName.Text));
                command.Parameters.Add(new OracleParameter("LastName", txtLastName.Text));
                command.Parameters.Add(new OracleParameter("ContactNo", txtContactNo.Text));
                command.Parameters.Add(new OracleParameter("Email", txtEmail.Text));
                command.Parameters.Add(new OracleParameter("Address", txtAddress.Text));
                command.Parameters.Add(new OracleParameter("Password", txtPassword.Text));

                try
                {
                    //connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sign up successful! Login again");
                    RedirectToLogin();


                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Error saving data: " + ex.Message;
                }
            }
        }
        private void RedirectToLogin()
        {
            lblLogin loginForm = new lblLogin();
            this.Hide();
            loginForm.Show();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblLogin loginForm = new lblLogin();
            this.Hide();
            loginForm.Show();
        }
    }
}
