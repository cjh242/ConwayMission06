using ConwayMission06.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Diagnostics;

namespace ConwayMission06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _context;

        //constructor
        public HomeController(ILogger<HomeController> logger, MovieContext movieContext)
        {
            _logger = logger;
            _context = movieContext;
        }

        //homepage route
        public IActionResult Index()
        {
            return View();
        }

        //get to know route
        public IActionResult GetToKnow()
        {
            return View();
        }
        public IActionResult Confirmation(Movie movie) 
        { 
            return View(movie); 
        }
        //route to confirm edit
        public IActionResult ConfirmEdit(Movie movie)
        {
            return View(movie);
        }
        //add movie route
        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("AddMovie", new Movie());
        }

        //post for the form in the add movie view
        [HttpPost] 
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //add the new movie 
                _context.Movies.Add(movie);
                //save changes to the database
                _context.SaveChanges();

                //show the confirmation screen
                return View("Confirmation", movie);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();
                return View(movie);
            }
        }

        public IActionResult ShowMovies()
        {
            //get all movies and put in list
            var movies = _context.Movies.Include(x => x.Category)
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            //get record to edit by id
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == Id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            //edit the movie and save changes
            _context.Movies.Update(movie);
            _context.SaveChanges();

            return RedirectToAction("ConfirmEdit", movie);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            //get the record to delete by id
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == Id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("ConfirmDelete", recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            //delete the movie and save changes
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("ShowMovies");
        }
    }
}
