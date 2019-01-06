using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;

namespace k8s_demo.Services
{
    public class NameService : INameService
    {
        // 这个域名来源于 name-api 的 service 的 service name，通过这个地址就能让多个 service 进行内部访问
        private readonly string _host = "http://name-service/api/";
        private readonly string _hostApi, _podNameApi;

        public NameService() {
            _hostApi = _host + "host";
            _podNameApi = _host + "podname";
        }
        public async Task<string> GetHost()
        {
            return await ApiRequestStringAsync(_hostApi);
        }

        public async Task<string> GetName()
        {
            return await ApiRequestStringAsync(_podNameApi);
        }

        private async Task<string> ApiRequestStringAsync(string url)
        {
            try
            {
                return await url.GetStringAsync();
            }
            catch (FlurlHttpException) 
            {
                return "Request Failed";
            }
        }
    }
}