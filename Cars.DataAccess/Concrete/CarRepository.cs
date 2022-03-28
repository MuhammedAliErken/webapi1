using Cars.DataAccess.Abstract;
using Cars.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Concrete
{
    public class CarRepository : ICarRepository
    {
        public List<Vehicle> GetVehicleType(string vehicletype)
        {
            using (var carsDbContext = new CarsDbContext())
            {
                return carsDbContext.Vehicles.Where(s => s.VehicleType==vehicletype).ToList();
            }

        }
        public void DeleteCar(int CarId)
        {
            using (var carsDbContext = new CarsDbContext())
            {
                var deletedCar = GetCarById(CarId);
                carsDbContext.Cars.Remove(deletedCar);
                carsDbContext.SaveChanges();
            }
        }


        public Car GetCarById(int id)
        {
            using (var carsDbContext = new CarsDbContext())
            {
                return carsDbContext.Cars.Find(id);
            }

        }
        public List<Boat> GetBoatByColor(string color)
        {
            using (var carsDbContext = new CarsDbContext())
            {
                return carsDbContext.Boats.Where(s=>s.VehicleType=="Boat").Where(a=>a.Color==color).ToList();
            }
        }

        public List<Bus> GetBusByColor(string color)
        {
            using (var carsDbContext = new CarsDbContext())
            {
                return carsDbContext.Buses.Where(s => s.VehicleType=="Bus").Where(a => a.Color==color).ToList();
            }
        }

        public List<Car> GetCarByColor(string color)
        {
           using(var carsDbContext=new CarsDbContext())
            {
                return carsDbContext.Cars.Where(s => s.VehicleType=="Car").Where(a => a.Color==color).ToList();
            }
        }

        public Car UpdateCarLight(Car car)
        {
            using (var carsDbContext = new CarsDbContext())
            {
               carsDbContext.Cars.Update(car);
                carsDbContext.SaveChanges();
               return car;
            }
        }
    }
}
