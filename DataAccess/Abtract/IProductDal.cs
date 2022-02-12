﻿using Core.DataAccsess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abtract
{
   public interface IProductDal:IEntityRepository<Product>
    {

        List<ProductDetailDto> GetProductDetails();
        IDataResult<Product> Get(int productId);
    }
}
