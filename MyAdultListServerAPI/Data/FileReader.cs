using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Restricting.Models;

namespace MyAdultList.Data
{
    public class FileReader:IFileReader
    {
        private FileContext FileContext;
        private IList<User> users;
        
        public FileReader()
        {
            FileContext = new FileContext();
            users = FileContext.Users;
        }
        
        public IList<Adult> GetAdults()
        {
            return FileContext.Adults;
        }
        
    }
}