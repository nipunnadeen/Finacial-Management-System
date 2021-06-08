using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Util
{
    class FileRead
    {
        public static int userEmailId;
        public static int financeId;
        public static readonly string[] categories = { "Tax", "Bill", "Rental", "Groceries" };
        public static readonly string[] types = { "Recurrent", "One-of"};
        public static readonly int defaultMonthValue = -1;
        public static readonly string filePath = @"E:/C#_projects/FinancialManagementApplication/Xml/FMData.xml";

        FMData fm = new FMData();

        /// <summary>
        /// this will read the contact data from the XML file
        /// </summary>
        /// <returns>data</returns>
        public FMData.ContactDetailRow readTempororyContactData()
        {
            FMData.ContactDetailRow data = null;
            if (File.Exists(filePath) == true)
            {
                fm.ReadXml(filePath);
                if (fm.ContactDetail.Count != 0)
                {
                    data = fm.ContactDetail[0];
                }
            }
            return data;
        }

        /// <summary>
        /// this will read the income data from the XML file
        /// </summary>
        /// <returns>data</returns>
        public FMData.IncomeDetailRow readTempororyIncomeData()
        {
            FMData.IncomeDetailRow data = null;
            if (File.Exists(filePath) == true)
            {
                fm.ReadXml(filePath);
                if (fm.IncomeDetail.Count != 0)
                {
                    data = fm.IncomeDetail[0];
                }
            }
            return data;
        }

        /// <summary>
        /// this will read the expense data from the XML file
        /// </summary>
        /// <returns>data</returns>
        public FMData.ExpenseDetailRow readTempororyExpenseData()
        {
            FMData.ExpenseDetailRow data = null;
            if (File.Exists(filePath) == true)
            {
                fm.ReadXml(filePath);
                if (fm.ExpenseDetail.Count != 0)
                {
                    data = fm.ExpenseDetail[0];
                }
            }
            return data;
        }

        /// <summary>
        /// this will validate the amounts inputs of the incomes and expenses 
        /// </summary>
        /// <param name="amount">args will be passed when starting this program</param>
        /// <returns>false</returns>
        public static bool numberValidation(string amount)
        {
            decimal d;

            var regexItem = new Regex(@"-");

            if (decimal.TryParse(amount, out d))
            {
                if (regexItem.IsMatch(amount) == true)
                {
                    return true;
                }
                else if(Convert.ToDouble(amount) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
