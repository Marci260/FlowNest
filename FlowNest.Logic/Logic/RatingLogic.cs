using FlowNest.Data;
using FlowNest.Entities.DTOs.Rating;
using FlowNest.Entities.Models;
using FlowNest.Logic.Helpres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Logic.Logic
{
    public class RatingLogic
    {
        Repository<Rating> repo;
        DtoProvider dtoProvider;

        public RatingLogic(Repository<Rating> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void AddRating(RatingCreateDto dto)
        {
            var model = dtoProvider.Mapper.Map<Rating>(dto);
            repo.Create(model);
        }
    }
}

