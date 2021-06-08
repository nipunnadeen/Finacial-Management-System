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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            Hide();
            login.ShowDialog();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            ContactView contactDetail = new ContactView();
            Hide();
            contactDetail.ShowDialog();
        }

        private void income_Click(object sender, EventArgs e)
        {
            AddIncomeView income = new AddIncomeView();
            Hide();
            income.ShowDialog();
        }

        private void expense_Click(object sender, EventArgs e)
        {
            AddExpenseView expense = new AddExpenseView();
            Hide();
            expense.ShowDialog();
        }

        private void financialStatus_Click(object sender, EventArgs e)
        {
            FinancialPredictionView fp = new FinancialPredictionView();
            Hide();
            fp.ShowDialog();
        }

        private void financialReport_Click(object sender, EventArgs e)
        {
            FinancialReportView fr = new FinancialReportView();
            Hide();
            fr.ShowDialog();
        }

        private void account_Click(object sender, EventArgs e)
        {
            ProfileView acc = new ProfileView();
            Hide();
            acc.ShowDialog();
        }
    }
}
