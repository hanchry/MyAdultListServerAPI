using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Restricting.Models;

namespace MyAdultList.Data
{
    public interface IFileReader
    {
        IList<Adult>GetAdults();
        
    }
}