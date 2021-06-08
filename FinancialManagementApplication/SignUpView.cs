using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagementApplication
{
    public partial class SignUpView : Form
    {
        public SignUpView()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            LoginView signin = new LoginView();
            Hide();
            signin.ShowDialog();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            String fName = registerFirstName.Text;
            String lName = registerLastName.Text;
            String email = registerEmail.Text;
            String password = registerPassword.Text;
            String confirmPassword = registerConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(email) == false && string.IsNullOrWhiteSpace(password) == false && 
                string.IsNullOrWhiteSpace(fName) == false && string.IsNullOrWhiteSpace(lName) == false && 
                string.IsNullOrWhiteSpace(confirmPassword) == false)
            {
                if (password.Length < 4)
                {
                    registerValidation.Text = "Passwords is too short";
                }
                else if (password.Equals(confirmPassword) == false)
                {
                    registerValidation.Text = "Passwords is not matched";
                }
                else if (IsValidEmailType(email) == false)
                {
                    registerValidation.Text = "Please enter a valid email address";
                }
                else
                {
                    Controllers.UserController userController = new Controllers.UserController();
                    bool register = userController.registerUser(fName, lName, email, password);

                    if (register == true)
                    {
                        LoginView signin = new LoginView();
                        Hide();
                        signin.ShowDialog();
                    }
                    else
                    {
                        registerValidation.Text = "Email is already used";
                    }
                }
            } 
            else
            {
                registerValidation.Text = "Please complete the empty fields";
            } 
        }

        /// <summary>
        /// this will check whether the email is valid or not
        /// </summary>
        /// <returns>true</returns>
        bool IsValidEmailType(string email)
        {
            string ValidEmailAddressPattern = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$";
            var regex = new Regex(ValidEmailAddressPattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
