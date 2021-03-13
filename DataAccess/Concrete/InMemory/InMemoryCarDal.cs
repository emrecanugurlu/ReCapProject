﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id = 1 , BrandId=1,ColorId=1,DailyPrice=123,ModelYear=199 ,Description="Deneme1"},
                new Car{ Id = 1 , BrandId=1,ColorId=1,DailyPrice=123,ModelYear=199 ,Description="Deneme2"},
                new Car{ Id = 1 , BrandId=1,ColorId=1,DailyPrice=123,ModelYear=199 ,Description="Deneme3"},
                new Car{ Id = 1 , BrandId=1,ColorId=1,DailyPrice=123,ModelYear=199 ,Description="Deneme4"},
                new Car{ Id = 1 , BrandId=1,ColorId=1,DailyPrice=123,ModelYear=199 ,Description="Deneme5"},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.First(c => c.Id == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
