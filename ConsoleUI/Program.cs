using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager
                (new EFCarDal());
            manager.Add(new Car
            { 
                CarName = "kamyonet",
                BrandId = 3,
                ColorId = 2,
                ModelYear = "2017",
                DailyPrice = 6050,
                Description = "3.el"
            }
                );
            

            
                

            
        }
    }
}
