using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDbContent;

        public CarRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Car> Cars => appDbContent.Cars.Include(c => c.Category);
        public IEnumerable<Car> GetFavCars => appDbContent.Cars.Where(p => p.IsFavourite).Include(c=>c.Category);
        public Car GetObjectCar(int carId) => appDbContent.Cars.FirstOrDefault(p => p.Id == carId);
    }
}