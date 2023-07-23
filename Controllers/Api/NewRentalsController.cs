using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication2.Dtos;
using WebApplication2.Models;

namespace WebApplication2.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //if (newRental.MovieIds.Count == 0)
                //return BadRequest("No movie ids have been given.");

            var customer = _context.Customers.Single(
                c => c.id == newRental.CustomerId);

            //if (customer == null)
                //return BadRequest("Customer id is not valid.");

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.id)).ToList();

            //if (movies.Count != newRental.MovieIds.Count)
                //return BadRequest("One or more movie id are invalid.");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0) 
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}