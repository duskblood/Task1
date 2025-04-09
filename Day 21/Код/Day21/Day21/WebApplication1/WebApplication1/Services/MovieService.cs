using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    public class MovieService : IMovieService
    {
        private static List<Movie> _movies = new List<Movie>();
        private static int _nextId = 1;

        public List<Movie> GetAllMovies()
        {
            return _movies;
        }

        public Movie? GetMovieById(int id)
        {
            return _movies.FirstOrDefault(m => m.Id == id);
        }

        public void AddMovie(MovieViewModel movieViewModel)
        {
            var movie = new Movie
            {
                Id = _nextId++,
                Title = movieViewModel.Title,
                Genre = movieViewModel.Genre,
                Year = movieViewModel.Year,
                Rating = movieViewModel.Rating
            };

            _movies.Add(movie);
        }
    }
} 