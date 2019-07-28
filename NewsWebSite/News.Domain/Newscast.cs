using System.ComponentModel.DataAnnotations.Schema;


namespace News.Domain
{
    public class Newscast : BaseEntity
    {
        public string NewsTitle { get; set; }

        public string NewsContent { get; set; }

        public string NewsImage { get; set; }

        [ForeignKey("NewsCategory")]
        public int CategoryId { get; set; }
        public Category NewsCategory { get; set; }

        
    }
}
