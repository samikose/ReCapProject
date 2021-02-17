using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
     
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = carManager.GetCarDetails();
            
            if(result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("-{0} marka, {1} renk, {2} Tl, {3} model, {4}\n", brandManager.GetById(car.BrandId).BrandName,colorManager.GetById(car.ColorId).ColorName,car.ModelYear,car.DailyPrice,car.Description);
            //}



        }
    }
}
