using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDepInj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IBotFrameworkClient _client;

        public ValuesController(IBotFrameworkClient client)
        {
            _client = client;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<string>> GetAsync()
        {
            return await _client.PostAsync("hello");
        }
    }
}
