using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;

namespace k8s_demo.Services
{
    public class NameService : INameService
    {
        private readonly string _nameUrl = "http://name-api/api/name";
        public async Task<string> GetName()
        {
            return await _nameUrl.GetStringAsync();
        }
    }
}