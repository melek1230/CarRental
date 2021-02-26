using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarInMemoryDal
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                   CarId=3, CarName="kamyon",BrandId=3,ColorId=2
                   ,ModelYear="2013",DailyPrice=9,Description="2.el"
                },
                new Car
                {
                    CarId=4,CarName="ekskavator",BrandId=3,ColorId=4,
                    ModelYear="2015",DailyPrice=2,Description="bozok"
                }
            };
        }
        public List<Car> GetAllByCar(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(p => p.CarId== car.CarId);
            _cars.Remove(carDelete);

        }

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    return _cars.Where(p=>p.CarId==);
        //}

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void UpDate(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p=>p.CarId==car.CarId);
            carUpdate.CarName = car.CarName;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
        }

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
