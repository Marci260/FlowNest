using FlowNest.Data;
using FlowNest.Entities.DTOs.Movie;
using FlowNest.Entities.Models;
using FlowNest.Logic.Helpres;

namespace FlowNest.Logic.Logic
{
    public class MovieLogic
    {
        Repository<Movie> repo;
        DtoProvider dtoProvider;

        public MovieLogic(Repository<Movie> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void AddMovie(MovieCreateOrUpdateDto dto)
        {
            Movie m = dtoProvider.Mapper.Map<Movie>(dto);

          
            if (repo.GetAll().FirstOrDefault(x => x.Title == m.Title) == null)
            {
                repo.Create(m);
            }
            else
            {
                throw new ArgumentException("Movie already exist with the same title!");
            }
        }

        public IEnumerable<MovieShortViewDto> GetAllMovies()
        {
            return repo.GetAll().Select(x =>
                dtoProvider.Mapper.Map<MovieShortViewDto>(x)
            );
        }

        public void DeleteMovie(string id)
        {
            repo.DeleteById(id);
        }

        public void UpdateMovie(string id, MovieCreateOrUpdateDto dto)
        {
            var old = repo.FindById(id);
            dtoProvider.Mapper.Map(dto, old);
            repo.Update(old);
        }

        public MovieViewDto GetMovie(string id)
        {
            var model = repo.FindById(id);
            return dtoProvider.Mapper.Map<MovieViewDto>(model);
        }
    }

}

