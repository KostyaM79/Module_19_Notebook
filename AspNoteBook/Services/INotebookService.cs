using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNoteBook.Models;

namespace AspNoteBook.Services
{
    public interface INotebookService
    {
        ContactListModel GetContactList();

        ContactInfoModel GetContact(int id);
    }
}
