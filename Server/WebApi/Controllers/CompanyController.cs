﻿using System.Collections.Generic;
using System.Web.Http;

namespace Server.Controllers
{
    public class CompanyController : ApiController
    {
        // GET: api/Company
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Company/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Company
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Company/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Company/5
        public void Delete(int id)
        {
        }
    }
}
