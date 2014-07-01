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
            return new string[] { Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString() };
        }

        // GET: api/Values/5
        public string Get(int id)
        {
            Random rnd = new Random();
            int val = rnd.Next(0, 3);

            if (val == 0)
            {
                return Guid.NewGuid().ToString() + "____" + Guid.NewGuid().ToString();
            }
            else if (val == 1)
            {
                return Guid.Empty.ToString();
            }
            else 
            {
                throw new Exception("Awww unlucky roll of the dice.");
            }
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
