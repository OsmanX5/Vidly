using Vidly.Models;

namespace Vidly.ViewModels
{
	public class CustomerFormViewModel
	{
		public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
		public Customer Customer { get; set; }
	}
}
