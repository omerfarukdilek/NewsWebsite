using News.Contract.ViewModels;
using News.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Contract.Extentions
{
    public static class NewscastExtentions  
    {
        public static Newscast GetNewscast(this VmRegisterNewscast vmRegisterNewscast)
        {
            var newscast = new Newscast()
            {
                NewsTitle = vmRegisterNewscast.NewsTitle,
                NewsContent = vmRegisterNewscast.NewsContent,
                NewsImage = vmRegisterNewscast.NewsImage,
                TimeOfCreation = DateTime.Now,
                TimeOfModification = DateTime.Now,
                IsActive = true
            };

            return newscast;
        }



    }
}
