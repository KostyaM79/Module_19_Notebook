using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNoteBook.Entities;

namespace AspNoteBook.Models
{
    public class ContactInfoModel
    {
        private readonly ContactEntity contact;

        public ContactInfoModel(ContactEntity contact)
        {
            this.contact = contact;
        }

        public int Id => contact.Id;
        public string LastName => contact.LastName;
        public string FirstName => contact.FirstName;
        public string Patronymic => contact.Patronymic;
        public string Phone => contact.Phone;
        public string Address => contact.Address;
        public string Description => contact.Description;
    }
}
