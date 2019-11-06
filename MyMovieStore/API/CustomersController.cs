﻿using AutoMapper;
using MyMovieStore.DTO;
using MyMovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyMovieStore.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //Get  /api/customers
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);
        }

        //Get  /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id==id);
            if (customer == null)
                return NotFound();
            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }

        //Post /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            //here we are passing only source object "customerDto" we are not passing the targeted object
            //so it will return the new object as customer
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri+"/"+customer.Id),customerDto);
        }

        //post /api/customers/1
        public void UpdateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            //here mapper will return targeted object as customerInDb bcoz we alreay had object here so wee need to pass it
            Mapper.Map(customerDto, customerInDb);
            

            _context.SaveChanges();
        }

        // Delete /api/customer/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

        }
    }
}
