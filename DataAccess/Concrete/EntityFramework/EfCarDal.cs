using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentAcarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using(RentAcarContext context = new RentAcarContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId

                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 BrandName = b.BrandName
                             };
                return result.ToList();
            }
        }
        
    }
}
