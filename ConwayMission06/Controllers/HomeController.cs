using ConwayMission06.Models;
using Microsoft.AspNetCore.Mvc;
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
        //add movie route
        public IActionResult AddMovie()
        {
            return View();
        }

        //post for the form in the add movie view
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {

            //add the new movie 
            _context.Movies.Add(movie);
            //save changes to the database
            _context.SaveChanges();

            //show the confirmation screen
            return View("Confirmation", movie);
        }
    }
}
