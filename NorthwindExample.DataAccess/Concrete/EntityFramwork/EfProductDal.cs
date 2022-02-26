using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindExample.Core.DataAccess.EntitFramWorkCore;
using NorthwindExample.DataAccess.Abstract;
using NorthwindExample.Enties.Concrete;

namespace NorthwindExample.DataAccess.Concrete.EntityFramwork
{
	public class EfProductDal:EfEntityRepositoryBase<Product,DemoDbContext>,IProductDal
	{
	}
}
