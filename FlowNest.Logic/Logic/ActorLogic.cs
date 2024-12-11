using FlowNest.Data;
using FlowNest.Entities.DTOs.Actor;
using FlowNest.Entities.Models;
using FlowNest.Logic.Helpres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Logic.Logic
{
    public  class ActorLogic
    {
        Repository<Actor> repo;
        DtoProvider dtoProvider;

        public ActorLogic(Repository<Actor> repo, DtoProvider dtoProvider)
        {
            this.repo=repo;
            this.dtoProvider=dtoProvider;
        }

        public void AddActor(CreateOrUpdateActorDto dto) 
        {
            var model = dtoProvider.Mapper.Map<Actor>(dto);
            if (repo.GetAll().FirstOrDefault(x => x.Name == model.Name) == null)
            {

                repo.Create(model);
            }
            else
            {
                throw new ArgumentException("Actor already exist!");
            }
        }

      

    }
}
