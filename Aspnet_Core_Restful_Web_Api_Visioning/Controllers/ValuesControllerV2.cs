using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aspnet_Core_Restful_Web_Api_Visioning.Controllers
{
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/values")]
    public class ValuesControllerV2 : Controller
    {
        // GET: api/ValuesControllerV2
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1 from v2", "value2 from v2" };
        }

        // GET: api/ValuesControllerV2/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ValuesControllerV2
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ValuesControllerV2/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
