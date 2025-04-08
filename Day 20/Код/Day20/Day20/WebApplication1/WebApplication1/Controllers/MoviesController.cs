using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        private static List<Movie> _movies = new List<Movie>();
        private static int _nextId = 1;

        public IActionResult Index()
        {
            return View(_movies);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = _nextId++;
                _movies.Add(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public IActionResult Details(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
    }
} 