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
    public class SkilllsController : ControllerBase
    {
        public AppDBContext _Db { get; set; }
        public SkilllsController(AppDBContext _context)
        {
            this._Db = _context;
                
        }
        [HttpGet]
        public ActionResult GetAllSkills() {

            var lis = _Db.Skills.ToList();
            return Ok(lis);
        
        
        }
        [HttpPost]
        public ActionResult AddSkill(skillModel sk)
        {


            var _skill = new Skills()
            {
                Skill=sk.Skill,
                progress=sk.progress
            };
            _Db.Skills.Add(_skill);
            _Db.SaveChanges();




            return Ok();


        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var lis = _Db.Skills.FirstOrDefault(p => p.Id == id);
            _Db.Remove(lis);
            _Db.SaveChanges();
            return Ok();

        }
    }
}
