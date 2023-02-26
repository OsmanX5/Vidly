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
	}
}
