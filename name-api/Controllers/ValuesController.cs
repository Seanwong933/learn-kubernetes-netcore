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
            var host = Environment.GetEnvironmentVariable("NAME_API_SERVICE_HOST");
            return string.IsNullOrEmpty(host) ? "empty host" : host;
        }
    }
}
