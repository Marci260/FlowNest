
using FlowNest.Data;
using FlowNest.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlowNest.Controllers
{
    public class MovieCreateDto
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public string Director { get; set; }   

        //string title, int releasedDate, Genre genre, string director
    }


    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
         Repository<Movie> repo;

        public MovieController(Repository<Movie> repo)
        {
            this.repo = repo;
        }

        [HttpPost]
        public void AddMovie(MovieCreateDto dto)
        {
            var m = new Movie(dto.Title, dto.Genre, dto.Director);
            repo.Create(m);
        }
    }
}
