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
    public class ProductManager : IProductService
    {
        ICarDal _carDal;
        IBrandService _brandService;
        public ProductManager(ICarDal carDal,IBrandService brandService)
        {
            _carDal = carDal;
            _brandService = brandService;


        }
        public ProductManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IDataResult<List<Car>> GetByUnitPrice(decimal min,
            decimal max)
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(p=>p.DailyPrice>=min && p.DailyPrice<=max 
                && p.CarName.Length>=2)
                );
        }

        public IResult Add(Car car)
        {
            if(car.CarName.Length>=2 && car.DailyPrice>0 )
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.ProductAdded);
            }
            else
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            
        }

        public IDataResult<List<Car>> GetAll()
        {   
            //iş kodları
            //yetkisi var mı?
            if(DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=>p.CarId==carId),"başarılı");
        }

       
        public IDataResult<List<ProductDetailDto>> GetProductDetailDtos()
        {
            return new SuccessDataResult<List<ProductDetailDto>>
                (_carDal.GetProductDetails());
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int brand)
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(p => p.BrandId==brand));
            //(_carDal.GetAllByBrand(p=>p.BrandId==id));
        }
        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(c=>c.ColorId==id));
        }

        public IDataResult<List<Car>> GetCarsByBrandName(string brandName)
        {
            var brand= _brandService.GetByName(brandName).Data;
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(c => c.BrandId ==brand.BrandId),Messages.GetSuccess);
        }

       
    }
}
