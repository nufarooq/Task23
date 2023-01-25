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
        // GET api/values
        [HttpGet]
        [ActionName("Add")]
        public IHttpActionResult Get(int num1, int num2, int typeid)
        {
            int result = 0;
            if(typeid == 1)
            {
                result = num1+ num2;
            }
            else { result = num1 * num2; }
            return Ok(result);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

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

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
