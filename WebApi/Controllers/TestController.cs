using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    //Refer this
    //https://www.c-sharpcorner.com/article/asp-net-mvc-oauth-2-0-rest-web-api-authorization-using-database-first-approach/

    [Authorize]
    public class TestController : ApiController
    {
        // GET api/WebApi  
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello REST API", "I am Authorized" };
        }

        // GET api/WebApi/5  
        public string Get(int id)
        {
            return "Hello Authorized API with ID = " + id;
        }

        // POST api/WebApi  
        public void Post([FromBody] string value)
        {
        }

        // PUT api/WebApi/5  
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/WebApi/5  
        public void Delete(int id)
        {
        }
    }
}
