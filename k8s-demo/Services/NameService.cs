using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;

namespace k8s_demo.Services
{
    public class NameService : INameService
    {
        private readonly string _nameUrl = "http://name-service/api/name";
        public async Task<string> GetName()
        {
            try
            {
                return await _nameUrl.GetStringAsync();
            }
            catch (FlurlHttpException) 
            {
                return "Invalid Url";
            }
        }
    }
}