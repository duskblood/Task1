using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie? GetMovieById(int id);
        void AddMovie(MovieViewModel movieViewModel);
    }
} 