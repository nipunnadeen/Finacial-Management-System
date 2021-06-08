using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagementApplication
{
    public partial class AddContactView : Form
    {
        public AddContactView()
        {
            InitializeComponent();
        }

        private void insertContact(object sender, EventArgs e)
        {
            String name = addContactName.Text;
            String phoneNumber = addContactPhoneNumber.Text;
            String emailAddress = addContactEmail.Text;
            String address = addContactAddress.Text;

            if (string.IsNullOrEmpty(name) == false && string.IsNullOrEmpty(phoneNumber) == false && 
                string.IsNullOrEmpty(emailAddress) == false && string.IsNullOrEmpty(address) == false)
            {
                if (Util.FileRead.numberValidation(phoneNumber) == true)
                {
                    contactValidation.Text = "Please enter a valid phone number";
                }
                else if (IsValidEmailType(emailAddress) == false)
                {
                    contactValidation.Text = "Please enter a valid email address";
                }
                else
                {
                    Controllers.ContactController contactController = new Controllers.ContactController();
                    bool contact = contactController.insertContact(name, phoneNumber, emailAddress, address);

                    if (contact == true)
                    {
                        if (MessageBox.Show("Contact has added successfully", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            ContactView contactView = new ContactView();
                            Hide();
                            contactView.ShowDialog();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The contact add operation couldn't be completed, Please try again", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                    }
                }
            } 
            else
            {
                contactValidation.Text = "Please complete the empty fields";
            }
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            Util.FileRead fileRead = new Util.FileRead();
            FMData.ContactDetailRow temporaryContactData = fileRead.readTempororyContactData();

            if (temporaryContactData != null && temporaryContactData.IsnameNull() == false && temporaryContactData.IsphoneNumberNull() == false &&
                temporaryContactData.IsemailNull() == false && temporaryContactData.IsaddressNull() == false )
            {
                addContactName.AppendText(temporaryContactData.name);
                addContactPhoneNumber.AppendText(temporaryContactData.phoneNumber);
                addContactEmail.AppendText(temporaryContactData.email);
                addContactAddress.AppendText(temporaryContactData.address);
            }
        }

        private void cancelAddContact_Click(object sender, EventArgs e)
        {
            ContactView contactView = new ContactView();
            Hide();
            contactView.ShowDialog();
        }

        bool IsValidEmailType(string email)
        {
            string ValidEmailAddressPattern = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$";
            var regex = new Regex(ValidEmailAddressPattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
