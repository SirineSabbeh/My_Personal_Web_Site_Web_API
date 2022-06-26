using API.Context;
using API.Entities;

using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public AppDBContext  _context { get; set; }
   
        public ContactController(AppDBContext context)
        {
            this._context = context;
          
           
                
        }
        [HttpPost]
        public ActionResult AddContact(ContactModel contact)
        {
            var _contact = new Contacte()
            {
                FullName = contact.FullName,
                Email = contact.Email,
                Subject=contact.Subject,
                Message=contact.Message


            };
            _context.Contacts.Add(_contact);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public ActionResult GetContacts()
        {
            var lis = _context.Contacts.ToList();
            return Ok(lis);
        }
        [HttpDelete]
        public ActionResult DeleteContact(int id) {

            var lis = _context.Contacts.FirstOrDefault(p => p.Id == id);
            _context.Contacts.Remove(lis);
            _context.SaveChanges();
            return Ok();
        }
    }
}
