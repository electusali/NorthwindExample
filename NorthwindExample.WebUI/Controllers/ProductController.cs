using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindExample.Business.Abstract;
using NorthwindExample.Enties.Concrete;

namespace NorthwindExample.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductServices productServices;

		public ProductController(IProductServices productServices)
		{
			this.productServices = productServices;
		}

		public ViewResult Index()
		{
			return View();
		}

		public ViewResult GetAll()
		{
			var result = productServices.GetAll();
			return View(result);
		}

		[HttpGet]
		public ActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Add(Product product)
		{
			productServices.Add(product);
			return RedirectToAction("GetAll");
		}
	}
}
