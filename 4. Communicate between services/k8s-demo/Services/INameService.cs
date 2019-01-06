using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace k8s_demo.Services
{
    public interface INameService
    {
        Task<string> GetHost();
        Task<string> GetName();
    }
}