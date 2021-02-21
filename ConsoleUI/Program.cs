using Business.Abstract;
using Business.Concrete;
using Business.Constants;
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
    
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());

            //Console.WriteLine("CarId\tFirstName\tLastName\tCompanyName\tBrand\tColor\tRentDate\tReturnDate\t");
            //var result = rentalManager.GetRentalDetail();
            //foreach (var rental in result.Data)
            //{
            //    Console.WriteLine(rental.CarId + "\t" + rental.FirstName + "\t\t" + rental.LastName + "\t\t" + rental.CompanyName + "\t"
            //        + rental.CarBrand + "\t" + rental.CarColor + "\t" + rental.RentDate + "\t" + rental.ReturnDate);
            //}
            //var result = carManager.GetCarDetails();

            //if(result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            CustomerDeleting();
        }
        private static void CustomerDeleting()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Delete(new Customer { UserId = 5, CompanyName = "Y", CustomerId = 5 });
            Console.WriteLine(result.Message);
        }
    }
}
