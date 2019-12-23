using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Migration.Core;
using Migration.Services;

namespace Migration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public IEnumerable<ContactDetails> Get()
        {
            return contactService.Get();
        }


        [HttpGet("{id}", Name = "Get")]
        public ContactDetails Get(int id)
        {
            return contactService.Get(id);
        }

        [HttpPost]
        public int Post(ContactDetails contactDetails)
        {
            return contactService.Post(contactDetails);
        }

        [HttpPut]
        public int Put(ContactDetails contactDetails)
        {
            return contactService.Put(contactDetails);
        }

        [HttpDelete]
        public int Delete(int id)
        {
            return contactService.Delete(id);
        }
    }
}
