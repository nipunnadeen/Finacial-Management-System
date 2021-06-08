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
    public partial class UpdateContactView : Form
    {
        public UpdateContactView()
        {
            InitializeComponent();
        }

        private void UpdateContact_Load(object sender, EventArgs e)
        {
            Controllers.ContactController contactController = new Controllers.ContactController();
            Contact contactData = contactController.getSelectedContactDetail();

            updateContactName.AppendText(contactData.Name);
            updateContactPhoneNumber.AppendText(contactData.PhoneNumber.ToString());
            updateContactEmail.AppendText(contactData.Email);
            updateContactAddress.AppendText(contactData.Address);
            
        }

        private void cancelUpdateContact_Click(object sender, EventArgs e)
        {
            ContactView contactView = new ContactView();
            Hide();
            contactView.ShowDialog();
        }

        private void submitUpdateContact_Click(object sender, EventArgs e)
        {
            String name = updateContactName.Text;
            String phoneNumber = updateContactPhoneNumber.Text;
            String emailAddress = updateContactEmail.Text;
            String address = updateContactAddress.Text;

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
                    bool contact = contactController.updateContact(name, phoneNumber, emailAddress, address);

                    if (contact == true)
                    {
                        if (MessageBox.Show("Contact has updated successfully", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            ContactView contactView = new ContactView();
                            Hide();
                            contactView.ShowDialog();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The contact update operation couldn't be completed, Please try again", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                    }
                }
            }
            else
            {
                contactValidation.Text = "Please complete the empty fields";
            }
        }
        bool IsValidEmailType(string email)
        {
            string ValidEmailAddressPattern = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$";
            var regex = new Regex(ValidEmailAddressPattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
