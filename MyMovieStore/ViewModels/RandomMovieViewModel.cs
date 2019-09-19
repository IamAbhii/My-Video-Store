using MyMovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMovieStore.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}