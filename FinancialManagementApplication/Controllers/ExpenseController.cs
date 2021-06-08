using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Controllers
{
    class ExpenseController
    {
        Models.ExpenseDetailModel expenseDetail = new Models.ExpenseDetailModel();
        public bool insertExpense(string name, string amount, int contactId, string category, string type, DateTime date)
        {
            return expenseDetail.addExpense(name, amount, contactId, category, type, date);
        }
        public bool updateExpense(string name, string amount, int contactId, string category, string type, DateTime date)
        {
            return expenseDetail.updateExpenseDetail(name, amount, contactId, category, type, date);
        }
        public bool removeExpense(int expenseId)
        {
            return expenseDetail.removeExpenseDetail(expenseId);
        }
        public Expense getExpense(int expenseId)
        {
            return expenseDetail.getSelectedExpense(expenseId);
        }
    }
}
