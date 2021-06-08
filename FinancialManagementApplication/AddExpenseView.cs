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
    public partial class AddExpenseView : Form
    {
        public AddExpenseView()
        {
            InitializeComponent();
        }

        private void submitAddExpense_Click(object sender, EventArgs e)
        {
            String name = addExpenseName.Text;
            String amount = addExpenseAmount.Text;
            String category = addExpenseCategory.Text;
            String type = addExpenseType.Text;
            DateTime date = addExpenseDate.Value;

            if (string.IsNullOrEmpty(name) == false && string.IsNullOrEmpty(addExpenseContact.Text) == false &&
                string.IsNullOrEmpty(amount) == false)
            {
                int contactId;
                int.TryParse(addExpenseContact.SelectedValue.ToString(), out contactId);

                if (Util.FileRead.numberValidation(amount) == true)
                {
                    expenseValidation.Text = "Please enter a valid amount";
                }
                else
                {
                    Controllers.ExpenseController expenseController = new Controllers.ExpenseController();
                    bool expense = expenseController.insertExpense(name, amount, contactId, category, type, date);

                    if (expense == true)
                    {
                        if (MessageBox.Show("Expense has added successfully", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            MainMenu mainMenu = new MainMenu();
                            Hide();
                            mainMenu.ShowDialog();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The expense add operation couldn't be completed, Please try again", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                    }
                } 
            }
            else
            {
                expenseValidation.Text = "Please complete the empty fields";
            }
        }

        private void AddExpenseView_Load(object sender, EventArgs e)
        {
            Controllers.ContactController contactController = new Controllers.ContactController();
            Util.FileRead fileRead = new Util.FileRead();
            FMData.ExpenseDetailRow temporaryExpenseData = fileRead.readTempororyExpenseData();

            var contactData = contactController.getContacts();

            if (contactData.Count() > 0)
            {
                addExpenseContact.DataSource = contactData;
                addExpenseContact.DisplayMember = "Name";
                addExpenseContact.ValueMember = "Id";
                addExpenseContact.SelectedIndex = 0;
            }
            
            string[] categories = Util.FileRead.categories;
            foreach (string category in categories)
            {
                addExpenseCategory.Items.Add(category);
            }
            addExpenseCategory.SelectedIndex = 0;

            string[] types = Util.FileRead.types;
            foreach (string type in types)
            {
                addExpenseType.Items.Add(type);
            }
            addExpenseType.SelectedIndex = 0;

            if (temporaryExpenseData != null && temporaryExpenseData.IsnameNull() == false && temporaryExpenseData.IsamountNull() == false &&
               temporaryExpenseData.IscontactNull() == false && temporaryExpenseData.IscategoryNull() == false &&
               temporaryExpenseData.IstypeNull() == false && temporaryExpenseData.IsdateNull() == false)
            {
                addExpenseName.AppendText(temporaryExpenseData.name);
                addExpenseAmount.AppendText(temporaryExpenseData.amount);
                addExpenseContact.SelectedValue = Convert.ToInt32(temporaryExpenseData.contact);
                addExpenseCategory.SelectedIndex = addExpenseCategory.Items.IndexOf(temporaryExpenseData.category);
                addExpenseType.SelectedIndex = addExpenseType.Items.IndexOf(temporaryExpenseData.type);
                addExpenseDate.Value = (Convert.ToDateTime(temporaryExpenseData.date));
            }
        }

        private void cancelAddExpense_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
        }
    }
}
