﻿using MyMovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMovieStore.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}