using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindExample.Business.Abstract;
using NorthwindExample.DataAccess.Abstract;
using NorthwindExample.Enties.Concrete;

namespace NorthwindExample.Business.Conrete
{
	public class ProductManager : IProductServices
	{
		private readonly IProductDal _productDal;
		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}
		public void Add(Product product)
		{
			_productDal.Add(product);
		}

		public List<Product> GetAll()
		{
			return _productDal.GetAll();
		}
	}
}
