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
    public class ProjectsController : ControllerBase
    {
        public  AppDBContext _Db { get; set; }
        public ProjectsController(AppDBContext context)
        {
            this._Db = context;
        }
        [HttpGet]
        public ActionResult ListOfProjects()
        {
            var lis = _Db.Projects.ToList();
            return Ok(lis);
        }
        [HttpPost]
        public ActionResult AddProject(ProjectModel project)
        {
            var _project = new Projects()
            {
                Title = project.Title,
                Desc = project.Desc,
                Githurl = project.Githurl,
                ImgUrl = project.ImgUrl,
                Worktech = project.Worktech
            };
            _Db.Projects.Add(_project);
            _Db.SaveChanges();



          
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete (int id)
        {
            var lis = _Db.Projects.FirstOrDefault(p => p.Id == id);
            _Db.Remove(lis);
            _Db.SaveChanges();
            return Ok(); 

        }
        [HttpPut]
        public ActionResult UpdateProject(int id,ProjectModel project)
        {

            var _project = _Db.Projects.FirstOrDefault(p => p.Id == id);
            if (_project != null)
            {
                _project.Title = project.Title;
                _project.Desc = project.Desc;
                _project.Githurl = project.Githurl;
                _project.ImgUrl = project.ImgUrl;
                _project.Worktech = project.Worktech;


            }
            _Db.Projects.Update(_project);
            _Db.SaveChanges();




            return Ok();
        }
    }
}
