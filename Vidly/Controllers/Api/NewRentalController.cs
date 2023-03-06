using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
	[Route("api")]
	[ApiController]
	public class NewRentalController : ControllerBase
	{
		MyDB db;

		public NewRentalController()
		{
			db = new MyDB();
		}
		[HttpPost("NewRental")]
		public void PostNewRental(NewRentalDTO newRentalDTO )
		{
			foreach (var movieID in newRentalDTO.moviesID)
			{
				Rental tempRental = new Rental();
				tempRental.Customer = db.Customers.Single(c => c.Id == newRentalDTO.customerID);
				Movie tempMovie = db.Movies.Single(m => m.Id == movieID);
				tempMovie.NumberAvailable--;
				tempRental.Movie = tempMovie;
				tempRental.RentDate = DateTime.Today;
				db.Rentals.Add(tempRental);
			}
			db.SaveChanges();

		}

	}
}
