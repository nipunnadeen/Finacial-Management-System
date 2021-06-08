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
    public partial class ProfileView : Form
    {
        public ProfileView()
        {
            InitializeComponent();
        }

        private void submitUpdateProfile_Click(object sender, EventArgs e)
        {
            String firstName = updateFirstName.Text;
            String lastName = updateLastName.Text;

            if (string.IsNullOrWhiteSpace(firstName) == false && string.IsNullOrWhiteSpace(lastName) == false)
            {
                 Controllers.UserController userController = new Controllers.UserController();
                 bool isUpdateUser = userController.updateProfile(firstName, lastName);

                 if (isUpdateUser == true)
                 {
                     if (MessageBox.Show("User profile details have updated successfully", "Message",
                     MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                     {
                          MainMenu mainMenu = new MainMenu();
                          Hide();
                          mainMenu.ShowDialog();
                     }
                 }
                 else
                 {
                    if (MessageBox.Show("User profile update operation couldn't be completed, Please try again", "Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                }
            }
            else
            {
                updateProfileValidation.Text = "Please complete the empty fields";
            }
        }

        private void updateSubmit_Click(object sender, EventArgs e)
        {
            String email = updateEmail.Text;

            if (string.IsNullOrWhiteSpace(email) == false)
            {
                if (IsValidEmailType(email) == false)
                {
                    updateProfileValidation.Text = "Please enter a valid email address";
                }
                else
                {
                    Controllers.UserController userController = new Controllers.UserController();
                    bool isUpdateUser = userController.updateEmail(email);

                    if (isUpdateUser == true)
                    {
                        if (MessageBox.Show("User email has updated successfully", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            MainMenu mainMenu = new MainMenu();
                            Hide();
                            mainMenu.ShowDialog();
                        }
                    }
                    else
                    {
                        updateProfileValidation.Text = "Email is already used";
                    }
                }
            }
            else
            {
                updateProfileValidation.Text = "Please complete the empty fields";
            }
        }
        bool IsValidEmailType(string email)
        {
            string ValidEmailAddressPattern = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$";
            var regex = new Regex(ValidEmailAddressPattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            Controllers.UserController userController = new Controllers.UserController();
            UserInfo userData = userController.getUserInformations();

            if(userData != null)
            {
                updateFirstName.AppendText(userData.FirstName);
                updateLastName.AppendText(userData.LastName);
                updateEmail.AppendText(userData.Email);
            }
        }

        private void submitUpdatePassword_Click(object sender, EventArgs e)
        {
            String password = updatePassword.Text;
            String confirmPassword = updateConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(password) == false && string.IsNullOrWhiteSpace(confirmPassword) == false)
            {
                if (password.Length < 4)
                {
                    updatePasswordValidation.Text = "Passwords is too short";
                }
                else if (password.Equals(confirmPassword) == false)
                {
                    updatePasswordValidation.Text = "Passwords is not matched";
                }
                else
                {
                    Controllers.UserController userController = new Controllers.UserController();
                    bool isUpdatePassword = userController.updatePassword(password);

                    if (isUpdatePassword == true)
                    {
                        if (MessageBox.Show("User password have updated successfully", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            MainMenu mainMenu = new MainMenu();
                            Hide();
                            mainMenu.ShowDialog();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("User Password update operation couldn't be completed, Please try again", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                    }
                }
            }
            else
            {
                updatePasswordValidation.Text = "Please complete the empty fields";
            }
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
        }
    }
}
