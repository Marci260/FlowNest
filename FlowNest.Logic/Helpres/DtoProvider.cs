using AutoMapper;
using FlowNest.Data;
using FlowNest.Entities.DTOs.Movie;
using FlowNest.Entities.DTOs.Rating;
using FlowNest.Entities.DTOs.User;
using FlowNest.Entities.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Logic.Helpres
{
    public  class DtoProvider
    {
        UserManager<AppUser> userManager;

        public Mapper Mapper { get; }

        public DtoProvider()
        {
            this.userManager = userManager;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Movie, MovieShortViewDto>()
                .AfterMap((src, dest) =>
                {
                    dest.AverageRating = src.Ratings?.Count > 0 ? src.Ratings.Average(r => r.Rate) : 0;
                });

                cfg.CreateMap<AppUser, UserViewDto>()
                .AfterMap((src, dest) =>
                {
                    dest.IsAdmin = userManager.IsInRoleAsync(src, "Admin").Result;
                });


                cfg.CreateMap<Movie, MovieViewDto>();
                cfg.CreateMap<MovieCreateOrUpdateDto, Movie>();
                cfg.CreateMap<RatingCreateDto, Rating>();
                cfg.CreateMap<Rating, RatingViewDto>();
                cfg.CreateMap<Rating, RatingViewDto>()
               .AfterMap((src, dest) =>
               {
                   var user = userManager.Users.First(u => u.Id == src.UserId);
                   dest.UserFullName = user.LastName! + " " + user.FirstName;
               });
            });

            Mapper = new Mapper(config);

            
        }
    }
    
}

