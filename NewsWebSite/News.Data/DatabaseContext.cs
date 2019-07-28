using News.Domain;
using News.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            //Database.Connection.ConnectionString = @"Server=BK-LAB204-IS004; Database=NTVDatabase; UID=sa; Password=123;";
            Database.Connection.ConnectionString = @"Data Source=.;Initial Catalog=NtvNews;Integrated Security=True";
        }

        public DbSet<Newscast> Newscast { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new NewscastMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        
    }
}
