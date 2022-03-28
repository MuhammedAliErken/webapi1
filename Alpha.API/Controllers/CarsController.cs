using Cars.Business.Abstract;
using Cars.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cars.Business.Concrete;

namespace Cars.API.Controllers
{
    
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarService _carService;

        public CarsController()
        {
            _carService= new CarManager();

        }

       

        [HttpPost("api/[controller]")]
        public Car Put([FromBody]Car car)
        {
            return _carService.UpdateCarLight(car);
        }

        [HttpDelete("api/[controller]/{CarId}")]
        public void Delete(int CarId)
        {
            _carService.DeleteCar(CarId);
        }

        [HttpGet("api/[controller]/{color}")]
        public List<Car> Get(string color)
        {
            return _carService.GetCarByColor(color);
        }


    }
}
