
using FlowNest.Data;
using FlowNest.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace FlowNest.Controllers
{
    public class MovieCreateDto
    {
        public string Title { get; set; }

        public IList<Genre> Genres { get; set; }

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
            var m = new Movie(dto.Title, dto.Genres, dto.Director);
            repo.Create(m);
        }

        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return repo.GetAll();
        }

        [HttpGet("{id}")]
        public Movie Get(string id)
        {
            return repo.FindById(id);
        }

       
        [HttpPut]
        public void UpdateMovie(Movie m)
        {
            repo.Update(m);
        }

        [HttpDelete("{id}")]
        public void Delete(Movie movie)
        {
            repo.Delete(movie);
        }
    }
}
