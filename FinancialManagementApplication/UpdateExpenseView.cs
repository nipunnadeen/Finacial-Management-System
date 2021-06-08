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
    public partial class UpdateExpenseView : Form
    {
        public UpdateExpenseView()
        {
            InitializeComponent();
        }

        private void submitUpdateExpense_Click(object sender, EventArgs e)
        {
            String name = updateExpenseName.Text;
            String amount = updateExpenseAmount.Text;
            String category = updateExpenseCategory.Text;
            String type = updateExpenseType.Text;
            DateTime date = updateExpenseDate.Value;

            if (string.IsNullOrEmpty(name) == false && string.IsNullOrEmpty(updateExpenseContact.Text) == false &&
                string.IsNullOrEmpty(amount) == false)
            {
                int contactId;
                int.TryParse(updateExpenseContact.SelectedValue.ToString(), out contactId);

                if (Util.FileRead.numberValidation(amount) == true)
                {
                    expenseValidation.Text = "Please enter a valid amount";
                }
                else
                {
                    Controllers.ExpenseController expenseController = new Controllers.ExpenseController();
                    bool expense = expenseController.updateExpense(name, amount, contactId, category, type, date);
                    if (expense == true)
                    {
                        if (MessageBox.Show("Expense has updated successfully", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            FinancialReportView fReport = new FinancialReportView();
                            Hide();
                            fReport.ShowDialog();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The expense update operation couldn't be completed, Please try again", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                    }
                } 
            }
            else
            {
                expenseValidation.Text = "Please complete the empty fields";
            }
        }

        private void cancelUpdateExpense_Click(object sender, EventArgs e)
        {
            FinancialReportView fReport = new FinancialReportView();
            Hide();
            fReport.ShowDialog();
        }

        private void UpdateExpense_Load(object sender, EventArgs e)
        {
            Controllers.ContactController contactController = new Controllers.ContactController();
            
            var contactData = contactController.getContacts();
            if (contactData.Count() > 0)
            {
                updateExpenseContact.DataSource = contactData;
                updateExpenseContact.DisplayMember = "Name";
                updateExpenseContact.ValueMember = "Id";
                updateExpenseContact.SelectedIndex = 0;
            }

            string[] categories = Util.FileRead.categories;
            foreach (string category in categories)
            {
                updateExpenseCategory.Items.Add(category);
            }

            string[] types = Util.FileRead.types;
            foreach (string type in types)
            {
                updateExpenseType.Items.Add(type);
            }

            Controllers.ExpenseController expenseController = new Controllers.ExpenseController();
            int expenseId = Util.FileRead.financeId;
            Expense expense = expenseController.getExpense(expenseId);

            updateExpenseName.AppendText(expense.Name);
            updateExpenseAmount.AppendText(expense.Amount.ToString());
            updateExpenseContact.SelectedValue = expense.ContactId;
            updateExpenseCategory.SelectedIndex = updateExpenseCategory.Items.IndexOf(expense.Category);
            updateExpenseType.SelectedIndex = updateExpenseType.Items.IndexOf(expense.Type);
            updateExpenseDate.Value = expense.Date;
        }
    }
}
