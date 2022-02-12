﻿using Business.Abtract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abtract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {

            if (product.ProductName.Length>2)
            {   //magic string
                return new ErrorResult(Messages.ProductNameInvalid);

            }
           _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {

            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult();
            }
          return new SuccessDataResult<List<Product>>(_productDal.GetAll(),true,"Ürünler Listelendi");
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=> p.CategoryId==id);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return _productDal.Get(productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        IDataResult<List<Product>> IProductService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
