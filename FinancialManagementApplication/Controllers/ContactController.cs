using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Controllers
{
    class ContactController
    {
        Models.ContactDetailModel contactDetail = new Models.ContactDetailModel();
        public bool insertContact(string name, string phoneNumber, string email, string address)
        {
            return contactDetail.addContact(name, phoneNumber, email, address);
        }

        public bool updateContact(string name, string phoneNumber, string email, string address)
        {
            return contactDetail.updateContactDetail(name, phoneNumber, email, address);
        }

        public bool removeContact(int contactId)
        {
            return contactDetail.removeContactDetail(contactId);
        }

        public List<Contact> getContacts()
        {
            return contactDetail.getContactsDetail();
        }

        public Contact getSelectedContactDetail()
        {
            return contactDetail.getSelectedContact();
        }
    }
}
