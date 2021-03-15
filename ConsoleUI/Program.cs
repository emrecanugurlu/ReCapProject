using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Car car = new Car
            {
                Id = 7,
                BrandId = 3,
                ColorId = 1,
                DailyPrice = 0,
                Description = "Otomatik",
                ModelYear = 2000
            };

            Brand brand = new Brand 
            {
                Id = 9,
                Name = "Deneme 2"
            };

            /*foreach (var car in carManager.Add(car))
            {
                Console.WriteLine(car.Id);
            }*/

            //carManager.Add(car);

            brandManager.Add(brand);

        }
    }
}
