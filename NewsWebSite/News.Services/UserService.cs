using News.Data;
using News.Domain;
using News.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Services
{
    public class UserService
    {
        private DatabaseContext database;


        public UserService()
        {
            database = ContextManagment.GetContext();
        }





        public bool IsValidUserName(string userName)              // Geçerli Kullanıcı Adı mı ?
        {
            var checkUser = database.User.FirstOrDefault(i => i.Email.Equals(userName));

            return checkUser == null ? true : false;
        }


        public void AddUser(User user)
        {
            if (user == null)
                throw new System.NullReferenceException(nameof(User));

            database.User.Add(user);
            database.SaveChanges();
        }


        public void EditUser(User user)
        {
            if (user == null)
                throw new System.NullReferenceException(nameof(User));

            database.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }


        public void DeleteUser(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var user = GetUser(id);
            database.User.Remove(user);
        }



        public List<User> GetUser()
        {
            var userList = database.User.ToList();
            return userList;
        }

        public User GetUser(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var user = database.User.FirstOrDefault(i => i.Id == id);
            return user;
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
