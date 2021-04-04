using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class ContactLists
    {
        private readonly ApplicationDbContext _db;

        public ContactLists(ApplicationDbContext db)
        {
            _db = db;
        }
        public interface IToDoListService
        {
            Task<Contact> GetContacts(Contact objContact);
            Task<Contact> Create(Contact objContact);
            Task<Contact> EditContact(Contact objContact);
            Task<Contact> DeleteContact(Contact objContact);
        }

        //Get All Contacts
        public List<Contact> GetContacts()
        {
            return _db.Contacts.ToList();
        }


        //Insert Contact info
        public string Create(Contact objContact)
        {
            _db.Contacts.Add(objContact);
            _db.SaveChanges();
            return "Successfully Created";
        }

        //Get Contact By ID
        public Contact GetContactsById(Guid id)
        {
            Contact contact = _db.Contacts.FirstOrDefault(s => s.Id == id);
            return contact;
        }

        //Edit Contact Info
        public string EditContact(Contact objContact)
        {
            _db.Contacts.Update(objContact);
            _db.SaveChanges();
            return "Successfully Edited";
        }

        //Delete Contact
        public Contact DeleteContact(Contact objContact)
        {
            _db.Contacts.Remove(objContact);
            _db.SaveChanges();
            return objContact;
        }
    }
}
