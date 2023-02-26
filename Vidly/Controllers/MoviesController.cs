using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	
	public class MoviesController : Controller
	{
		MyDB db = new MyDB();

		public IActionResult Index()
		{
			return View(db.Movies.ToList());
		}
		[Route("Movies/details/{id}")]
		public IActionResult details(int id)
		{
			Movie movie = db.Movies.Find(id);
			return View(movie);
		}
		public IActionResult NewMovie()
		{
			return View("Form");
		}
		public IActionResult Edit(int id)
		{
			Movie movie = db.Movies.Single(x => x.Id == id);
			return View("Form",movie);
		}

		public IActionResult Save(Movie movie)
		{
			if (movie.Id == 0)db.Movies.Add(movie);
			else
			{
				Movie movieInDB = db.Movies.Single(x => x.Id == movie.Id);
				movieInDB.Name = movie.Name;
				movieInDB.NumberInStock = movie.NumberInStock;
				movieInDB.ReleaseDate = movie.ReleaseDate;
				movieInDB.addingDate = movie.addingDate;
				movieInDB.Genre = movie.Genre;
			}
			db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
