using Core.Utilities.Results;
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
        //void için IResult yazıyoruz
        //Data,mesaj vs  döndürmek için IDataResult yazıyoruz
        IDataResult<List<Car>> GetAll();
        IDataResult<List<ProductDetailDto>> GetCarsByBrandId(int id);
        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();
        IDataResult<List<ProductDetailDto>> GetCarsByColorId(int id);
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetCarsByBrandName(string brandName);
        
       
    }
}
