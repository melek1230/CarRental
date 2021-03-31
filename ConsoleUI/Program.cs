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
            //newmethod1();
            

            //araba_listeleme();

            RentalManager rentManager = new RentalManager(new EFRentalDal());
            var result = rentManager.Add(new Rental { CarId = 1, CustomerId = 2, RentDate = DateTime.Now });

            Console.WriteLine(result.Message);
        }

        private static void araba_listeleme()
        {
            RentalManager rentManager = new RentalManager(new EFRentalDal());
            var sonuc = rentManager.GetProductDetailDtos();

            foreach (var item in sonuc.Data)
            {
                Console.WriteLine(item.CarName + " " + item.RentDate + " " + item.UserName);
            }
        }

        private static void newmethod1()
        {
            ProductManager productManager = new ProductManager(new EFCarDal(), new BrandManager(new EFBrandDal()));



            var result = productManager.GetProductDetailDtos();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.CarName + "----" + product.BrandName + "----" + product.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //private static void ProductTest()
        //{
        //    ProductManagerInMemory manager = new ProductManagerInMemory(new InMemoryDal());
        //    //foreach (var product in manager.GetAll().Data)
        //    //{
        //    //    Console.WriteLine(product.CarName);
        //    //}
        //}

        private static void entityframework_odev()
        {
            ProductManager manager = new ProductManager(new EFCarDal(), new BrandManager(new EFBrandDal()));
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
