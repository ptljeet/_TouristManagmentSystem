using Oracle.ManagedDataAccess.Client;

namespace ProjectTouristManagmentSystem
{
    public partial class lblLogin : Form
    {
        public lblLogin()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";

            // Validate the input fields
            if (ValidateFields())
            {
                // If validation passes, check user credentials
                ValidateUser();
            }
        }

        private bool ValidateFields()
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblErrorMessage.Text = "Email and Password are required.";
                return false;
            }
            return true;
        }

        private void ValidateUser()
        {
            string query = "SELECT COUNT(*) FROM TOURIST WHERE Email = :Email AND Password = :Password";

            using (OracleConnection connection = DatabaseConnection.GetInstance().GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter("Email", txtEmail.Text));
                command.Parameters.Add(new OracleParameter("Password", txtPassword.Text));

                try
                {
                    //connection.Open();
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Login successful!");
                        Home homeform = new Home();
                        this.Hide();
                        homeform.Show();
                    }
                    else
                    {
                        lblErrorMessage.Text = "Invalid email or password.";
                    }
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Error connecting to database: " + ex.Message;
                }
            }
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signForm = new SignUp();
            this.Hide();
            signForm.Show();
        }
    }
}
