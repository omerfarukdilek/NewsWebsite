using System.Collections.Generic;

namespace News.Domain
{
    public class Category : BaseEntity
    {
        public Category()
        {
            this.Newscasts = new List<Newscast>();
        }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public IEnumerable<Newscast> Newscasts { get; set; }
    }
}
