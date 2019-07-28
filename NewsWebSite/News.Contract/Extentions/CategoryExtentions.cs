using News.Contract.ViewModels;
using News.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Contract.Extentions
{
    public static class CategoryExtentions
    {
        public static Category GetCategory(this VmRegisterCategory vmRegisterCategory)
        {
            var category = new Category()
            {
                CategoryName = vmRegisterCategory.CategoryName,
                CategoryDescription = vmRegisterCategory.CategoryDescription,
                TimeOfCreation = DateTime.Now,
                TimeOfModification = DateTime.Now,
                IsActive = true
            };

            return category;
        }
        
    }
}
