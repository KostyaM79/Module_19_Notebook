using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNoteBook.Models;
using AspNoteBook.Services;

namespace AspNoteBook.Controllers
{
    public class ContactsController : Controller
    {
        private readonly INotebookService notebookService;

        public ContactsController(INotebookService service)
        {
            notebookService = service;
        }

        [HttpGet("Contacts/ContactList")]
        public IActionResult ContactList()
        {
            return View(notebookService.GetContactList());
        }

        [HttpGet("Contacts/ContactInfo/{id}")]
        public IActionResult ContactInfo(int id)
        {
            return View(notebookService.GetContact(id));
        }
    }
}
