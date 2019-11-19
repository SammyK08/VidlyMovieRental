using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMovieRental.Dtos;
using VidlyMovieRental.Models;

namespace VidlyMovieRental.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

            Mapper.CreateMap<Movie, MoviesDto>();
            Mapper.CreateMap<MoviesDto, Movie>();


            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MoviesDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}