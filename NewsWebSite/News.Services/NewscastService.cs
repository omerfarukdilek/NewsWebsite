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
    public class NewscastService
    {
        private DatabaseContext database;

        public NewscastService()
        {
            database = ContextManagment.GetContext();
        }

        

        public bool IsValidNewsTitle(string newsTitle)
        {
            var checkUser = database.Newscast.FirstOrDefault(i => (i.NewsTitle.Equals(newsTitle)) || (i.NewsTitle.Equals(newsTitle)));
            //return checkUser == null;
            return checkUser == null ? true : false;
        }

        public void AddNews(Newscast newscast)
        {
            if (newscast == null)
                throw new System.NullReferenceException(nameof(Newscast));
            database.Newscast.Add(newscast);
        }

        public void EditNews(Newscast newscast)
        {
            if (newscast == null)
                throw new System.NullReferenceException(nameof(Newscast));
            database.Entry(newscast).State = EntityState.Modified;
        }

        public void DeleteNews(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var employee = GetNewscast(id);
            database.Newscast.Remove(employee);
        }

        public void AddRegisterNewscast(VmRegisterNewscast vmRegisterNewscast)
        {
            if (vmRegisterNewscast == null)
                throw new System.NullReferenceException("kayıt edilecek bilgi bulunamadı");
            var tempNewscast = vmRegisterNewscast.GetNewscast();
            database.Newscast.Add(tempNewscast);
        }

        public List<Newscast> GetNewscast()
        {
            var newscastList = database.Newscast.ToList();
            return newscastList;
        }

        public List<Newscast> GetNewscastCategoryById(int id)
        {
            var newscastList = database.Newscast.Where(x=>x.CategoryId==id).ToList();
            return newscastList;
        }

        public Newscast GetNewscastById(int id)
        {
            var newscastList = database.Newscast.Where(x => x.Id == id).FirstOrDefault();
            return newscastList;
        }

        public Newscast GetNewscast(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var newscast = database.Newscast.FirstOrDefault(i => i.Id == id);
            return newscast;
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
