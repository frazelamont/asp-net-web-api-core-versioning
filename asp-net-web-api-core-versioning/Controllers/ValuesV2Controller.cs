using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace asp_net_web_api_core_versioning.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    public class ValuesV2Controller : ValuesController
    {
        public ValuesV2Controller()
        {
        }

        public override IEnumerable<string> Get()
        {
            return new string[] { "value1 v2.0", "value2 v2.0" };
        }
    }
}