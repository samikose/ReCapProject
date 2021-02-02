using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
     
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            CarManager carManager = new CarManager(new InMemoryCarDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());


            Console.WriteLine("Elimizdeki araç markaları:");
            foreach (var brands in brandManager.GetAll())
            {
                
                Console.WriteLine(brands.BrandName);
            }
            Console.WriteLine();
            
            Console.WriteLine("Arabaların özellikleri:");
            Console.WriteLine();
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.ModelYear+" "+cars.Description +"  "+" Günlük Kiralama:"+" "+cars.DailyPrice );
                
            }
            Console.WriteLine();

            Console.WriteLine("Renk çeşitleri");

            foreach (var colors in colorManager.GetAll())
            {
                Console.WriteLine(colors.ColorName);
            }
        }
    }
}
