using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Models
{
    class Prediction
    {
        public List<decimal> predictFinancialStatus(DateTime futureDate)
        {
            FMSystemContainer db = new FMSystemContainer();
            try
            { 
                int userId = Util.FileRead.userEmailId;
                DateTime startDate = getSelectedStartDate(futureDate);
                double PastdatesDiff = calculateDateDiff(startDate);

                decimal recurrentIncome = 0;
                decimal oneOfIncome = 0;
                decimal recurrentExpense = 0;
                decimal oneOfExpense = 0;
                double futuredateDiff = calculateDateDiff(futureDate);

                var incomes = (from q in db.Incomes where q.Date >= startDate && q.Date <= futureDate && q.UserInfoId == userId select q).ToList();
                var expenses = (from q in db.Expenses where q.Date >= startDate && q.Date <= futureDate && q.UserInfoId == userId select q).ToList();

                // Calculate the total of recurrent and oneof according to incomes and expenses
                if (incomes != null)
                {
                    foreach (var income in incomes)
                    {
                        if (income.Type.Equals("Recurrent"))
                        {
                            recurrentIncome += income.Amount;
                        } 
                        else
                        {
                            oneOfIncome += income.Amount;
                        }
                    } 
                }
                if (expenses != null)
                {
                    foreach (var expense in expenses)
                    {
                        if (expense.Type.Equals("Recurrent"))
                        {
                            recurrentExpense += expense.Amount;
                        }
                        else
                        {
                            oneOfExpense += expense.Amount;
                        }
                    }
                }

                List<decimal> predictionData = predictData(recurrentIncome, oneOfIncome, recurrentExpense,
                    oneOfExpense, Convert.ToDecimal(futuredateDiff), Convert.ToDecimal(PastdatesDiff));

                return predictionData;
            } 
            catch(Exception e)
            {
                return null;
                throw e;
            }
        }

        /// <summary>
        /// this will calculate the avg incime, expense and predicted status 
        /// </summary>
        /// <returns>contactData</returns>
        public List<decimal> predictData(decimal recurrentIncome, decimal oneOfIncome, decimal recurrentExpense,
            decimal oneOfExpense, decimal futuredateDiff, decimal PastdatesDiff)
        {
            List<decimal> contactData = new List<decimal>();
            // Calculate the predicted income and expense and then calculate the final predicted status
            decimal avgIncome = ((recurrentIncome + oneOfIncome) / PastdatesDiff) * futuredateDiff;
            decimal avgExpense = ((recurrentExpense + oneOfExpense) / PastdatesDiff) * futuredateDiff;
            decimal finalValue = ((recurrentIncome + oneOfIncome) - (recurrentExpense + oneOfExpense)) + (avgIncome - avgExpense);

            contactData.Add(recurrentIncome);
            contactData.Add(oneOfIncome);
            contactData.Add(recurrentExpense);
            contactData.Add(oneOfExpense);
            contactData.Add(Math.Round(avgIncome, 2));
            contactData.Add(Math.Round(avgExpense, 2));
            contactData.Add(Math.Round(finalValue, 2));

            return contactData;
        }

        /// <summary>
        /// this will calculate the start date 
        /// </summary>
        /// <param name="futureDate">args will be passed when starting this program</param>
        /// <returns>startDate</returns>
        public DateTime getSelectedStartDate(DateTime futureDate)
        {
            double datesDiff = calculateDateDiff(futureDate);
            DateTime startDate;
            if (datesDiff >= 30)
            {
                startDate = DateTime.Now.AddMonths(-5);
            } 
            else
            {
                startDate = DateTime.Now.AddMonths(-3);
            }

            return startDate;
        }

        /// <summary>
        /// this will calculate the dates differences 
        /// </summary>
        /// <param name="date">args will be passed when starting this program</param>
        /// <returns>datesDiff</returns>
        public double calculateDateDiff(DateTime date)
        {
            DateTime currentDate = DateTime.Now;
            double datesDiff;
            if (currentDate < date)
            {
                datesDiff = (date - currentDate).TotalDays;
            }
            else
            {
                datesDiff = (currentDate - date).TotalDays;
            }
            return datesDiff;
        }
    }
}
