using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //entityframework_odev();
            //ProductTest();
            ProductManager productManager = new ProductManager(new EFCarDal());
            foreach (var product in productManager.GetProductDetailDtos())
            {
                Console.WriteLine(product.CarName+"----"+product.BrandName+"----"+product.ColorName+"----"+product.DailyPrice);
            }

        }

        private static void ProductTest()
        {
            ProductManagerInMemory manager = new ProductManagerInMemory(new InMemoryDal());
            foreach (var product in manager.GetAll())
            {
                Console.WriteLine(product.CarName);
            }
        }

        private static void entityframework_odev()
        {
            ProductManager manager = new ProductManager(new EFCarDal());
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
