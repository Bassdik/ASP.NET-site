using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using WebApplication2.Dtos;
using WebApplication2.Models;

namespace WebApplication2.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/customers 
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers
                .Include(c => c.MembershipType);
            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.Name.Contains(query));
            var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }
        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }
            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }
        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                //throw new HttpResponseException(HttpStatusCode.BadRequest); // if we use IHttpActionResult better to write next line
                return BadRequest();
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            customerDto.id = customer.id;
            return Created(new Uri(Request.RequestUri + "/" + customer.id), customerDto);
        }
        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();
            }
            var customerInDB = _context.Customers.SingleOrDefault(c => c.id == id);
            if (customerInDB == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }
            //Mapper.Map<CustomerDto, Customer>(customerDto, customerInDB); // we can write easer like in the next line
            Mapper.Map(customerDto, customerInDB);
            /*customerInDB.Name = customerDto.Name;//we use Mprevious line for fill insted of this
            customerInDB.Birthdate = customerDto.Birthdate;
            customerInDB.IsSubscribedToNewsLetter = customerDto.IsSubscribedToNewsLetter;
            customerInDB.MembershipTypeId = customerDto.MembershipTypeId;*/
            _context.SaveChanges();
            return Ok();
        }
        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomers(int id)
        {
            var customerInDB = _context.Customers.SingleOrDefault(c => c.id == id);
            if (customerInDB == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }
            _context.Customers.Remove(customerInDB);
            _context.SaveChanges();
            return Ok();
        }
    }
}
