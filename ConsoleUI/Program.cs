using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //ColorTest();
            //BrandTest();


            CarDetailTest();







        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brands in result.Data)
                {
                    Console.WriteLine(brands.BrandName);
                }
            }
            
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var colors in result.Data)
                {
                    Console.WriteLine(colors.ColorName);
                }
            }
            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var cars in result.Data)
                {
                    Console.WriteLine(cars.Description);
                    
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetailDtos();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "/" + car.ColorName + "/" + car.DailyPrice + "/" + car.BrandName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            } 
               


        }
    }
  }

