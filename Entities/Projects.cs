using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Projects
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Githurl { get; set; }
        public string ImgUrl { get; set; }
        public string Worktech { get; set; }
    }
}
