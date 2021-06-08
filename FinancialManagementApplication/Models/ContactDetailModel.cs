using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Models
{
    class ContactDetailModel
    {
        FMData fm = new FMData();
        FMSystemContainer db = new FMSystemContainer();
        
        public void writeXmlFile()
        {
            fm.WriteXml(Util.FileRead.filePath);
        }

        public bool addContact(string name, string phoneNumber, string email, string address)
        {
            fm.ContactDetail.Clear();
            fm.ContactDetail.AddContactDetailRow(name, phoneNumber.ToString(), email, address);

            Thread threads = new Thread(() => writeXmlFile());
            threads.Start(); // start a Thread

            Contact dataContact = new Contact();

            try
            {
                dataContact.Name = name;
                dataContact.PhoneNumber = phoneNumber;
                dataContact.Email = email;
                dataContact.Address = address;
                dataContact.UserInfoId = Util.FileRead.userEmailId;

                db.Contacts.Add(dataContact);
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
            catch(Exception e)
            {
                return false;
                throw e;
            }
        }
        public bool updateContactDetail(string name, string phoneNumber, string email, string address)
        {
            Contact dataContact = new Contact();
            try
            {
                int contactId = Util.FileRead.financeId;
                int userId = Util.FileRead.userEmailId;

                var checkContact = db.Contacts.Find(contactId);
                if (checkContact != null)
                {
                    var updatedContact = db.Contacts.First(g => g.Id == contactId);
                    updatedContact.Name = name;
                    updatedContact.PhoneNumber = phoneNumber;
                    updatedContact.Email = email;
                    updatedContact.Address = address;
                    updatedContact.UserInfoId = userId;
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
        /// Remove the specifi contact from DB 
        /// </summary>
        /// <param name="contactId">args will be passed when starting this function</param>
        /// <returns>true</returns>
        public bool removeContactDetail(int contactId)
        {
            try
            {
                Contact dataContact = new Contact();

                dataContact.Id = contactId;
                db.Contacts.Attach(dataContact);
                db.Contacts.Remove(dataContact);
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        /// <summary>
        /// this will get the specific contact details 
        /// </summary>
        /// <returns>dataContact</returns>
        public Contact getSelectedContact()
        {

            Contact dataContact = new Contact();
            try
            {
                int contactId = Util.FileRead.financeId;
                dataContact = db.Contacts.Find(contactId);
               
                return dataContact;
            }
            catch (Exception e)
            {
                return dataContact;
                throw e;
            }

        }

        /// <summary>
        /// this will get the all contacts details 
        /// </summary>
        /// <returns>contacts</returns>
        public List<Contact> getContactsDetail()
        {
            try
            {
                int userId = Util.FileRead.userEmailId;

                var contacts = (from s in db.Contacts where s.UserInfoId == userId select s).ToList();
                return contacts;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
