using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using AspNoteBook.Entities;

namespace AspNoteBook.Models
{
    public class ContactListModel
    {
        private List<ContactEntity> contacts = new List<ContactEntity>();

        public ContactEntity[] Contacts => contacts.ToArray();

        public void Add(ContactEntity contact) => contacts.Add(contact);
    }
}
