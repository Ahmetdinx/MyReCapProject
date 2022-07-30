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
                new Car{CarId=1,ColorId=1,BrandId=1,ModelYear=2022,DailyPrice=100,Description="2022 model 100kmde alt segment araç."},
                new Car{CarId=2,ColorId=3,BrandId=2,ModelYear=2022,DailyPrice=200,Description="2022 model 50kmde vasat araç."},
                new Car{CarId=3,ColorId=5,BrandId=3,ModelYear=2022,DailyPrice=300,Description="2022 model 10kmde orta segment araç."},
                new Car{CarId=4,ColorId=2,BrandId=4,ModelYear=2022,DailyPrice=400,Description="2022 model 60kmde lüx araç."},
                new Car{CarId=5,ColorId=4,BrandId=5,ModelYear=2022,DailyPrice=500,Description="2022 model 25kmde ultra lüx araç."}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
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

        public List<Car> GetById(int cardId)
        {
            return _cars.Where(c => c.CarId == cardId ).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
