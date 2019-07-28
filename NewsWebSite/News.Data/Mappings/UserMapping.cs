using News.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable("User");                          // Tablo ismini belirtiyoruz
            Property(i => i.Email).IsRequired();      // email alanını zorunlu kılıyoruz
            Property(i => i.Password).IsRequired();   // password alanını zorunlu kılıyoruz
        }
    }
}
