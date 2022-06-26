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
    public class EducationsController : ControllerBase
    {

        public AppDBContext _Db { get; set; }
        public EducationsController(AppDBContext context)
        {
            this._Db = context;
        }
        [HttpGet]
        public ActionResult ListOfProjects()
        {
            var lis = _Db.Educations.ToList();
            return Ok(lis);
        }
        [HttpPost]
        public ActionResult AddEDUCATION(EducationModel ed)
        {
            var _ed = new Education()
            {
                From_to_year = ed.From_to_year,
                Educations = ed.Educations,
                Institution = ed.Institution
             
            };
            _Db.Educations.Add(_ed);
            _Db.SaveChanges();




            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var lis = _Db.Educations.FirstOrDefault(p => p.Id == id);
            _Db.Remove(lis);
            _Db.SaveChanges();
            return Ok();

        }
      

           
}
}
