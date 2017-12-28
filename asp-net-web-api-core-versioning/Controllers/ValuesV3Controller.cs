using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace asp_net_web_api_core_versioning.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("3.0")]
    public class ValuesV3Controller : ValuesController
    {
        public ValuesV3Controller()
        {
        }

        public override IEnumerable<string> Get()
        {
            return new string[] { "value1 v3.0", "value2 v3.0" };
        }
    }
}