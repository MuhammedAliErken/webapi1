using Cars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Abstract
{
    public interface ICarRepository
    {
        List<Vehicle> GetVehicleType(string vehicletype);

        List<Car> GetCarByColor(string color);

        Car GetCarById(int id);

        List<Bus> GetBusByColor(string color);

        List<Boat> GetBoatByColor(string color);

        Car UpdateCarLight(Car car);

        void DeleteCar(int CarId);
    }
}
