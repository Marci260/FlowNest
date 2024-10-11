using FlowNest.Data;
using FlowNest.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlowNest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        MovieDbContext ctx = new MovieDbContext();

        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return ctx.Movies;
        }

        [HttpGet("{id}")]
        public Movie Get(string id)
        {
            return ctx.Movies.First(x => x.Id == id);
        }
        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            movie.Id = System.Guid.NewGuid().ToString();//next step is to add this to the database
            ctx.Movies.Add(movie);
            ctx.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(Movie movie) {
            var m = ctx.Movies.First(x => x.Id == movie.Id);
            m.Title = movie.Title;
            m.Year = movie.Year;
            m.Genre = movie.Genre;
            m.Director = movie.Director;
            m.Rating = movie.Rating;
            ctx.SaveChanges();
        }

    }
}
