using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFEntityRepositoryBase<Car, NorthwindContext>
        , ICarDal
    {
        

        public List<ProductDetailDto> GetAllByBrand(Expression<Func
            <Car,bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = filter == null ? 
                                       from c in context.Cars.Where(filter)
                                       join b in context.Brands on c.BrandId
                                       equals b.BrandId
                                       select new ProductDetailDto
                                       {
                                           ProductId=c.CarId,
                                           CarName = c.CarName,
                                           DailyPrice = c.DailyPrice,
                                           BrandName=b.BrandName
                                       }
                             : from c in context.Cars
                               join   b in context.Brands on c.BrandId
                               equals b.BrandId                        
                                                       
                             select new ProductDetailDto
                             {
                                 ProductId=c.CarId,
                                 CarName = c.CarName,
                                 DailyPrice = c.DailyPrice,
                                 BrandName=b.BrandName

                             };
                return result.ToList();

            }
        }

        public List<ProductDetailDto> GetAllByColor(Expression<Func<Car, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = filter == null ?
                                        from c in context.Cars.Where(filter)
                                        join co in context.Colors on c.ColorId
                                        equals co.ColorId
                                        select new ProductDetailDto
                                        {
                                            ProductId = c.CarId,
                                            CarName = c.CarName,
                                            DailyPrice = c.DailyPrice,
                                            ColorName = co.ColorName,
                                        }
                              : from c in context.Cars
                                join co in context.Colors on c.ColorId
                                equals co.ColorId

                                select new ProductDetailDto
                                {
                                    ProductId = c.CarId,
                                    CarName = c.CarName,
                                    DailyPrice = c.DailyPrice,
                                    ColorName = co.ColorName,

                                };
                return result.ToList();

            }
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from                             
                             c in context.Cars                             
                             join
                             b in context.Brands on
                             c.BrandId equals b.BrandId
                             join
                             co in context.Colors on
                             c.ColorId equals co.ColorId
                             select new ProductDetailDto
                             {
                                 ProductId = c.CarId,
                                 CarName = c.CarName,
                                 DailyPrice = c.DailyPrice,
                                 BrandName= b.BrandName,
                                 ColorName=co.ColorName
                             };
                return result.ToList();

            }
        }

        public List<Rental> GetRentCar(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
