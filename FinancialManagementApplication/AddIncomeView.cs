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
    public partial class AddIncomeView : Form
    {
        public AddIncomeView()
        {
            InitializeComponent();
        }

        private void submitAddIncome_Click(object sender, EventArgs e)
        {
            String name = addIncomeName.Text;
            String amount = addIncomeAmount.Text;
            String category = addIncomeCategory.Text;
            String type = addIncomeType.Text;
            DateTime date = addIncomeDate.Value;

            if (string.IsNullOrEmpty(name) == false && string.IsNullOrEmpty(addIncomeContact.Text) == false &&
                string.IsNullOrEmpty(amount) == false)
            {
                int contactId;
                int.TryParse(addIncomeContact.SelectedValue.ToString(), out contactId);

                if (Util.FileRead.numberValidation(amount) == true)
                {
                    incomeValidation.Text = "Please enter a valid amount";
                } 
                else
                {
                    Controllers.IncomeController incomeController = new Controllers.IncomeController();
                    bool income = incomeController.insertIncome(name, amount, contactId, category, type, date);

                    if (income == true)
                    {
                        if (MessageBox.Show("Income has added successfully", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            MainMenu mainMenu = new MainMenu();
                            Hide();
                            mainMenu.ShowDialog();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The income add operation couldn't be completed, Please try again", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                    }
                }
            }
            else
            {
                incomeValidation.Text = "Please complete the empty fields";
            }
        }

        private void AddIncome_Load(object sender, EventArgs e)
        {
            Controllers.ContactController contactController = new Controllers.ContactController();
            Util.FileRead fileRead = new Util.FileRead();
            FMData.IncomeDetailRow temporaryIncomeData = fileRead.readTempororyIncomeData();

            var contactData = contactController.getContacts();

            if (contactData.Count() > 0)
            {
                addIncomeContact.DataSource = contactData;
                addIncomeContact.DisplayMember = "Name";
                addIncomeContact.ValueMember = "Id";
                addIncomeContact.SelectedIndex = 0;
            }
            
            string[] categories = Util.FileRead.categories;
            foreach (string category in categories)
            {
                addIncomeCategory.Items.Add(category);
            }
            addIncomeCategory.SelectedIndex = 0;

            string[] types = Util.FileRead.types;
            foreach (string type in types)
            {
                addIncomeType.Items.Add(type);
            }
            addIncomeType.SelectedIndex = 0;

            if (temporaryIncomeData != null && temporaryIncomeData.IsnameNull() == false && temporaryIncomeData.IsamountNull() == false &&
                temporaryIncomeData.IscontactNull() == false && temporaryIncomeData.IscategoryNull() == false &&
                temporaryIncomeData.IstypeNull() == false && temporaryIncomeData.IsdateNull() == false)
            {
                addIncomeName.AppendText(temporaryIncomeData.name);
                addIncomeAmount.AppendText(temporaryIncomeData.amount);
                addIncomeContact.SelectedValue = Convert.ToInt32(temporaryIncomeData.contact);
                addIncomeCategory.SelectedIndex = addIncomeCategory.Items.IndexOf(temporaryIncomeData.category);
                addIncomeType.SelectedIndex = addIncomeType.Items.IndexOf(temporaryIncomeData.type);
                addIncomeDate.Value = (Convert.ToDateTime(temporaryIncomeData.date));
            }

        }

        private void cancelAddIncome_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
        }
    }
}
