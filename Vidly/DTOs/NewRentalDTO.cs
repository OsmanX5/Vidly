using Vidly.Models;

namespace Vidly.DTOs
{
	public class NewRentalDTO
	{
		public int customerID { get; set; }	
		public List<int> moviesID { get; set; }
	}
}
