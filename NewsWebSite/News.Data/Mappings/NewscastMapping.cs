using News.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace News.Data.Mappings
{
    public class NewscastMapping : EntityTypeConfiguration<Newscast>
    {
        public NewscastMapping()
        {
            ToTable("Newscast");
            Property(i => i.NewsTitle).IsRequired();
            Property(i => i.NewsContent).IsRequired();
            Property(i => i.CategoryId).IsRequired();
            //HasRequired(i => i.NewsCategory);
        }
    }


    
}
