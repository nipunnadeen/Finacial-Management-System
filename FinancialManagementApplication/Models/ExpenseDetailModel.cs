using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Models
{
    class ExpenseDetailModel
    {
        FMSystemContainer db = new FMSystemContainer();
        FMData fm = new FMData();

        public void writeXmlFile()
        {
            fm.WriteXml(Util.FileRead.filePath);
        }

        public bool addExpense(string name, string amount, int contactId, string category, string type, DateTime date)
        {
            fm.ExpenseDetail.Clear();
            fm.ExpenseDetail.AddExpenseDetailRow(name, contactId.ToString(), type, category, amount, date.ToString());
          
            Thread threads = new Thread(() => writeXmlFile());
            threads.Start(); // start a Thread

            try
            {
                Expense dataExpense = new Expense();

                dataExpense.Name = name;
                dataExpense.Type = type;
                dataExpense.Amount = Convert.ToDecimal(amount);
                dataExpense.Date = date;
                dataExpense.Category = category;
                dataExpense.ContactId = contactId;
                dataExpense.UserInfoId = Util.FileRead.userEmailId;

                db.Expenses.Add(dataExpense);
                var rowAffect = db.SaveChanges();

                if (rowAffect == 1)
                {
                    File.Delete(Util.FileRead.filePath);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        /// <summary>
        /// Get the specific expense detail
        /// </summary>
        /// <param name="expenseId">args will be passed when starting this function</param>
        /// <returns>dataUser</returns>
        public Expense getSelectedExpense(int expenseId)
        {
            try
            {
                Expense dataUser = db.Expenses.Find(expenseId);
                return dataUser;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        public bool updateExpenseDetail(string name, string amount, int contactId, string category, string type, DateTime date)
        {
            try
            {
                int expenseId = Util.FileRead.financeId;
                int userId = Util.FileRead.userEmailId;

                var checkExpense = db.Expenses.Find(expenseId);
                if (checkExpense != null)
                {
                    var updatedExpense = db.Expenses.First(g => g.Id == expenseId);
                    updatedExpense.Name = name;
                    updatedExpense.Type = type;
                    updatedExpense.Amount = Convert.ToDecimal(amount);
                    updatedExpense.Date = date;
                    updatedExpense.Category = category;
                    updatedExpense.ContactId = contactId;
                    updatedExpense.UserInfoId = userId;
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        /// <summary>
        /// Remove the specific expense detail from the DB
        /// </summary>
        /// <param name="expenseId">args will be passed when starting this function</param>
        /// <returns>true</returns>
        public bool removeExpenseDetail(int expenseId)
        {
            try
            {
                Expense dataExpense = new Expense();

                dataExpense.Id = expenseId;

                db.Expenses.Attach(dataExpense);
                db.Expenses.Remove(dataExpense);
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }
    }
}
