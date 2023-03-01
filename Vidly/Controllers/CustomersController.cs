using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vidly.Models;
using System.Web;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        private MyDB db;

        protected override void Dispose(bool disposing)
		{
			db.Dispose();
		}

		public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
            db = new MyDB();
		}
        [Route("Customers")]
        public IActionResult Index()
        {
            Console.WriteLine("calling customer");
			List<Customer> Customers = db.Customers.Include(x => x.MemberShipType).ToList();
			return View(Customers);
        }
        [Route("Customers/Details/id")]
        public IActionResult Details(int id)
        {
			Customer customer = db.Customers.Find(id);
			return View(customer);
        }

        [Route("Customers/New")]
        public IActionResult NewCustomer()
        {
	        var memberShips = db.MemberShipTypes.ToList();
			var viewModel = new CustomerFormViewModel
			{
                Customer = new Customer(),
				MemberShipTypes = memberShips
			};
			return View("Form", viewModel);
		}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Save( Customer customer)
        {
	        if (!ModelState.IsValid)
	        {
				Console.WriteLine("ModelState is not valid");
				CustomerFormViewModel temp = new CustomerFormViewModel
				{
					Customer = customer,
					MemberShipTypes = db.MemberShipTypes.ToList()
				};
				return View("Form", temp);
	        }
                
            if(customer.Id ==0 )
				db.Customers.Add(customer);
            else
            {
	            Customer customerInDB = db.Customers.Single(c=> c.Id == customer.Id);
                customerInDB.Name = customer.Name;
                customerInDB.Birthdate = customer.Birthdate;
                customerInDB.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                customerInDB.MemberShipTypeId = customer.MemberShipTypeId;

            }
	        db.SaveChanges();
	        return RedirectToAction("Index","Customers");
        }

        public IActionResult Edit(int id)
        {
	        Customer customer = db.Customers.SingleOrDefault(c => c.Id == id);
	        if (customer == null) return NotFound();
	        CustomerFormViewModel formViewModel = new CustomerFormViewModel
	        {
		        Customer = customer,
		        MemberShipTypes = db.MemberShipTypes.ToList()
	        };
            return View("Form", formViewModel);
        }
    }
}