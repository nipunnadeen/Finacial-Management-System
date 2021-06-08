using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Controllers
{
    class ReportController
    {
        Models.FinancialDetail financialDetail = new Models.FinancialDetail();
        public List<Income> getIncomeData(DateTime startDate, DateTime endDate)
        {
            List<Income> incomeData = financialDetail.getFilteredIncomeDetail(startDate, endDate);
            return incomeData;
        }
        public List<Expense> getExpenseData(DateTime startDate, DateTime endDate)
        {
            List<Expense> expenseData = financialDetail.getFilteredExpenseDetail(startDate, endDate);
            return expenseData;
        }
    }
}
