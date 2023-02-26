using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public bool IsSubscribedToNewsletter { get; set; }
		public DateTime? Birthdate { get; set; }
		public MemberShipType MemberShipType { get; set; }
		public int MemberShipTypeId { get; set; } 
    }
}
