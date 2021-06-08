using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagementApplication
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            String email = loginEmail.Text;
            String password = loginPassword.Text;

            if (string.IsNullOrWhiteSpace(email) == false && string.IsNullOrWhiteSpace(password) == false)
            {
                Controllers.UserController userController = new Controllers.UserController();
                bool login = userController.loginUser(email, password);

                if (login == true)
                {
                    MainMenu mainMenu = new MainMenu();
                    Hide();
                    mainMenu.ShowDialog();
                }
                else
                {
                    signInValidation.Text = "Please enter valid email and password";
                }
            } 
            else
            {
                signInValidation.Text = "Please complete the empty fields";
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            SignUpView register = new SignUpView();
            Hide();
            register.ShowDialog(); 
        }
    }
}
