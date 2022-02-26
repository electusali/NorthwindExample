using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindExample.Business.Abstract;
using NorthwindExample.Enties.Concrete;

namespace NorthwindExample.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private IProductServices productServices;

		public ProductController(IProductServices productServices)
		{
			this.productServices = productServices;
		}
		[HttpGet]
		public IActionResult GetAll()
		{
			var getAll = productServices.GetAll();
			var result = getAll.Select(x => new Product()
			{
				CategoryId = x.CategoryId,
				ProductId = x.ProductId,
				ProductName = x.ProductName,
				UnitPrice = x.UnitPrice,
				UnitsInStock = x.UnitsInStock
			}).ToList();
			return Ok(result);
		}
		[HttpPost]
		public ActionResult Post([FromBody]Product product)
		{
			 productServices.Add(product);
			 return RedirectToAction("GetAll");
		}
	}
}
