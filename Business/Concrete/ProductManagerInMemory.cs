using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ProductManagerInMemory : IProductService
    {

        ICarInMemoryDal _carDal;
        public ProductManagerInMemory(ICarInMemoryDal carDal)
        {
            _carDal = carDal;

        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("*****    Araba başarıyla eklendi     ****");
            }
            else
            {
                Console.WriteLine("lütfen araba ismini minimum 2 karakter ve fiyatını sıfırdan büyük giriniz...");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId()
        {
            throw new NotImplementedException();
        }
    }
}
