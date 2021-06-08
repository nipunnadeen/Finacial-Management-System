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
    public partial class UpdateIncomeView : Form
    {
        public UpdateIncomeView()
        {
            InitializeComponent();
        }

        private void submitUpdateIncome_Click(object sender, EventArgs e)
        {
            
            String name = updateIncomeName.Text;
            String amount = updateIncomeAmount.Text;
            String category = updateIncomeCategory.Text;
            String type = updateIncomeType.Text;
            DateTime date = updateIncomeDate.Value;

            if (string.IsNullOrEmpty(name) == false && string.IsNullOrEmpty(updateIncomeContact.Text) == false &&
                string.IsNullOrEmpty(amount) == false)
            {
                int contactId;
                int.TryParse(updateIncomeContact.SelectedValue.ToString(), out contactId);

                if (Util.FileRead.numberValidation(amount) == true)
                {
                    incomeValidation.Text = "Please enter a valid amount";
                }
                else
                {
                    Controllers.IncomeController incomeController = new Controllers.IncomeController();
                    bool income = incomeController.updateIncome(name, amount, contactId, category, type, date);
                    if (income == true)
                    {
                        if (MessageBox.Show("Income has updated successfully", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            FinancialReportView fReport = new FinancialReportView();
                            Hide();
                            fReport.ShowDialog();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The income update operation couldn't be completed, Please try again", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                    }
                }  
            }
            else
            {
                incomeValidation.Text = "Please complete the empty fields";
            }
        }

        private void UpdateIncome_Load(object sender, EventArgs e)
        {
            Controllers.ContactController contactController = new Controllers.ContactController();
           
            var contactData = contactController.getContacts();
            if (contactData.Count() > 0)
            {
                updateIncomeContact.DataSource = contactData;
                updateIncomeContact.DisplayMember = "Name";
                updateIncomeContact.ValueMember = "Id";
                updateIncomeContact.SelectedIndex = 0;
            }

            string[] categories = Util.FileRead.categories;
            foreach (string category in categories)
            {
                updateIncomeCategory.Items.Add(category);
            }

            string[] types = Util.FileRead.types;
            foreach (string type in types)
            {
                updateIncomeType.Items.Add(type);
            }

            Controllers.IncomeController incomeController = new Controllers.IncomeController();
            int incomeId = Util.FileRead.financeId;
            Income income = incomeController.getIncome(incomeId);

            updateIncomeName.AppendText(income.Name);
            updateIncomeAmount.AppendText(income.Amount.ToString());
            updateIncomeContact.SelectedValue = income.ContactId;
            updateIncomeCategory.SelectedIndex = updateIncomeCategory.Items.IndexOf(income.Category);
            updateIncomeType.SelectedIndex = updateIncomeType.Items.IndexOf(income.Type);
            updateIncomeDate.Value = income.Date;
        }

        private void cancelUpdateIncome_Click(object sender, EventArgs e)
        {
            FinancialReportView fReport = new FinancialReportView();
            Hide();
            fReport.ShowDialog();
        }
    }
}
