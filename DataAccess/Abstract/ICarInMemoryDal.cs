using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarInMemoryDal
    {
        List<Car> GetAllByCar(int carId);
        void Add(Car car);
        void Delete(Car car);

        List<Car> GetAll();
        void UpDate(Car car);
    }
}
