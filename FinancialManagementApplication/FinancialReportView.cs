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
    public partial class FinancialReportView : Form
    {
        public FinancialReportView()
        {
            InitializeComponent();
        }

        private void submitFindIncome_Click(object sender, EventArgs e)
        {
            DateTime startDate = incomeStartDate.Value;
            DateTime endDate = incomeEndDate.Value;

            double datesDiff = (endDate - startDate).TotalDays;
            if (datesDiff >= 0)
            {
                incomeTable.Rows.Clear();

                Controllers.ReportController reportController = new Controllers.ReportController();
                List<Income> incomeDetails = reportController.getIncomeData(startDate, endDate);

                foreach (Income incomeDetail in incomeDetails)
                {
                    incomeTable.Rows.Add(incomeDetail.Id, incomeDetail.Name, incomeDetail.Contact.Name, incomeDetail.Type,
                        incomeDetail.Amount, incomeDetail.Category, incomeDetail.Date);
                }
            }
            else
            {
                incomeDateValidation.Text = "End date must be higher than start date";
            }
        }

        private void submitFindExpense_Click(object sender, EventArgs e)
        {
            DateTime startDate = expenseStartDate.Value;
            DateTime endDate = expenseEndDate.Value;

            double datesDiff = (endDate - startDate).TotalDays;
            if (datesDiff >= 0)
            {
                expenseTable.Rows.Clear();

                Controllers.ReportController reportController = new Controllers.ReportController();
                List<Expense> expenseDetails = reportController.getExpenseData(startDate, endDate);

                foreach (Expense expenseDetail in expenseDetails)
                {
                    expenseTable.Rows.Add(expenseDetail.Id, expenseDetail.Name, expenseDetail.Contact.Name, expenseDetail.Type,
                        expenseDetail.Amount, expenseDetail.Category, expenseDetail.Date);
                }
            }
            else
            {
                expenseDateValidation.Text = "End date must be higher than start date";
            }   
        }

        private void incomeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (incomeTable.Columns[e.ColumnIndex].Name == "IncomeEdit")
            {
                if (incomeTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (MessageBox.Show("Are you sure to update the data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        incomeTable.CurrentRow.Selected = true;
                        int selectedIncomeId = Convert.ToInt32(incomeTable.Rows[e.RowIndex].Cells["IncomeId"].FormattedValue);
                        Util.FileRead.financeId = selectedIncomeId;

                        UpdateIncomeView updateIncome = new UpdateIncomeView();
                        Hide();
                        updateIncome.ShowDialog();
                    }
                }
            }
            else if (incomeTable.Columns[e.ColumnIndex].Name == "IncomeRemove")
            {
                if (incomeTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (MessageBox.Show("Are you sure to remove the data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        incomeTable.CurrentRow.Selected = true;
                        int selectedIncomeId = Convert.ToInt32(incomeTable.Rows[e.RowIndex].Cells["IncomeId"].FormattedValue);

                        Controllers.IncomeController incomeController = new Controllers.IncomeController();
                        bool isRemoved = incomeController.removeIncome(selectedIncomeId);
                        if (isRemoved == true)
                        {
                            if (MessageBox.Show("The income has deleted successfully", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                            {
                                incomeTable.Rows.RemoveAt(incomeTable.Rows[e.RowIndex].Index);
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("The income delete operation couldn't be completed, Please try again", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                        }
                    }
                }
            }

        }

        private void expenseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (expenseTable.Columns[e.ColumnIndex].Name == "ExpenseEdit")
            {
                if (expenseTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (MessageBox.Show("Are you sure to update the data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       expenseTable.CurrentRow.Selected = true;
                       int selectedExpenseId = Convert.ToInt32(expenseTable.Rows[e.RowIndex].Cells["ExpenseId"].FormattedValue);
                       Util.FileRead.financeId = selectedExpenseId;

                       UpdateExpenseView updateExpense = new UpdateExpenseView();
                       Hide();
                       updateExpense.ShowDialog();
                    }
                }
            }
            else if (expenseTable.Columns[e.ColumnIndex].Name == "ExpenseRemove")
            {
                if (expenseTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (MessageBox.Show("Are you sure to remove the data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        expenseTable.CurrentRow.Selected = true;
                        int selectedExpenseId = Convert.ToInt32(expenseTable.Rows[e.RowIndex].Cells["ExpenseId"].FormattedValue);

                        Controllers.ExpenseController expenseController = new Controllers.ExpenseController();

                        bool isRemoved = expenseController.removeExpense(selectedExpenseId);
                        if (isRemoved == true)
                        {
                            if (MessageBox.Show("The expense has deleted successfully", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                            {
                                expenseTable.Rows.RemoveAt(expenseTable.Rows[e.RowIndex].Index);
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("The expense delete operation couldn't be completed, Please try again", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                        }
                    }
                }
            }
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
        }

        private void FinancialReportView_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            DateTime startDate = DateTime.Now.AddMonths(Util.FileRead.defaultMonthValue);

            incomeStartDate.Value  = startDate;
            incomeEndDate.Value = currentDate;
            expenseStartDate.Value = startDate;
            expenseEndDate.Value = currentDate;

            incomeTable.Rows.Clear();
            Controllers.ReportController reportController = new Controllers.ReportController();
            List<Income> incomeDetails = reportController.getIncomeData(startDate, currentDate);
           
            foreach (Income incomeDetail in incomeDetails)
            {
                incomeTable.Rows.Add(incomeDetail.Id, incomeDetail.Name, incomeDetail.Contact.Name, incomeDetail.Type, 
                    incomeDetail.Amount, incomeDetail.Category, incomeDetail.Date);
            }

            expenseTable.Rows.Clear();
            List<Expense> expenseDetails = reportController.getExpenseData(startDate, currentDate);

            foreach (Expense expenseDetail in expenseDetails)
            {
                expenseTable.Rows.Add(expenseDetail.Id, expenseDetail.Name, expenseDetail.Contact.Name, expenseDetail.Type,
                    expenseDetail.Amount, expenseDetail.Category, expenseDetail.Date);
            }

        }
    }
}
