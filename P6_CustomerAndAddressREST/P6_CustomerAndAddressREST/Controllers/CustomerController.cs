using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P6_CustomerAndAddressREST.Models;

namespace P6_CustomerAndAddressREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public List<Customer> GetAllCustomers()
        {
            using (var db = new CustAddressContext())
            {
                return db.Customers.ToList();
            }
        }

        [HttpGet("customerwithaddress")]
        public List<Customer> GetAllCustomerWithAddress()
        {
            using (var db = new CustAddressContext())
            {
                return db.Customers.Include(add => add.Customeraddresses).ToList();
            }
        }

        [HttpPost("savecustomer")]
        public Customer SaveCustomer(Customer customer) { 
            
            using (var db = new CustAddressContext())
            {
                db.Add(customer);
                db.SaveChanges();

                return customer;
            }

        }

        [HttpGet("getbyid")]
        public Customer GetCustomer(int id)
        {
            using (var db = new CustAddressContext()) {
                var customer = db.Customers.Find(id);
                return customer;
            }
        }

        [HttpPut("updatecust")]
        public Customer UpdateCustomer(Customer customer) {
            using (var db = new CustAddressContext()) { 
                
                db.Customers.Update(customer);
                db.SaveChanges();
                return customer;

            }
        }

        [HttpDelete("deletecustomer")]
        public string DeleteCust(int id)
        {
            using (var db = new CustAddressContext())
            {
                var cust = db.Customers.Find(id);
                    if (cust != null)
                {
                    db.Customers.Remove(cust);
                    db.SaveChanges();
                    return "Record deleted ...";
                }
                return "Record not found...";
            }
        }
    }
}
