using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class AgeMembershipValidation : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			Customer customer = validationContext.ObjectInstance as Customer;
			if(customer.MemberShipTypeId==MemberShipType.UnKnown || customer.MemberShipTypeId==MemberShipType.Basic)
				return ValidationResult.Success;
			if (customer.Birthdate == null)
				return new ValidationResult("Birthdate is required");
			if (DateTime.Now.Year - customer.Birthdate.Value.Year < 18)
				return new ValidationResult("under age");
			return ValidationResult.Success;

		}
	}
}
