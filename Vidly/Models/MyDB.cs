﻿using System.Data.Entity;

namespace Vidly.Models
{
	public class MyDB : DbContext
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<MemberShipType> MemberShipTypes { get; set; }
	}

}
