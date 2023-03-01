using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vidly.Models;
using System.Web;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	
	public class MoviesController : Controller
	{
		MyDB db ;

		public MoviesController()
		{
			db = new MyDB();
		}
		[Route("Movies")]
		public IActionResult Index()
		{
			Console.WriteLine("index movies");
			var movies = db.Movies.Include(s => s.MovieGenre).ToList();
			Console.WriteLine(movies.Count);
			return View(movies);
		}
		[Route("Movies/details/{id}")]
		public IActionResult details(int id)
		{
			Movie movie = db.Movies.Find(id);
			return View(movie);
		}
		public IActionResult NewMovie()
		{
			MovieViewModel movieViewModel = new MovieViewModel();
			movieViewModel.MovieGenres = db.MovieGenres.ToList();
			movieViewModel.Movie = new Movie();
			return View("Form", movieViewModel);
		}
		public IActionResult Edit(int id)
		{
			Movie movie = db.Movies.Single(x => x.Id == id);
			MovieViewModel movieViewModel = new MovieViewModel
			{
				MovieGenres = db.MovieGenres.ToList(),
				Movie = movie
			};
			return View("Form", movieViewModel);
		}

		public IActionResult Save(Movie movie)
		{
			
			if (!ModelState.IsValid)
			{
				MovieViewModel movieViewModel = new MovieViewModel
				{
					MovieGenres = db.MovieGenres.ToList(),
					Movie = movie
				};
				return View("Form", movieViewModel);
			}
			if (movie.Id == 0)
			{
				MovieGenre gen = db.MovieGenres.Single(x => x.Id == movie.MovieGenreId);
				movie.MovieGenre = gen;
				db.Movies.Add(movie);
			}
				
			else
			{
				Movie movieInDB = db.Movies.Single(x => x.Id == movie.Id);
				movieInDB.Name = movie.Name;
				movieInDB.NumberInStock = movie.NumberInStock;
				//movieInDB.ReleaseDate = movie.ReleaseDate;
				//movieInDB.addingDate = movie.addingDate;
				MovieGenre gen = db.MovieGenres.Single(x => x.Id == movie.MovieGenre.Id);
				movieInDB.MovieGenre = gen;
			}
			db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
