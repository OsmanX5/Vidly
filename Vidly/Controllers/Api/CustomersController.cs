using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private MyDB db;

		public CustomersController()
		{
			db = new MyDB();
		}
		public IEnumerable<Customer> GetCustomers()
		{
			return db.Customers.ToList();
		}
		[HttpGet("/{id}")]
		public Customer GetCustomer(int id)
		{
			return new Customer();
		}
		
	}
}
