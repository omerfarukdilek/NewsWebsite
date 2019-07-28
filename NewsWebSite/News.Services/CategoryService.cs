using News.Contract.Extentions;
using News.Contract.ViewModels;
using News.Data;
using News.Domain;
using News.Services.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Services
{
    public class CategoryService
    {

        private DatabaseContext database;

        public CategoryService()
        {
            database = ContextManagment.GetContext();
        }



        public bool IsValidCategoryName(string categoryName)
        {
            var checkCategory = database.Category.FirstOrDefault(i => (i.CategoryName.Equals(categoryName)));
            //return checkUser == null;
            return checkCategory == null ? true : false;
        }

        public void AddCategory(Category category)
        {
            if (category == null)
                throw new System.NullReferenceException(nameof(Category));
            database.Category.Add(category);
            database.SaveChanges();
        }

        public void EditCategory(Category category)
        {
            if (category == null)
                throw new System.NullReferenceException(nameof(Newscast));
            database.Entry(category).State = EntityState.Modified;
        }

        public void DeleteCategory(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var category = GetCategory(id);
            database.Category.Remove(category);
        }

        public void AddRegisterCategory(VmRegisterCategory vmRegisterCategory)
        {
            if (vmRegisterCategory == null)
                throw new System.NullReferenceException("kayıt edilecek bilgi bulunamadı");
            var tempCategory = vmRegisterCategory.GetCategory();
            database.Category.Add(tempCategory);
        }

        public List<Category> GetCategory()
        {
            var categoryList = database.Category.ToList();
            return categoryList;
        }

        public Category GetCategory(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var category = database.Category.FirstOrDefault(i => i.Id == id);
            return category;
        }

        public int SaveDb()
        {
            return ContextManagment.Save();
        }

        public void Disposing()
        {
            ContextManagment.Disposing();
        }


    }
}
