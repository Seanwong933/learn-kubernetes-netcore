using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace name_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            // https://kubernetes.io/docs/concepts/services-networking/service/
            // 可以通过这种环境变量拿到当前 Service 的主机名
            // {SVCNAME}_SERVICE_HOST
            var host = Environment.GetEnvironmentVariable("NAME_SERVICE_SERVICE_HOST");
            return string.IsNullOrEmpty(host) ? "empty host" : host;
        }

        [HttpGet("{number}")]
        public ActionResult<string> Get(int number) 
        {
            return $"fuck {number}";
        }
    }
}