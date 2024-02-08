using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using AspNoteBook.Entities;
using AspNoteBook.Models;

namespace AspNoteBook.Services
{
    /// <summary>
    /// Создаёт модели на основе запрашиваемых данных
    /// </summary>
    public class NotebookService : INotebookService
    {
        private readonly XmlDocument doc = new XmlDocument();

        /// <summary>
        /// Возвращает модель, содержащую список контактов
        /// </summary>
        /// <returns></returns>
        public ContactListModel GetContactList()
        {
            ContactListModel model = new ContactListModel();
            GetAllContacts(model);
            return model;
        }

        /// <summary>
        /// Возаращает модель, содержащую данные о контакте
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ContactInfoModel GetContact(int id)
        {
            return new ContactInfoModel(FindContact(id));
        }

        /// <summary>
        /// Возвращает список контактов
        /// </summary>
        /// <param name="model"></param>
        private void GetAllContacts(ContactListModel model)
        {
            doc.Load("Notebook.xml");
            XmlElement contactsXmlElement = doc.DocumentElement;

            foreach (XmlElement contact in contactsXmlElement.ChildNodes)
            {
                model.Add(new ContactEntity()
                {
                    Id = int.Parse(contact.Attributes["id"].Value),
                    LastName = contact.Attributes["lastName"].Value,
                    FirstName = contact.Attributes["firstName"].Value,
                    Patronymic = contact.Attributes["patronymic"].Value
                });
            }
        }

        /// <summary>
        /// Находит и возвращает контакт по его Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private ContactEntity FindContact(int id)
        {
            doc.Load("Notebook.xml");
            XmlElement contactsXmlElement = doc.DocumentElement;

            foreach (XmlElement contact in contactsXmlElement.ChildNodes)
            {
                if (int.Parse(contact.Attributes["id"].Value) == id) return new ContactEntity()
                {
                    Id = int.Parse(contact.Attributes["id"].Value),
                    LastName = contact.Attributes["lastName"].Value,
                    FirstName = contact.Attributes["firstName"].Value,
                    Patronymic = contact.Attributes["patronymic"].Value,
                    Phone = contact.Attributes["phone"].Value,
                    Address = contact.Attributes["address"].Value,
                    Description = contact.Attributes["description"].Value
                };
            }

            return null;
        }
    }
}
