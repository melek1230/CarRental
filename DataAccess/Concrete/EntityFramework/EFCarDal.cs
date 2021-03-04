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
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from                             
                             c in context.Cars 
                             //join
                             //o in context.Orders on
                             //c.CarId equals o.CarId 
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

        public void UpDate(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
