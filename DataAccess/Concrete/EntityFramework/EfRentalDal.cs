using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             join ca in context.Cars
                             on r.CarId equals ca.Id
                             join b in context.Brands
                             on ca.BrandId equals b.BrandId
                             join cl in context.Colors
                             on ca.ColorId equals cl.ColorId
                             join u in context.Users
                             on c.UserId equals u.Id

                             select new RentalDetailDto()
                             {
                                 Id = r.RentalId,
                                 CarId = r.CarId,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate,
                                 CarBrand = b.BrandName,
                                 CarColor = cl.ColorName,
                                 CompanyName = c.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName
                             };
                return result.ToList();
            }
        }
    }
}
