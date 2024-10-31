
using FlowNest.Data;
using FlowNest.Entities.DTOs.Movie;
using FlowNest.Entities.Models;
using FlowNest.Logic.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace FlowNest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        MovieLogic logic;

        public MovieController(MovieLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddMovie(MovieCreateOrUpdateDto dto)
        {
            logic.AddMovie(dto);
        }

        [HttpGet]
        public IEnumerable<MovieShortViewDto> GetAllMovies()
        {
            return logic.GetAllMovies();
        }

        [HttpGet("{id}")]
        public MovieViewDto GetMovie(string id)
        {
           return logic.GetMovie(id);
        }

       
        [HttpPut("{id}")]
        public void UpdateMovie( string id,[FromBody] MovieCreateOrUpdateDto dto)
        {
            logic.UpdateMovie(id,dto);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            logic.DeleteMovie(id);
        }
    }
}
