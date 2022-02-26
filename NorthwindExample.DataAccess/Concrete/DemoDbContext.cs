using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorthwindExample.Enties.Concrete;

namespace NorthwindExample.DataAccess.Concrete
{
	public class DemoDbContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				@"Server=DESKTOP-DFORJ46;Database=Northwind;Trusted_Connection=True;Integrated security=True;");
		}

		public DbSet<Product> Products { get; set; }
	}
}
