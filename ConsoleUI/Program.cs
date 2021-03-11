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
            ProductManager productManager = new ProductManager
                (new EFCarDal());

            var result = productManager.GetProductDetailDtos();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.CarName + "----" + product.BrandName + "----" + product.ColorName + "----" + product.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
