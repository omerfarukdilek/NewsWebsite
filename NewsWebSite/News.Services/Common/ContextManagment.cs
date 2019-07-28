using News.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Services.Common
{
    public class ContextManagment
    {
        private static DatabaseContext _databasContext;
        //private DatabaseContext2 _databasContext;

        private ContextManagment() { }

        public static DatabaseContext GetContext()
        {
            if (_databasContext == null)
                _databasContext = new DatabaseContext();  //_databasContext = new DatabaseContext2(); İLE HAYATIMA DEVAM EDEBİLİRİM...
            return _databasContext;
        }

        public static int Save()
        {
            if (_databasContext == null)
                throw new ArgumentNullException("Önce Context Oluşturulmalı");
            return _databasContext.SaveChanges();
        }

        public static void Disposing()
        {
            if (_databasContext == null)
                throw new ArgumentNullException("Önce Context Oluşturulmalı");
            _databasContext.Dispose();
            _databasContext = null;
        }
    }
}
