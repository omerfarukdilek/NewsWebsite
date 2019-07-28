using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? TimeOfCreation { get; set; }
        public DateTime? TimeOfModification { get; set; }
    }
}
