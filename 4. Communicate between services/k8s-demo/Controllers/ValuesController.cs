using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using k8s_demo.Services;

namespace k8s_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly INameService _nameService;
        public ValuesController(INameService nameService)
        {
            _nameService = nameService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return $"hello, {await _nameService.GetHost()}, from {await _nameService.GetName()}";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"你输入的是：{id}";
        }
    }
}
