using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace name_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodNameController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var name = Environment.GetEnvironmentVariable("POD_NAME_CURRENT");
            return string.IsNullOrEmpty(name) ? "fetch pod name failed" : name;
        }
    }
}