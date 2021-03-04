using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId();
        List<Car> GetCarsByColorId();
        void Add(Car car);
        List<ProductDetailDto> GetProductDetailDtos();

       
    }
}
