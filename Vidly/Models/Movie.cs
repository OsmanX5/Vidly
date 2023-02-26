namespace Vidly.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public MovieGenre MovieGenre { get; set; }
		public int MovieGenreId { get; set; }

		public DateTime? ReleaseDate { get; set; }
		public DateTime? addingDate { get; set; }
		public int NumberInStock { get; set; }
	}
}
