using Sloth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sloth.Entities
{
    public class SlothContext : DbContext
    {
        public SlothContext()
        
            :base(@"Data Source =.\SQLEXPRESS; Initial Catalog = Sloth; Integrated Security = True;")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SlothContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Corparate> Corparates { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
