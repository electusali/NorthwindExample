using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindExample.Core.DataAccess;
using NorthwindExample.Enties.Concrete;

namespace NorthwindExample.DataAccess.Abstract
{
	public interface IProductDal:IEntityRepository<Product>
	{
	}
}
