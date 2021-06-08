using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Controllers
{
    class PredictFinanceController
    {
        public List<decimal> predictStatus(DateTime futureDate)
        {
            Models.Prediction prediction = new Models.Prediction();
            return prediction.predictFinancialStatus(futureDate);
        }
    }
}
