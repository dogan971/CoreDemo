using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Contact
    {

        [Key]
        public int contactID { get; set; }
        public string contactName { get; set; }
        public string contactMail { get; set; }
        public string contactSubject { get; set; }
        public string contactMsg { get; set; }
        public DateTime contactDate { get; set; }
        public bool contactStatus { get; set; }
    }
}
