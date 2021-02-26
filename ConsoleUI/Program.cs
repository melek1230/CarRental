using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager
                (new InMemoryDal());
            foreach (var product in manager.GetAll())
            {
                Console.WriteLine(product.CarName);

            }
        }
    }
}
