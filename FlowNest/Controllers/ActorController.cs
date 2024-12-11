using FlowNest.Entities.DTOs.Actor;
using FlowNest.Entities.DTOs.Movie;
using FlowNest.Logic.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlowNest.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        ActorLogic logic;

        public ActorController(ActorLogic logic)
        {
            this.logic=logic;
        }

        [HttpPost]
        [Authorize]
        public void AddActor(CreateOrUpdateActorDto dto)
        {
            logic.AddActor(dto);
        }
    }
}
