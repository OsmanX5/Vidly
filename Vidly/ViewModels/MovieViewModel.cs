using Vidly.Models;

namespace Vidly.ViewModels
{
	public class MovieViewModel
	{
		public IEnumerable<MovieGenre> MovieGenres { get; set; }
		public Movie Movie { get; set; }
	}
}
