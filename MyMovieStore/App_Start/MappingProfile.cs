using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MyMovieStore.DTO;
using MyMovieStore.Models;

namespace MyMovieStore.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}