using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Controllers
{
    class IncomeController
    {
        Models.IncomeDetailModel incomeDetail = new Models.IncomeDetailModel();
        public bool insertIncome(string name, string amount, int contactId, string category, string type, DateTime date)
        {
            return incomeDetail.addIncome(name, amount, contactId, category, type, date);
        }
        public bool updateIncome(string name, string amount, int contactId, string category, string type, DateTime date)
        {
            return incomeDetail.updateIncomeDetail(name, amount, contactId, category, type, date);
        }
        public bool removeIncome(int incomeId)
        {
            return incomeDetail.removeIncomeDetail(incomeId);
        }
        public Income getIncome(int incomeId)
        {
            return incomeDetail.getSelectedIncome(incomeId);
        }
    }
}
