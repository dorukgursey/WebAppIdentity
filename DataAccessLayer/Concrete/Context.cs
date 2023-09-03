using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        private readonly string connection = "Host=localhost;Port=5432;Database=WebAppIdentity;Username=postgres;Password=DozoDashBoard1234!";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connection);
        }

        public DbSet<MainAbout> MainAbouts { get; set; }
        public DbSet<SecondAbout> SecondAbouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<FeatureMain> FeatureMains { get; set; }
        public DbSet<FeatureOthers> FeatureOthers { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
