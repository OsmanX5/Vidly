using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Rental
	{
		public int Id { get; set; }
		public DateTime RentDate { get; set; }
		public DateTime? ReturnDay { get; set; }
		[Required]
		public Customer Customer { get; set; }
		[Required]
		public Movie Movie{ get; set; }
	}
}
