using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCar.Models
{
    public class MvcCarContext : DbContext
    {
        /// <summary>
        /// Used during dependency injection
        /// </summary>
        /// <param name="options"></param>
        public MvcCarContext(DbContextOptions<MvcCarContext> options) : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }

        internal CarsIndexVM[] ListCars()
        {
            return this.Car
            .Select(c => new CarsIndexVM
            {
                Brand = c.Brand,
                ShowAsFast = c.TopSpeed > 250
            })
            .ToArray();
        }

        internal async void AddCar(CarsCreateVMcs car)
        {
            Car carToAdd = new Car();
            carToAdd.Brand = car.Brand;
            carToAdd.Doors = car.Doors;
            carToAdd.TopSpeed = car.TopSpeed;

            await Car.AddAsync(carToAdd);

            await SaveChangesAsync(); //glöm inte denna!!
            
        }
    }
}
