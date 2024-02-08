using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNoteBook.Entities
{
    /// <summary>
    /// Представляет контакт
    /// </summary>
    public class ContactEntity
    {
        private string phone;

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Phone
        {
            get => phone;
            set { phone = $"+7 ({value.Substring(0, 3)}) {value.Substring(3, 3)}-{value.Substring(6, 2)}-{value.Substring(8, 2)}"; }
        }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
