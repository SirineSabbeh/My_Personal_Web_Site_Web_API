using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class ContactModel
    {
        public ContactModel(string fullName,string email, string subject, string message)
        {
            FullName = fullName;
            Email = email;
            Subject = subject;
            Message = message;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }



      
    }
}
