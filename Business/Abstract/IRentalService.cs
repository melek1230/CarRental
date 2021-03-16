using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalByCarId(int id);
        IDataResult<List<RentalDetailDto>> GetProductDetailDtos();
        IDataResult<List<Rental>> GetRentalByCustomerId(int id);
        IDataResult<Rental> GetById(int carId);
        //IDataResult<List<Rental>> GetRentalByCustomerName(string brandName);
    }
}
