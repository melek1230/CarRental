using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {//iş kodları 
         
            var aracKiralanmisMi = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);

            

            if (aracKiralanmisMi == null )

            {
                _rentalDal.Add(rental);
                return new SuccessResult("Kiralandı");
            }
            else
            {
                return new ErrorResult("Kiralanamadı.");
            }



        }


        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Rental> GetById(int rentId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.CarId == rentId), "başarılı");
        }

        public IDataResult<List<RentalDetailDto>> GetProductDetailDtos()
        {
            return new SuccessDataResult<List<RentalDetailDto>>
                (_rentalDal.GetRentalDetails());
        }

        public IDataResult<List<Rental>> GetRentalByCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>
                (_rentalDal.GetAll(c => c.CarId == id));
        }

        public IDataResult<List<Rental>> GetRentalByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>
               (_rentalDal.GetAll(c => c.CustomerId == id));
        }
    }
}
