using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<ProductDetailDto> GetProductDetails();
        List<ProductDetailDto> GetAllByBrand(Expression<Func<Car, bool>> filter);
        List<ProductDetailDto> GetAllByColor(Expression<Func<Car, bool>> filter);

    }
}
