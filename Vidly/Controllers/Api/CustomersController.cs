using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
	[Route("api")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private MyDB db;

		public CustomersController()
		{
			db = new MyDB();
		}
		[HttpGet("Customers")]
		public IEnumerable<CustomerDTO> GetCustomers()
		{
			return db.Customers.ToList().Select(Mapper.Map<Customer, CustomerDTO>).ToList();
		}
		[HttpGet("Customers/{id}")]
		public Customer GetCustomer(int id)
		{
			var Customer = db.Customers.SingleOrDefault(x => x.Id == id);
			Customer.MemberShipType = db.MemberShipTypes.SingleOrDefault(x=>x.Id == Customer.MemberShipTypeId);
			if (Customer == null) new Customer();
			return Customer;
		}

		[HttpPost("Customers")]
		public void PostCustomer(Customer customer)
		{
			if (!ModelState.IsValid) Console.WriteLine("Invalid");
			db.Customers.Add(customer);
			db.SaveChanges();
		}

		[HttpPut("Customers/{id}")]
		public void PutCustomer(Customer customer, int id)
		{
			Console.WriteLine("updating");
			Customer CustomerInDb = db.Customers.Single(c => c.Id == id);
			CustomerInDb.Name = customer.Name;
			CustomerInDb.Birthdate = customer.Birthdate;
			CustomerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
			CustomerInDb.MemberShipTypeId = customer.MemberShipTypeId;
			db.SaveChanges();
		}
		[HttpDelete("Customers/{id}")]
		public void DeleteCustomer(int id)
		{
			Customer CustomerInDb = db.Customers.Single(c => c.Id == id);
			db.Customers.Remove(CustomerInDb);
			db.SaveChanges();
		}

	}
}
