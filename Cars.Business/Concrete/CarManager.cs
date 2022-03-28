using Cars.Business.Abstract;
using Cars.DataAccess.Abstract;
using Cars.DataAccess.Concrete;
using Cars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarRepository _carRepository;
        public CarManager()
        {
            _carRepository=new CarRepository();
        }
        public List<Vehicle> GetVehicleType(string vehicletype)
        {
            if (vehicletype!=null)
            {
                return _carRepository.GetVehicleType(vehicletype);
            }

            throw new Exception("Renk boş bırakılamaz");

        }

        public void DeleteCar(int CarId)
        {
            if (CarId>0)
            {
              _carRepository.DeleteCar(CarId);
            }
            else
                throw new Exception("ID 1 den küçük olamaz");
            
        }

        public List<Boat> GetBoatByColor(string color)
        {
            if (color!=null)
            {
                return _carRepository.GetBoatByColor(color);
            }
            else
                throw new Exception("Renk boş bırakılamaz");
            
        }

        public List<Bus> GetBusByColor(string color)
        {
            if (color!=null)
            {
                return _carRepository.GetBusByColor(color);
            }
            else
                throw new Exception("Renk boş bırakılamaz");
        }

        public List<Car> GetCarByColor(string color)
        {
                if (color!=null)
                {
                    return _carRepository.GetCarByColor(color);
            }
                else
                    throw new Exception("Renk boş bırakılamaz");
        }

        public Car GetCarById(int id)
        {
            if (id>0)
            {
                return _carRepository.GetCarById(id);
            }

            throw new Exception("ID 1 den küçük olamaz");
        }

        public Car UpdateCarLight(Car car)
        {
            return _carRepository.UpdateCarLight(car);
        }
    }
}
