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
    public partial class ContactView : Form
    {
        public ContactView()
        {
            InitializeComponent();
        }

        private void ContactView_Load(object sender, EventArgs e)
        {
            contactTable.Rows.Clear();

            Controllers.ContactController contactController = new Controllers.ContactController();
            List<Contact> contactDetails = contactController.getContacts();

            foreach (Contact contactDetail in contactDetails)
            {
                contactTable.Rows.Add(contactDetail.Id, contactDetail.Name, contactDetail.PhoneNumber, contactDetail.Email, 
                    contactDetail.Address);
            }

        }

        private void addContact_Click(object sender, EventArgs e)
        {
            AddContactView addContact = new AddContactView();
            Hide();
            addContact.ShowDialog();
        }

        private void contactTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contactTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (contactTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (MessageBox.Show("Are you sure to update the data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        contactTable.CurrentRow.Selected = true;
                        int selectedContactId = Convert.ToInt32(contactTable.Rows[e.RowIndex].Cells["ID"].FormattedValue);
                        Util.FileRead.financeId = selectedContactId;

                        UpdateContactView updateContact = new UpdateContactView();
                        Hide();
                        updateContact.ShowDialog();

                    }
                }
            }
            else if (contactTable.Columns[e.ColumnIndex].Name == "Remove")
            {
                if (contactTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (MessageBox.Show("Are you sure to remove the data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        contactTable.CurrentRow.Selected = true;
                        int selectedContactId = Convert.ToInt32(contactTable.Rows[e.RowIndex].Cells["ID"].FormattedValue);

                        Controllers.ContactController contactController = new Controllers.ContactController();

                        bool isRemoved = contactController.removeContact(selectedContactId);
                        if (isRemoved == true)
                        {
                            if (MessageBox.Show("The contact has deleted successfully", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                            {
                                contactTable.Rows.RemoveAt(contactTable.Rows[e.RowIndex].Index);
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Sorry you can't delete the contact which is already used", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
                        }
                    }
                }
            }
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
        }
    }
}
