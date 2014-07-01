using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloPullRequest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET: api/Values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "Value3" };
        }

        // GET: api/Values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException("TODO");
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException("TODO");
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
