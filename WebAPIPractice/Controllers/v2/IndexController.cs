using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIPractice;

namespace WebAPIPractice.Controllers.v2
{
    //[RoutePrefix("api/{apiVersion:apiVersionConstraint(v2)}/customer")]
    [RoutePrefix("api/v2/customer")]
    public class IndexController : ApiController
    {
        [Route("customers")]
        [HttpGet]
        public string GetCustomers()
        {
            return "v2 GetCustomers";
        }

        [Route("customer/{customerId:int}")]
        [HttpGet]
        public string GetCustomerById(int customerId)
        {
            return "v2 GetCustomerById";
        }

        [Route("customer/{name}")]
        [HttpGet]
        public string GetCustomerByName(string name)
        {
            return "v2 GetCustomerByName";
        }

        [Route("customer/{customerId:int}/orders")]
        [HttpGet]
        public string GetCustomerOrders(int customerId)
        {
            return "v2 GetCustomerOrders";
        }

        [HttpPost]
        [Route("customer")]
        public string SaveCustomer(Customer customer)
        {
            return "v2 SaveCustomer";
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
