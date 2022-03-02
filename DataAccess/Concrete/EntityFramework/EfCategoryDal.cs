using Core.DataAccess.EntityFramework;
using DataAccess.Abtract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEnityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
       
    }
}
