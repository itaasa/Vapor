using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vapor.Models;

namespace Vapor.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = GetCustomers();
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                    return View(customer);
            }

            return HttpNotFound();
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {

                new Customer
                {
                    Id=1, Name = "John Smith"
                },
                new Customer
                {
                    Id=2, Name = "Mary Williams"
                }
            };
        }
    }
}