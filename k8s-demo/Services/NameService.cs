using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;

namespace k8s_demo.Services
{
    public class NameService : INameService
    {
        // 这个域名来源于 name-api 的 service 的 service name，通过这个地址就能让多个 service 进行内部访问
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