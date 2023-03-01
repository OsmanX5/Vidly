using System.Data.Entity.Core.Common.CommandTrees;

namespace Vidly.Models
{
	public class MemberShipType
	{
		public string name { get; set; }
		public int Id { get; set; }
		public short SignUpFee { get; set; }
		public byte DurationInMonths { get; set; }
		public byte DiscountRate { get; set; }

		public static readonly int UnKnown = 0;
		public static readonly int Basic = 1;
		

	}
}
