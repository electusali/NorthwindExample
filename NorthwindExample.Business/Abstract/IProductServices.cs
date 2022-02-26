using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindExample.Enties.Concrete;

namespace NorthwindExample.Business.Abstract
{
	public interface IProductServices
	{
		List<Product> GetAll();
		void Add(Product product);
	}
}
