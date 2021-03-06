using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id =1,BrandId=1,ColorId=3,ModelYear ="2017",DailyPrice =450,Description ="Mercedes koltuk ısıtma,konfor,gelişmiş arayüz"},
                new Car{Id =2,BrandId=2,ColorId=3,ModelYear ="2018",DailyPrice =500,Description ="Bmw koltuk ısıtma,dokunmatik media sistemi"},
                new Car{Id =3,BrandId=2,ColorId=1,ModelYear ="2018",DailyPrice =700,Description ="Bmw geliştirilmiş arayüz,koltuk ısıtma"},
                new Car{Id =4,BrandId=3,ColorId=1,ModelYear ="2020",DailyPrice =1250,Description ="Volvo koltuk ısıtma,dokunmatik media sistemi"},
                new Car{Id =5,BrandId=3,ColorId=2,ModelYear ="2020",DailyPrice =1200,Description ="Volvo klima,koltuk ısıtma,geliştirilmiş arayüz"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete= _cars.SingleOrDefault(c => car.Id == c.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.Id == c.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
