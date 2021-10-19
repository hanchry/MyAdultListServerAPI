using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Loader;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public class CloudDataReader:IFileReader
    {
        private string uri = "https://localhost:5003";
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;

        public CloudDataReader()
        {

            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender,cert, chain, sslPolicyErrors ) =>
            {
                return true;
            };
            client = new HttpClient(clientHandler);
        }
        
        public async Task<IList<Adult>> GetAdults()
        {
            Task<string> stringAsync = client.GetStringAsync(uri+"/Adult");
            string message = await stringAsync;
            IList<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }
    }
}