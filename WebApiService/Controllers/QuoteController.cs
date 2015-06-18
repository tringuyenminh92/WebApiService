using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiService.Models;

namespace WebApiService.Controllers
{
    public class QuoteController : ApiController
    {
        // GET: api/Quote
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet]
        // GET: api/Quote/5
        public string Get()
        {
            return "value";
        }

        [HttpGet]
        public string GetB()
        {
            return "vv";
        }
        [HttpPost]
        public string GetB(Person person)
        {
            return "vv";
        }


        // POST: api/Quote
        public IHttpActionResult PushData(Animal ani)
        {
            return Ok(ani);
        }

        // PUT: api/Quote/5
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE: api/Quote/5
        public void Delete(int id)
        {
        }

        public IHttpActionResult Push(Person person)
        {
            return Ok(person);
        }
    }
}
