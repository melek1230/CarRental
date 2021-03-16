using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRentalDal : EFEntityRepositoryBase<Rental, NorthwindContext>
        , IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result =
        from r in context.Rentals
        join c in context.Cars 
        on r.CarId equals c.CarId
        
        join cs in context.Customers 
        on r.CustomerId equals cs.CustomerId

        join u in context.Users 
        on cs.UserId equals u.UserId
        select new RentalDetailDto
        {
            RentalId = r.RentalId,
            CarName = c.CarName,
            UserName = u.FirstName,
            RentDate = r.RentDate,
            ReturnDate = r.ReturnDate



        };
                return result.ToList();

            }
        }
    }
}
