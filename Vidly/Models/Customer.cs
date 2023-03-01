using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
		[Required (ErrorMessage = "ما عندك اسم؟.")]
		[StringLength(255)]
		public string Name { get; set; }
		public bool IsSubscribedToNewsletter { get; set; }
		[Display(Name = "birth data")]

		[AgeMembershipValidation]
		public DateTime? Birthdate { get; set; }

		public MemberShipType? MemberShipType { get; set; }
		[Display(Name = "Membership Type")]
		public int MemberShipTypeId { get; set; } 
    }
}
