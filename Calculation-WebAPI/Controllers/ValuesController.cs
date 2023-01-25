using Calculation_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Calculation_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ValuesController : ApiController
    {

        // POST api/values
        [HttpPost]
        [Route("api/values/Calculate")]
        public IHttpActionResult Post([FromBody]Calculation calc)
        {
            int result = 0;
            if (calc.typeid == 1)
            {
                result = calc.num1 + calc.num2;
            }
            else { result = calc.num1 * calc.num2; }
            return Ok(result);
        }

    }
}
