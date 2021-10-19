using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;


namespace Client.Data
{
    public interface IFileReader
    {
        Task<IList<Adult>> GetAdults();
        
    }
}