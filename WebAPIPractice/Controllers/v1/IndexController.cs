using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIPractice;

namespace WebAPIPractice.Controllers.v1
{
    /// <summary>
    /// API versioning 
    /// </summary>
    //[RoutePrefix("api/{apiVersion:apiVersionConstraint(v1)}/customer")]
    [RoutePrefix("api/v1/customer")]
    public class IndexController : ApiController
    {
        [Route("customers")]
        [HttpGet]
        public string GetCustomers()
        {
            return "v1 GetCustomers";
        }

        [Route("customer/{customerId:int}")]
        [HttpGet]
        public string GetCustomerById(int customerId)
        {
            return "v1 GetCustomerById";
        }

        [Route("customer/{name}")]
        [HttpGet]
        public string GetCustomerByName(string name)
        {
            return "v1 GetCustomerByName";
        }

        [Route("customer/{customerId:int}/orders")]
        [HttpGet]
        public string GetCustomerOrders(int customerId)
        {
            return "v1 GetCustomerOrders";
        }

        [HttpPost]
        [Route("customer")]
        public string SaveCustomer(Customer customer)
        {
            return "v1 SaveCustomer";
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
