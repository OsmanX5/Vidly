using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Vidly.Models;

namespace Vidly.DTOs
{
	public class CustomerDTO
	{
		public int Id { get; set; }
		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		public bool IsSubscribedToNewsletter { get; set; }
		[AgeMembershipValidation]
		public DateTime? Birthdate { get; set; }
		public int MemberShipTypeId { get; set; }
	}
}
