using API.Context;
using Microsoft.AspNetCore.Cors;
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
    [EnableCors("OpenCORSPolicy")]

    public class ExperienceController : ControllerBase
    {
        private AppDBContext _context;

        public ExperienceController(AppDBContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public ActionResult GetExperience() {
            var lis = _context.Experiences.ToList();
            return Ok(lis);
                
                }
        

    }
}
