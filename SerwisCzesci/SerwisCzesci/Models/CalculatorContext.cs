using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
public class CalculatorContext : DbContext
{
	public CalculatorContext() : base("name=ConnectionString")
	{
	}
	public DbSet<SearchHistory> SearchHistory { get; set; }
	public DbSet<Module> Module { get; set; }
	public DbSet<City> City { get; set; }

}
