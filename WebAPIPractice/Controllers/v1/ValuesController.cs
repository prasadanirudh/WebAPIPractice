using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIPractice.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
                
        public IEnumerable<string> Get(int a, int b)
        {
            return new string[] { "value1New", "value2New" };
        }

        [HttpGet]
        public IEnumerable<string> GetData(int a, int b)
        {
            return new string[] { "GetData1", "GetData2" };
        }

        //http://localhost:54065/api/services/values/GetNew/1        
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "GetNew1", "GetNew2" };
        }

        //// http://localhost:54065/api/services/values/Get/1
        //[ActionName("GetById")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
