using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal: IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetails();
       // List<RentalDetailDto> GetAllByBrand(Expression<Func<Rental, bool>> filter);
       // List<RentalDetailDto> GetAllByColor(Expression<Func<Rental, bool>> filter);

    }
}
