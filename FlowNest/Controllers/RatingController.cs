using FlowNest.Entities.DTOs.Rating;
using FlowNest.Logic.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FlowNest.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        RatingLogic logic;

        public RatingController(RatingLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddRating(RatingCreateDto dto)
        {
            logic.AddRating(dto);
        }
    }
}
