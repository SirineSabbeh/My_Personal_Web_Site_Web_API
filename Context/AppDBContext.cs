using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext( DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Contacte> Contacts{ get; set; }
    }
}
