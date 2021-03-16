using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ProductManagerInMemory : IProductService
    {

        ICarInMemoryDal _carDal;
        public ProductManagerInMemory(ICarInMemoryDal carDal)
        {
            _carDal = carDal;

        }

        //public IResult Add(Car car)
        //{
        //    if (car.CarName.Length >= 2 && car.DailyPrice > 0)
        //    {
        //        _carDal.Add(car);
        //        return new SuccessResult(Messages.ProductAdded);
        //    }
        //    else
        //    {
        //        return new ErrorResult(Messages.ProductNameInvalid);
        //    }
        //}

      
       

        public IDataResult<List<ProductDetailDto>> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByBrandName(string brandName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDto>> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetailDtos()
        {
            throw new NotImplementedException();
        }

       

        IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> IProductService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        IDataResult<Car> IProductService.GetById(int carId)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> IProductService.GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> IProductService.GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<ProductDetailDto>> IProductService.GetProductDetailDtos()
        {
            throw new NotImplementedException();
        }
    }
}
