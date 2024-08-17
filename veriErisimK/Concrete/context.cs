using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varlikKatmani.Concrete;

namespace veriErisimK.Concrete
{
    public class context: IdentityDbContext<writerUser, writerRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8OU0GKQ\\SQLEXPRESS;database= WebProjeDB;integrated security = true");
            
        }

		public DbSet<about> Abouts { get; set; }
        public DbSet<contact>  Contacts { get; set; }
        public DbSet<experience>  Experiences { get; set; }
        public DbSet<feature>  Features { get; set; }
        public DbSet<message>  Messages { get; set; }
        public DbSet<portfolio>  Portfolios { get; set; }
        public DbSet<service>  Services { get; set; }
        public DbSet<skill>  Skills { get; set; }
        public DbSet<socialMedia>  socialMedias { get; set; }
        public DbSet<testimonial>  Testimonials { get; set; }
        public DbSet<toDoList> ToDoLists { get; set; }
        public DbSet<annoucement> Annoucements { get; set; }
        public DbSet<writerMessage> WriterMessages { get; set; }







    }
}
