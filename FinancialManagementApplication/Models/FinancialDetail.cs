using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Models
{
    class FinancialDetail
    {
        FMSystemContainer db = new FMSystemContainer();

        /// <summary>
        /// Get the filtered income data from the DB using date range
        /// </summary>
        /// <returns>incomes</returns>
        public List<Income> getFilteredIncomeDetail(DateTime startDate, DateTime endDate)
        {
            int userId = Util.FileRead.userEmailId;
            List<Income> incomes = new List<Income>();
            try
            {
                incomes = (from q in db.Incomes where q.Date >= startDate && q.Date <= endDate && q.UserInfoId == userId select q).ToList();
                
                return incomes;
            }
            catch (Exception e)
            {
                return incomes;
                throw e;
            }
        }

        /// <summary>
        /// Get the filtered expense data from the DB using date range
        /// </summary>
        /// <returns>expenses</returns>
        public List<Expense> getFilteredExpenseDetail(DateTime startDate, DateTime endDate)
        {
            int userId = Util.FileRead.userEmailId;
            List<Expense> expenses = new List<Expense>();
            try
            {
                expenses = (from q in db.Expenses where q.Date >= startDate && q.Date <= endDate && q.UserInfoId == userId select q).ToList();

                return expenses;
            }
            catch (Exception e)
            {
                return expenses;
                throw e;
            }
        }
    }
}
