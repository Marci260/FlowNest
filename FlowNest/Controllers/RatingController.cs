using FlowNest.Data;
using FlowNest.Entities.DTOs.Rating;
using FlowNest.Logic.Logic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FlowNest.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        RatingLogic logic;
        UserManager<AppUser> userManager;

        public RatingController(RatingLogic logic, UserManager<AppUser> userManager)
        {
            this.logic = logic;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task AddRating(RatingCreateDto dto)
        {
            var user = await userManager.GetUserAsync(User);

            logic.AddRating(dto, user.Id);
        }
    }
}
