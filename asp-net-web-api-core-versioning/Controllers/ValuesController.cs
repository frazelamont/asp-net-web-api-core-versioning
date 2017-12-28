using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace asp_net_web_api_core_versioning.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.1")]
    public class ValuesController : Controller
    {
        // GET api/values

        [HttpGet]
        public virtual IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<string> GetV0()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public IEnumerable<string> GetV1()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}