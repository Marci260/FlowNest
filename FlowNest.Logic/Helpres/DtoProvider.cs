using AutoMapper;
using FlowNest.Entities.DTOs.Movie;
using FlowNest.Entities.DTOs.Rating;
using FlowNest.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Logic.Helpres
{
    public  class DtoProvider
    {
        public Mapper Mapper { get; }

        public DtoProvider()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Movie, MovieShortViewDto>()
                .AfterMap((src, dest) =>
                {
                    dest.AverageRating = src.Ratings?.Count > 0 ? src.Ratings.Average(r => r.Rate) : 0;
                });


                cfg.CreateMap<Movie, MovieViewDto>();
                cfg.CreateMap<MovieCreateOrUpdateDto, Movie>();
                cfg.CreateMap<RatingCreateDto, Rating>();
                cfg.CreateMap<Rating, RatingViewDto>();
            });

            Mapper = new Mapper(config);
        }
    }
}

