using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Movie
	{
		public int Id { get; set; }
		[Required] public string Name { get; set; } = "";
		public MovieGenre? MovieGenre { get; set; }
		public int MovieGenreId { get; set; }

		public DateTime? ReleaseDate { get; set; } = DateTime.Today;
		public DateTime? addingDate { get; set; } = DateTime.Today;
		[Required]
		[Range(1, 20)]
		public int NumberInStock { get; set; }

		public int NumberAvailable { get; set; }
	}
}
