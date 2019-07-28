using News.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Contract.ViewModels
{
    public class VmModelHomePage
    {
        public List<Newscast> Newscasts { get; set; }

        public List<Category> Category { get; set; }
    }
}
