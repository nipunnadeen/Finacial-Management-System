using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Models
{
    class IncomeDetailModel
    {
        FMSystemContainer db = new FMSystemContainer();
        FMData fm = new FMData();

        public void writeXmlFile()
        {
            fm.WriteXml(Util.FileRead.filePath);
        }

        public bool addIncome(string name, string amount, int contactId, string category, string type, DateTime date)
        {
            fm.IncomeDetail.Clear();
            fm.IncomeDetail.AddIncomeDetailRow(name, contactId.ToString(), type, category, amount, date.ToString());
           
            Thread threads = new Thread(() => writeXmlFile());
            threads.Start(); // start a Thread

            try
            {
                Income dataIncome = new Income();

                dataIncome.Name = name;
                dataIncome.Type = type;
                dataIncome.Amount = Convert.ToDecimal(amount);
                dataIncome.Date = date;
                dataIncome.Category = category;
                dataIncome.ContactId = contactId;
                dataIncome.UserInfoId = Util.FileRead.userEmailId;

                db.Incomes.Add(dataIncome);
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
        /// Get the specific income detail
        /// </summary>
        /// <param name="incomeId">args will be passed when starting this function</param>
        /// <returns>dataUser</returns>
        public Income getSelectedIncome(int incomeId)
        {
            try
            {
                Income dataUser = db.Incomes.Find(incomeId);
                return dataUser;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        public bool updateIncomeDetail(string name, string amount, int contactId, string category, string type, DateTime date)
        {
            try
            {
                int incomeId = Util.FileRead.financeId;
                int userId = Util.FileRead.userEmailId;

                var checkIncome = db.Incomes.Find(incomeId);
                if (checkIncome != null)
                {
                    var updatedIncome = db.Incomes.First(g => g.Id == incomeId);
                    updatedIncome.Name = name;
                    updatedIncome.Type = type;
                    updatedIncome.Amount = Convert.ToDecimal(amount);
                    updatedIncome.Date = date;
                    updatedIncome.Category = category;
                    updatedIncome.ContactId = contactId;
                    updatedIncome.UserInfoId = userId;
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
        /// Remove the specific income detail from the DB
        /// </summary>
        /// <param name="incomeId">args will be passed when starting this function</param>
        /// <returns>true</returns>
        public bool removeIncomeDetail(int incomeId)
        {
            try
            {
                Income dataIncome = new Income();

                dataIncome.Id = incomeId;
                db.Incomes.Attach(dataIncome);
                db.Incomes.Remove(dataIncome);
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
